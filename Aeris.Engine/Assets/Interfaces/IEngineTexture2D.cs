using SkiaSharp;

namespace Aeris.Engine.Assets.Interfaces;

public interface IEngineTexture2D : IEngineAsset
{
    public int Width { get; set; }
    public int Height { get; set; }
    public SKBitmap Bitmap { get; set; }
    public SKImage Image { get; set; }
}