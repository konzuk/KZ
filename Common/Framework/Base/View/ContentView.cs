using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.MVVM;
using Framework.Base.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace Framework.Base.View
{
    public partial class ContentView : KZUserControl, IContentView

    {
        private IApp _app;

        public ContentView()
        {
            InitializeComponent();
        }


        public ContentView(IUnityContainer container) : base(container)
        {
            InitializeComponent();
            Load += ContentView_Load;
            AssignName();
            BindEvent();
        }


        public IApp App
        {
            get { return _app; }
            set
            {
                _app = value;

                panelFunctions.Visible = _app != null && _app.Functions != null && _app.Functions.Any();

                if (panelFunctions.Visible)
                {
                    var functionsButtons = new AppFunctionsView(KZHelper.Container);

                    functionsButtons.InitializeButtons(_app.Functions);

                    panelFunctions.Controls.Clear();

                    panelFunctions.Controls.Add(functionsButtons);
                    functionsButtons.Dock = DockStyle.Fill;
                }
            }
        }

        public virtual void AssignName()
        {
        }

        public virtual void BindEvent()
        {
        }

        public virtual void BindModel()
        {
        }

        public IViewBase Owner { get; set; }

        public virtual void LoadAppFunction(IApp app)
        {
            App = app;
        }

        protected MVVMContextFluentAPI<T> GetModelBindingManager<T>(T model) where T : class
        {
            var mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof (T), model);
            var fluentAPI = mvvmContext.OfType<T>();
            return fluentAPI;
        }


        private void ContentView_Load(object sender, EventArgs e)
        {
            BindModel();
        }

        protected void AssingFunction(IApp app, IFunction function, Action action)
        {
            if (app == null || !app.Functions.Any() || function == null) return;

            var func = app.Functions.SingleOrDefault(s => s.Code == function.Code);

            if (func != null)
            {
                func.ClickEventHandler = delegate { action?.Invoke(); };
            }
        }
    }
}