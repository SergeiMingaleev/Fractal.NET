using Fractal.NET.Entities;
using Fractal.NET.ValueObjects;

namespace Fractal.NET.Abstractions;

public interface IColoredImage
{
    Image Create(FractalData value);
}
