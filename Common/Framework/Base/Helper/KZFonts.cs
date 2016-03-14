using System.Drawing;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class KZFonts : IKZFonts
    {
        public Font HeaderFont => new Font("Romnea", 15F);
        public Font ContentFont => new Font("Khmer SBBIC Serif", 10F);
        public Font ButtonFont => new Font("Khmer SBBIC Serif", 13F, FontStyle.Bold);
        public Font ContentBoldFont => new Font("Khmer SBBIC Serif", 10F, FontStyle.Bold);
    }
}