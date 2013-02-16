using System;

public class SurfaceTriangle
{
    public static void Main()
    {
        Console.WriteLine(GetAreaWithAltitude(a: 4, h: 5));
        Console.WriteLine(GetAreaWithHeron(a: 3, b: 4, c: 5));
        Console.WriteLine(GetAreaWithAngle(a: 6, b: 8, alpha: 30));
    }

    private static double GetAreaWithAltitude(double a, double h)
    {
        return (a * h) / 2;
    }

    private static double GetAreaWithHeron(double a, double b, double c)
    {
        double p = (a + b + c) / 2;

        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private static double GetAreaWithAngle(double a, double b, double alpha)
    {
        return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
    }
}