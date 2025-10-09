//***************************************************************************************
// CODE STYLE:
// -- строки до 90 символов (?).
// -- имена переменных согласно
// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/identifier-names
//    --> имена классов и методов - PascalCase.
//    --> имена параметров методов - camelCase.
// -- ваши предложения?
// **************************************************************************************

using Fractal.NET;
using Fractal.NET.Abstractions;
using Fractal.NET.Constants;
using Fractal.NET.Entities.ColoredImages;
using Fractal.NET.Entities.Writers;
using Fractal.NET.Enums;
using Fractal.NET.Factories;

internal class Program
{
    static void Main(string[] args)
    {
        var fractal = FractalFactory.Generate(FractalType.Mandelbrot);
        var data = fractal.Generate(
            FractalConstants.MandelbrotConstants.DefaultMandelbrotImageBox,
            FractalConstants.MaxIteration
        );

        IColoredImage palette = ColoredImageFactory.Create(ColorImageType.GrayScale);
        var img = palette.Create(data);
        PPMWriter.Save(img,"Youth path here");
    }

    //    /// <summary>
    //    /// TODO: дописать!
    //    /// </summary>
    //public void run()
    //{
    //    // TODO: перенести все "магические" числа в Main().
    //    int countMax = 400;
    //    var screen = (Nx: 1920, Ny: 1080);
    //    string filename = "d:/mandelbrot.ppm";

    //    // TODO: раскидать всё по отдельным методам!?

    //    // Пока что у нас будет только один фрактал - так что сразу создаём его:
    //    FractalMandelbrot fractal = new();

    //    // Создадим бокс картинки для 2D бокса фрактала по умолчанию:
    //    //ImageBox iBox = new(screen, fractal.box);

    //    // Посчитаем фрактал для всех точек бокса картинки:
    //    //FractalData iCounts = fractal.calc(iBox, countMax);

    //    // Пересчитаем counts в цвета картинки:
    //    // TODO: обсудить концепт colormaps и переименовать этот класс в соответствии.
    //    //ImageColorMap iColormap = new();
    //    //ImagePixels iPixels = iColormap.process(iCounts);

    //    // Или пока просто вызовем статический метод?:
    //    //ImagePixels iPixels = ImageColorMap.process(iCounts);

    //    // 
    //    //ImageFile.save(filename, iPixels);

    //    //throw new NotImplementedException();
    //}
}

