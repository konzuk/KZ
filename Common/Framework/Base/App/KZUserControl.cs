using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Framework.Base.Helper;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Model;
using Microsoft.Practices.Unity;

namespace Framework.Base.App
{
    public class KZUserControl : XtraUserControl
    {
        private DXErrorProvider ErrorProvider { get; }

        public KZUserControl()
        {
            ErrorProvider = new DXErrorProvider {ContainerControl = this};
            
        }

        public KZUserControl(IUnityContainer container)
        {
            KZHelper = container.Resolve<IKZHelper>();
            ErrorProvider = new DXErrorProvider {ContainerControl = this};
        }
        protected void ResetValidationControl()
        {
            ErrorProvider.ClearErrors();
        }
        protected bool HasErrors()
        {
            //ErrorProvider.RefreshControls();
            return ErrorProvider.HasErrors;
        }
        

        protected void AssignValidationControl(Control control, Func<KZResultMessage> func, ErrorType errorType = ErrorType.Critical, ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleRight)
        {
            control.CausesValidation = true;

            control.Validated += (sender, args) =>
            {
                if (func != null)
                {
                    var message = func.Invoke();

                    if (message.IsSuccess)
                    {
                        ErrorProvider.SetError(sender as Control, message.Message, errorType);
                        ErrorProvider.SetIconAlignment(control, iconAlignment);
                    }
                    else
                    {
                        ErrorProvider.SetError(sender as Control, "");
                    }
                }
            };
        }
        
        protected MVVMContextFluentAPI<T> GetModelBindingManager<T>(T model) where T : class
        {
            var mvvmContext = new MVVMContext { ContainerControl = this };
            mvvmContext.SetViewModel(typeof(T), model);
            var fluentAPI = mvvmContext.OfType<T>();
            return fluentAPI;
        }
        protected IKZHelper KZHelper { get; set; }

        


    }
}