using System.Drawing;

namespace Fractal.Abstractions;

public interface IColorMap
{
    Color GetColor(int value);
}
