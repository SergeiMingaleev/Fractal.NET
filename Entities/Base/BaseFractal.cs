using Fractal.NET.Abstractions;
using Fractal.NET.Constants;
using Fractal.NET.ValueObjects;
using System;
using System.Numerics;

namespace Fractal.NET.Entities.Base;

/// <summary>
/// Базовый класс фрактала, по умолчанию фрактал Мандельброта, 
/// в случае необходимости все нужные методы переопределяются в наследниках
/// </summary>
public abstract class BaseFractal : IFractal
{
    private int MaxIterationCount { get; set; }
    protected double Threshold { get; set; } = FractalConstants.MandelbrotConstants.DefaultThreshold;
    protected Box2D DefaultGeneratingBox { get; set; } = FractalConstants.MandelbrotConstants.DefaultGeneratingBox;
    protected IColorMap DefaultColorMap { get; set; }
    protected virtual Func<Complex, Complex, Complex> Z() =>
        (z0, c) => z0 * z0 + c;

    public BaseFractal(int maxIterationCount) => MaxIterationCount = maxIterationCount;
    public FractalData Generate(Box2D? box, IColorMap? map) 
    {

        throw new NotImplementedException();
        //var computingBox = box ?? DefaultGeneratingBox;
        //var colorMap = map ?? DefaultColorMap;

        //double xStep = (computingBox.Xmax - computingBox.Xmin) / (size - 1);
        //double yStep = (yMax - yMin) / (size - 1);
        //var z = z0;
        //double[,] scales = new double[size, size];

        //for (int yIndex = 0; yIndex < size; yIndex++)
        //{
        //    double y = yMax - yIndex * yStep;

        //    for (int xIndex = 0; xIndex < size; xIndex++)
        //    {
        //        double x = xMin + xIndex * xStep;
        //        var c = new Complex(x, y);

        //        for (var i = 0; i < iterationNumber; i++)
        //        {
        //            if (z.Magnitude > threshold)
        //            {
        //                scales[xIndex, yIndex] = i;
        //            }

        //            z = z.Square() + c;
        //        }

        //        z = z0;
        //    }
        //}
    }
}
