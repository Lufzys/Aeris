using SkiaSharp;

namespace Aeris.Engine.Graphics;

public class Graphic
{
    public static SKTypeface Typeface { get; private set; }
    public static bool AntiAlias { get; set; } = true;
    public static SKFilterQuality Quality { get; set; } = SKFilterQuality.High;
    public static SKFontHinting FontHinting { get; set; } = SKFontHinting.Normal;
    
    static Graphic()
    {
        Typeface = SKTypeface.FromFamilyName("Arial");
    }
    
    public static SKPaint GetDefaultFont(SKColor color, float size = 9)
    {
        return new SKPaint
        {
            Typeface = Typeface,
            IsAntialias = AntiAlias,
            FilterQuality = Quality,
            TextSize = size,
            Color = color
        };
    }

    public static (SKBitmap Bitmap, SKImage Image) GetImageByFileName(string fileName)
    {
        using var stream = File.OpenRead(fileName);
        using var codec = SKCodec.Create(stream);
        var bitmap = SKBitmap.Decode(codec);
        var image = SKImage.FromBitmap(bitmap);
        return (bitmap, image);
    }
}