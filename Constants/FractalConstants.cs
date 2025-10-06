using Fractal.NET.ValueObjects;

namespace Fractal.NET.Constants;

public static class FractalConstants
{
    public static class MandelbrotConstants
    {
        public static readonly Box2D DefaultGeneratingBox = new Box2D()
        {
            Xmax = 1.25M,
            Xmin = -2.25M,

            Ymax = 1.75M,
            Ymin = -1.75M,
        };

        public static double DefaultThreshold = 2.0;
    }
}
