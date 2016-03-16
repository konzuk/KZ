using System.Drawing;
using Framework.Interfaces.Helper;

namespace Framework.Base.Helper
{
    public class KZColours : IKZColours
    {
        public IKZColour MainColour => new KZColour(Color.DarkSlateBlue, Color.SlateBlue, Color.GhostWhite);
        public IKZColour MainForeColour => new KZColour(Color.White, Color.LightGray, Color.DarkSlateBlue);
        public IKZColour FormColour => new KZColour(Color.White, Color.LightGray, Color.LightSkyBlue);
        public IKZColour FormForeColour => new KZColour(Color.Black, Color.Black, Color.Gray);

        public IKZColour TileColour
            => new KZColour(Color.DarkSlateBlue, Color.SlateBlue, Color.GhostWhite);

        public IKZColour TileForeColour => new KZColour(Color.White, Color.White, Color.DarkSlateBlue);
    }
}