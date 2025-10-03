using System.Collections.Generic;
using System.Drawing;

namespace Fractal.NET.ValueObjects;

/// <summary>
/// TODO: дописать!
/// </summary>
public struct FractalData
{
    public Box2D Box { get; init; }
    public List<List<Color>> ColoredCounts { get; init; }
}