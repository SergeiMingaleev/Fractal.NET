using Fractal.NET.Abstractions;
using Fractal.NET.Entities.ColoredImages;
using Fractal.NET.Enums;

namespace Fractal.NET.Factories;

public class ColoredImageFactory
{
    public static IColoredImage Create(ColorImageType colorImage)
    {
        switch (colorImage)
        {
            case ColorImageType.Fire:
                return new Fire();
            case ColorImageType.GrayScale:
                return new GrayScale();
        }
        
        return new GrayScale();
    }
}