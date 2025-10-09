using Fractal.Abstractions;
using Fractal.Entities.ColoredImages;
using Fractal.Enums;

namespace Fractal.Factories;

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