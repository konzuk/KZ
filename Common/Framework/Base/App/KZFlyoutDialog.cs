using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;
using Resource;

namespace Framework.Base.App
{
    public class KZFlyoutDialog : FlyoutDialog, IKZFlyoutDialog
    {
        /// <summary>
        ///     Dialog Control
        /// </summary>
        /// <param name="container"></param>
        /// <param name="owner">A Form that owns this FlyoutDialog.</param>
        /// <param name="dialogControl">A Control that will be displayed by this FlyoutDialog.</param>
        public KZFlyoutDialog(IUnityContainer container, Form owner, Control dialogControl) : base(owner, dialogControl)
        {
            KZHelper = container.Resolve<IKZHelper>();

            dialogControl.MaximumSize = new Size(owner.Width - 150, owner.Height - 150);
        }

        /// <summary>
        ///     Confirmation Dialog
        /// </summary>
        /// <param name="container"></param>
        public KZFlyoutDialog(IUnityContainer container)
        {
            KZHelper = container.Resolve<IKZHelper>();

            action = new FlyoutAction();
            CommandYes = new FlyoutCommand {Text = Resource.translate.OK, Result = DialogResult.Yes};
            CommandNo = new FlyoutCommand {Text = Resource.translate.No, Result = DialogResult.No};
            action.Commands.Add(CommandYes);
            action.Commands.Add(CommandNo);


            properties = new FlyoutProperties();
            //properties.Appearance.BackColor = Color.Blue;
            //properties.Appearance.Options.UseBackColor = true;

            KZHelper.KZAppearanceSetter.SetAppearance(properties.Appearance, KZHelper.KZFonts.ContentFont);
            KZHelper.KZAppearanceSetter.SetAppearance(properties.AppearanceCaption, KZHelper.KZFonts.HeaderFont);
            KZHelper.KZAppearanceSetter.SetAppearance(properties.AppearanceButtons, KZHelper.KZFonts.ButtonFont);
            KZHelper.KZAppearanceSetter.SetAppearance(properties.AppearanceDescription, KZHelper.KZFonts.ContentFont);


            properties.ButtonSize = new Size(150, 40);
            properties.Style = FlyoutStyle.MessageBox;
        }


        private FlyoutAction action { get; }
        public FlyoutCommand CommandYes { get; set; }
        public FlyoutCommand CommandNo { get; set; }
        private FlyoutProperties properties { get; }

        public IKZHelper KZHelper { get; set; }

        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }

        public bool Alert(Form Owner, string Message, Image Image = null)
        {
            action.Caption = Resource.translate.Note;
            action.Description = Message;
            action.Image = Image;
            return Show(Owner, action, properties, canCloseFunc) == DialogResult.Yes;
        }
    }
}