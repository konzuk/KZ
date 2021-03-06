﻿using System.Drawing;

namespace Framework.Interfaces.Helper
{
    public interface IKZFonts
    {
        Font HeaderFont { get; }
        Font ContentFont { get; }
        Font ContentBoldFont { get; }
        Font ButtonFont { get; }
    }
}