namespace Fractal;

/// <summary>
/// TODO: дописать!
/// </summary>
internal class ImageBox
{
    private (int Nx, int Ny) screen;
    private object box;

    public ImageBox((int Nx, int Ny) screen, object box)
    {
        this.screen = screen;
        this.box = box;
    }
}