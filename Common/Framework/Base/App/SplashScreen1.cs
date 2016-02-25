using System;
using DevExpress.XtraSplashScreen;
using Framework.Interfaces.App;

namespace Framework.Base.App
{
    public partial class SplashScreen1 : SplashScreen, ISplashScreenView
    {
        public enum SplashScreenCommand
        {
        }

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}