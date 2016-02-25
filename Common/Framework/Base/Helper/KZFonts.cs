using System.Drawing;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class KZFonts : IKZFonts
    {
        public Font HeaderFont => new Font("Romnea", 15F);
        public Font ContentFont => new Font("Khmer OS Battambang", 12F);
        public Font ButtonFont => new Font("Khmer OS Battambang", 13F, FontStyle.Bold);
    }
}