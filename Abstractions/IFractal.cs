using Fractal.NET.ValueObjects;

namespace Fractal.NET.Abstractions;

public interface IFractal
{
    FractalData Generate(Box2D? box, IColorMap? colorMap);
}
