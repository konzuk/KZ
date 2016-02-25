using System;
using System.Drawing;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class Function : HelperObject, IFunction
    {
        public Image Image { get; set; }
        public bool IsHidden { get; set; }
        public EventHandler ClickEventHandler { get; set; }
    }
}