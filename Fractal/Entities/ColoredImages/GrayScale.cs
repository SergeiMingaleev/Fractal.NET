using System;
using System.Collections.Generic;
using Fractal.NET.Abstractions;
using Fractal.NET.ValueObjects;

namespace Fractal.NET.Entities.ColoredImages;

public class GrayScale: IColoredImage
{
    public Image Create(FractalData value)
    {
        var counts = value.Counts;
        List<List<Pixel>> colored =  new List<List<Pixel>>(counts.Count);

        for (int i = 0; i < counts.Count; i++)
        {
            List<Pixel> row = new List<Pixel>(counts[i].Count);
            for (int j = 0; j < counts[i].Count; j++)
            {
                double t = (value.MaxIteration > 1) ? (double)counts[i][j] / (value.MaxIteration - 1) : 1.0;
                
                byte r = (byte)Math.Clamp((int)Math.Round(255.0 * t), 0, 255);
                byte g = r;
                byte b = r;

                row[j] = new Pixel(r, g, b);
            }
            colored[i] = row;
        }
        
        return new Image(colored);
    }
}