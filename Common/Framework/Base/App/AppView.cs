using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;
using Framework.Base.View;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace Framework.Base.App
{
    public partial class AppView : XtraForm, IAppView
    {
        private KZTileNavPane _tileNav;

        public AppView(IUnityContainer container)
        {
            InitializeComponent();

            KZHelper = container.Resolve<IKZHelper>();

            SlideFadeTransitionManager = SetSlideFadeTransitionManager();

            GenerateApplications();
            FormClosing += AppView_FormClosing;
        }


        private HomeView HomeView { get; set; }

        private IKZHelper KZHelper { get; }
        private Dictionary<int, IContentView> DicViews { get; } = new Dictionary<int, IContentView>();

        private bool IsHome => HomeView == ownerControl.Tag;


        private TransitionManager SlideFadeTransitionManager { get; }

        public void AssignName()
        {
        }

        public void BindModel()
        {
        }

        public void BindEvent()
        {
        }


        private TransitionManager SetSlideFadeTransitionManager()
        {
            var transiton = new Transition();
            transiton.Control = ownerControl;


            var slideFadeTransition1 = new SlideFadeTransition();
            slideFadeTransition1.Parameters.Background = Color.Empty;
            slideFadeTransition1.Parameters.EffectOptions = PushEffectOptions.FromLeft;
            slideFadeTransition1.Parameters.FrameInterval = 1000;
            slideFadeTransition1.Parameters.FrameCount = 4000;

            transiton.TransitionType = slideFadeTransition1;

            var manager = new TransitionManager();
            manager.Transitions.Add(transiton);

            return manager;
        }


        private void HomeClick()
        {
            LoadView(HomeView);

            _tileNav.AdjustTitle(null, IsHome);
        }

        private void ItemClick(IApp app)
        {
            if (app != null)
            {
                if (!DicViews.ContainsKey(app.Id))
                {
                    if (KZHelper.Container.IsRegistered<IContentView>(app.Code))
                    {
                        var view = KZHelper.Container.Resolve<IContentView>(app.Code);
                        view.Owner = this;
                        view.LoadAppFunction(app);
                        DicViews.Add(app.Id, view);
                    }
                    else
                    {
                        var view = new BlankView(KZHelper.Container);
                        DicViews.Add(app.Id, view);
                    }
                }

                LoadView(DicViews[app.Id] as Control);

                _tileNav.AdjustTitle(app, IsHome);
            }
        }

        private void GenerateApplications()
        {
            HomeView = new HomeView(KZHelper.Container)
            {
                ListApps = KZHelper.Apps,
                Dock = DockStyle.Fill,
                ItemClick = ItemClick
            };

            LoadView(HomeView);

            _tileNav = new KZTileNavPane(KZHelper.Container, this)
            {
                HomeClick = HomeClick
            };
            _tileNav.ItemClick = ItemClick;
            _tileNav.ListApps = KZHelper.Apps;

            _tileNav.AdjustTitle(null, IsHome);

            panelTop.Controls.Add(_tileNav);
        }

        public void LoadView(Control control)
        {
            if (ownerControl.Tag != control)
            {
                SlideFadeTransitionManager.StartTransition(ownerControl);
                control.Dock = DockStyle.Fill;
                ownerControl.Controls.Clear();
                ownerControl.Controls.Add(control);
                ownerControl.Tag = control;
                SlideFadeTransitionManager.EndTransition();
            }
        }

        public bool AlertClose(string message)
        {
            return new KZFlyoutDialog(KZHelper.Container).Alert(this, message);
        }

        private void AppView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AlertClose(Resource.translate.AlertCloseProgram);
        }
    }
}