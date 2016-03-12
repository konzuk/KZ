using System;
using System.Windows.Forms;
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
            simpleButtonSaveNew.Font = KZHelper.KZFonts.ButtonFont;
            simpleButtonSave.Font = KZHelper.KZFonts.ButtonFont;
            simpleButtonClose.Font = KZHelper.KZFonts.ButtonFont;
            
            Load += ContentView_Load;
            simpleButtonClose.Click += SimpleButtonClose_Click;
            simpleButtonSave.Click += SimpleButtonSave_Click;
            simpleButtonSaveNew.Click += SimpleButtonSaveNew_Click;

            simpleButtonClose.Text = Resource.translate.Close;
            simpleButtonSave.Text = Resource.translate.Save;
            simpleButtonSaveNew.Text = Resource.translate.SaveNew;

        }

        private void SimpleButtonSaveNew_Click(object sender, EventArgs e)
        {
            this.OnSaveNew();
        }

        private void SimpleButtonSave_Click(object sender, EventArgs e)
        {
            this.OnSave();
        }

        private void SimpleButtonClose_Click(object sender, EventArgs e)
        {
            this.OnClose();
        }

        protected virtual void OnClose()
        {
            
        }
        protected virtual void OnSave()
        {

        }
        protected virtual void OnSaveNew()
        {

        }
        protected void CloseOnSaveComplete()
        {
            this.simpleButtonClose.DialogResult = DialogResult.OK;
            this.simpleButtonClose.PerformClick();
        }

        protected string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        protected string SaveText
        {
            get { return this.simpleButtonSave.Text; }
            set { this.simpleButtonSave.Text = value; }
        }
        protected string SaveNewText
        {
            get { return this.simpleButtonSaveNew.Text; }
            set { this.simpleButtonSaveNew.Text = value; }
        }
        protected string CloseText
        {
            get { return this.simpleButtonClose.Text; }
            set { this.simpleButtonClose.Text = value; }
        }

        protected bool SaveVisible
        {
            get { return this.simpleButtonSave.Visible; }
            set { this.simpleButtonSave.Visible = value; }
        }
        protected bool SaveNewVisible
        {
            get { return this.simpleButtonSaveNew.Visible; }
            set { this.simpleButtonSaveNew.Visible = value; }
        }

        protected bool SaveEnabled
        {
            get { return this.simpleButtonSave.Enabled; }
            set { this.simpleButtonSave.Enabled = value; }
        }
        protected bool SaveNewEnabled
        {
            get { return this.simpleButtonSaveNew.Enabled; }
            set { this.simpleButtonSaveNew.Enabled = value; }
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
        
        private void ContentView_Load(object sender, EventArgs e)
        {
            AssignName();
            BindEvent();
            BindModel();
        }
    }
}