using Fractal.NET.Abstractions;
using Fractal.NET.Constants;
using Fractal.NET.ValueObjects;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fractal.NET.Entities.Base;

/// <summary>
/// Базовый класс фрактала, по умолчанию фрактал Мандельброта, 
/// в случае необходимости все нужные методы переопределяются в наследниках
/// </summary>
public abstract class BaseFractal : IFractal
{
    protected double Threshold { get; set; } = FractalConstants.MandelbrotConstants.DefaultThreshold;
    protected ImageBox DefaultGeneratingBox { get; set; } = FractalConstants.MandelbrotConstants.DefaultMandelbrotImageBox;
    protected virtual Func<Complex, Complex, Complex> Z() =>
        (z0, c) => z0 * z0 + c;

    public FractalData Generate(ImageBox? box, int? maxIterations) 
    {
        var maxIter = maxIterations ?? FractalConstants.MaxIteration;
        var imageBox = box ?? DefaultGeneratingBox;
        Box2D computingBox = imageBox.Box;
        var z0 = new Complex(0,0);
        var z = z0;

        int xSize = imageBox.Screen.Nx;
        var xStep = (computingBox.Xmax - computingBox.Xmin) / (xSize - 1);

        int ySize = imageBox.Screen.Ny;
        var yStep = (computingBox.Ymax - computingBox.Ymin) / (ySize - 1);

        var counts = new List<List<int>>(ySize);

        for (int yIndex = 0; yIndex < ySize; yIndex++)
        {
            var y = computingBox.Ymax - yIndex * yStep;

            for (int xIndex = 0; xIndex < xSize; xIndex++)
            {
                var x = computingBox.Xmin + xIndex * xStep;
                var c = new Complex((double)x, (double)y);

                for (var i = 0; i < maxIter; i++)
                {
                    if (z.Magnitude > FractalConstants.MandelbrotConstants.DefaultThreshold)
                    {
                        counts[xIndex].Add(i);
                    }

                    z = Z().Invoke(z,c);
                }

                z = z0;
            }
        }

        return new FractalData()
        {
            MaxIteration = maxIter,
            Counts = counts,
        };
    }
}
