using System;

namespace Fractal;

/// <summary>
/// TODO: дописать!
/// </summary>
internal class FractalMandelbrot
{
    public Box2D box { get; internal set; }

    internal ImageCounts calc(ImageBox iBox, int countMax)
    {
        Console.WriteLine($"Посчитал counts для заданного iBox.");
        ImageCounts iCounts = new();
        //throw new NotImplementedException();
        return iCounts;
    }
}