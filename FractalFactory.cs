using Fractal.NET;
using Fractal.NET.Entities;
using Fractal.NET.Entities.Fractals;
using Fractal.NET.ValueObjects;
namespace Fractal;

/// <summary>
/// TODO: дописать!
/// </summary>
internal class FractalFactory
{
    /// <summary>
    /// TODO: дописать!
    /// </summary>
    internal void run()
    {
        // TODO: перенести все "магические" числа в Main().
        int countMax = 400;
        var screen = (Nx: 1920, Ny: 1080);
        string filename = "d:/mandelbrot.ppm";

        // TODO: раскидать всё по отдельным методам!?

        // Пока что у нас будет только один фрактал - так что сразу создаём его:
        FractalMandelbrot fractal = new();

        // Создадим бокс картинки для 2D бокса фрактала по умолчанию:
        //ImageBox iBox = new(screen, fractal.box);

        // Посчитаем фрактал для всех точек бокса картинки:
        //FractalData iCounts = fractal.calc(iBox, countMax);

        // Пересчитаем counts в цвета картинки:
        // TODO: обсудить концепт colormaps и переименовать этот класс в соответствии.
        //ImageColorMap iColormap = new();
        //ImagePixels iPixels = iColormap.process(iCounts);

        // Или пока просто вызовем статический метод?:
        //ImagePixels iPixels = ImageColorMap.process(iCounts);

        // 
        //ImageFile.save(filename, iPixels);

        //throw new NotImplementedException();
    }

    //private Box2D ConvertScreenToBox2D(Box2D defaultBox)
    //{

    //}
}
