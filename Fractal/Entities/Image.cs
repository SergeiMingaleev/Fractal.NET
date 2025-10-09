using System.Collections.Generic;
using System.Linq;
using Fractal.NET.ValueObjects;

namespace Fractal.NET.Entities;

public class Image
{
    public List<List<Pixel>> Pixels;
    
    public Image(List<List<Pixel>> pixels)
    {
        Pixels = pixels.Select(row => new List<Pixel>(row)).ToList();
    }
}