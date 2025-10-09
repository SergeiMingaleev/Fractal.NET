using System.Drawing;

namespace Fractal.NET.Abstractions;

public interface IColorMap
{
    Color GetColor(int value);
}
