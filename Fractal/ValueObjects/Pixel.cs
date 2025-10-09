namespace Fractal.ValueObjects;

public struct Pixel
{
    byte R { get; set; }
    byte G { get; set; }
    byte B { get; set; }

    public Pixel(byte r, byte g, byte b)
    {
        R = r;
        G = g;
        B = b;
    }
}