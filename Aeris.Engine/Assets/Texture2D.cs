using Aeris.Engine.Assets.Interfaces;
using Aeris.Engine.Graphics;
using SkiaSharp;

namespace Aeris.Engine.Assets;

public class Texture2D : IEngineTexture2D
{
    public static string[] Extensions { get; } = new[] { ".png", ".jpg" };
    public string Path { get; }
    public uint Id { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public SKBitmap Bitmap { get; set; }
    public SKImage Image { get; set; }

    public Texture2D(string path)
    {
        Path = path;
        var imageData = Graphic.GetImageByFileName(Path);
        Bitmap = imageData.Bitmap;
        Image = imageData.Image;
        Width = Bitmap.Width; 
        Height = Bitmap.Height;
        Id = (uint)Assets.Texture.Count;
        Assets.Texture.Add(this);
    }

    public void Dispose()
    {
        Bitmap.Dispose();
        Image.Dispose();
    }
}