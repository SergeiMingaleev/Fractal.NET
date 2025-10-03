using Fractal.NET.ValueObjects;

namespace Fractal.NET.Entities;

/// <summary>
/// TODO: дописать!
/// </summary>
public class ImageBox
{
    private (int Nx, int Ny) Screen;
    private Box2D Box;

    public ImageBox((int Nx, int Ny) screen, Box2D box)
    {
        Screen = screen;
        Box = box;
    }
}