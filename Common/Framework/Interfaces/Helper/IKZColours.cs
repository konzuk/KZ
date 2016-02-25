namespace Framework.Interfaces.Helper
{
    public interface IKZColours
    {
        IKZColour MainColour { get; }
        IKZColour MainForeColour { get; }
        IKZColour FormColour { get; }
        IKZColour FormForeColour { get; }

        IKZColour TileColour { get; }
        IKZColour TileForeColour { get; }
    }
}