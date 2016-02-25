using System;
using DevExpress.Utils.MVVM;
using Framework.Base.App;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace Framework.Base.View
{
    public partial class DialogView : KZUserControl, IDialogView

    {
        public DialogView()
        {
            InitializeComponent();
        }

        public DialogView(IUnityContainer container) : base(container)
        {
            InitializeComponent();
            labelTitle.Font = KZHelper.KZFonts.HeaderFont;
            simpleButton1.Font = KZHelper.KZFonts.ButtonFont;
            simpleButton2.Font = KZHelper.KZFonts.ButtonFont;
            simpleButton3.Font = KZHelper.KZFonts.ButtonFont;
            AssignName();
            BindEvent();
            Load += ContentView_Load;
        }

        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
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

        public IContentView OwnerView { get; set; }


        protected MVVMContextFluentAPI<T> GetModelBindingManager<T>(T model) where T : class
        {
            var mvvmContext = new MVVMContext {ContainerControl = this};
            mvvmContext.SetViewModel(typeof (T), model);
            var fluentAPI = mvvmContext.OfType<T>();
            return fluentAPI;
        }

        private void ContentView_Load(object sender, EventArgs e)
        {
            BindModel();
        }
    }
}