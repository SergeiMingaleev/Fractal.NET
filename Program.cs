//***************************************************************************************
// CODE STYLE:
// -- строки до 90 символов (?).
// -- имена переменных согласно
// https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/coding-style/identifier-names
//    --> имена классов и методов - PascalCase.
//    --> имена параметров методов - camelCase.
// -- ваши предложения?
// **************************************************************************************

using Fractal;
using Fractal.Abstractions;
using Fractal.Constants;
using Fractal.Entities;
using Fractal.Entities.Writers;
using Fractal.Enums;
using Fractal.Factories;

internal class Program
{
    static void Main(string[] args)
    {
        // Хотелось бы использовать эти классы и как библиотеку,
        // с простыми для доступа именами:
        //var fractal = new FractalMandelbrot();
        //ImageBox ibox = new ImageBox(fractal.box);
        //int maxIter = 500;
        //var data = fractal.Generate(ibox, maxIter);
        //IColoredImage palette = new Fire();
        //var img = palette.Create(data);
        //img.Save("imgFfs.ppm");

        // Сейчас namespace слишком длинный - должен быть просто Fractal?
        //var fractal = new Fractal.Entities.Fractals.FractalMandelbrot();

        // Подготовка расчетов:
        FractalType fractalType = FractalType.Mandelbrot;
        //ImageBox iBox = Fractal.Constants.Mandelbrot.DefaultImageBox;
        //ImageBox iBox = Fractal.Constants.Mandelbrot.ImageBox;
        ImageBox iBox = FractalConstants.MandelbrotConstants.DefaultMandelbrotImageBox;
        // Default MaxIteration - видимо, должно быть свойством каждого фрактала, а не общим?
        //int maxIter = Fractal.Constants.Mandelbrot.MaxIteration;
        int maxIter = FractalConstants.MaxIteration;
        ColorImageType colorType = ColorImageType.Fire;

        // Сами расчты, скорее всего в цикле (zoom in/out, etc).
        var fractal = FractalFactory.Generate(fractalType);
        var data = fractal.Generate(iBox, maxIter);
        // Почему интерфейс так используется? - делает реальную работу?
        IColoredImage palette = ColoredImageFactory.Create(colorType);
        var img = palette.Create(data);
        // Вопрос: может перенести Save внутрь Image?
        // img.Save(string filename, string format?=null)
        PPMWriter.Save(img,"imgFfs.ppm");
    }

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

