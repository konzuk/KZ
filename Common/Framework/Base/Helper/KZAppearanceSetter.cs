using System.Drawing;
using DevExpress.Utils;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class KZAppearanceSetter : IKZAppearanceSetter
    {
        public void SetAppearance(AppearanceObject appearance, Font font = null, Color backColor = default(Color),
            Color foreColor = default(Color))
        {
            if (appearance != null)
            {
                if (font != null)
                {
                    appearance.Font = font;
                    appearance.Options.UseFont = true;
                }

                if (backColor != default(Color))
                {
                    appearance.BackColor = backColor;
                    appearance.Options.UseBackColor = true;
                }
                if (foreColor != default(Color))
                {
                    appearance.ForeColor = foreColor;
                    appearance.Options.UseForeColor = true;
                }
            }
        }
    }
}