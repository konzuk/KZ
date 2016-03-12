using System.Drawing;
using DevExpress.XtraBars.Docking2010;
using Framework.Interfaces.App;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace Framework.Base.App
{
    public partial class AppFunctionsView : KZUserControl
    {
        public AppFunctionsView(IUnityContainer container)
            : base(container)
        {
            InitializeComponent();

            windowsUIButtonPanel2.BackColor = KZHelper.KZColours.MainColour.ActiveColour;

            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Hovered,
                KZHelper.KZFonts.ButtonFont
                , KZHelper.KZColours.MainForeColour.HoverColour, KZHelper.KZColours.MainForeColour.HoverColour);


            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Normal,
                KZHelper.KZFonts.ButtonFont
                , KZHelper.KZColours.MainForeColour.ActiveColour, KZHelper.KZColours.MainForeColour.ActiveColour);

            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Pressed,
                KZHelper.KZFonts.ButtonFont
                , KZHelper.KZColours.MainForeColour.HoverColour, KZHelper.KZColours.MainForeColour.HoverColour);
        }

        public static Image SplitterImage => new Bitmap(100, 10);

        public static Image SplitterImageCore { get; set; }

        public void InitializeButtons(KZBindingList<IFunction> listFunctions)
        {
            Visible = true;
            windowsUIButtonPanel2.Buttons.Clear();
            windowsUIButtonPanel2.HidePeekForm();


            foreach (var function in listFunctions)
            {
                if (function.IsHidden) continue;

                WindowsUIButton button;
                if (function.Name == null && function.Image == null)
                {
                    button = new WindowsUIButton
                    {
                        Enabled = false,
                        UseCaption = false,
                        Image = SplitterImage
                    };
                    windowsUIButtonPanel2.Buttons.Add(button);
                }
                else
                {
                    button = new WindowsUIButton(function.Name, function.Image, 0, ButtonStyle.PushButton, 0)
                    {
                        Tag = function
                    };
                    button.Click += function.ClickEventHandler;


                    var space = new WindowsUIButton
                    {
                        Enabled = false,
                        UseCaption = false
                    };


                    windowsUIButtonPanel2.Buttons.Add(space);
                    windowsUIButtonPanel2.Buttons.Add(button);
                }
            }
        }
    }
}