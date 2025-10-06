using Fractal.NET.Entities;

namespace Fractal.NET.ValueObjects;

public struct BuildingFractalParamsDto
{
    public ImageBox? Box { get; init; }
    public int? MaxIterations { get; init; }
}
