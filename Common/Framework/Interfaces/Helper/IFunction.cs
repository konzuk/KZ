using System;
using System.Drawing;

namespace Framework.Interfaces.Helper
{
    public interface IFunction : IHelperObject
    {
        bool IsHidden { get; set; }
        Image Image { get; set; }
        EventHandler ClickEventHandler { get; set; }
    }
}