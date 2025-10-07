using Fractal.NET.Entities;
using Fractal.NET.ValueObjects;

namespace Fractal.NET.Abstractions;

public interface IFractal
{
    FractalData Generate(ImageBox? box, int? maxIterations);
}
