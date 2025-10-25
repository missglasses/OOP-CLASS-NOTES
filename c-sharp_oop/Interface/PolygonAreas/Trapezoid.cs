using System;

public class Trapezoid : PolygonInterface
{
    private double a, b, c, d, height;

    public Trapezoid(double a, double b, double c, double d, double height)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
        this.height = height;
    }

    public double GetArea()
    {
        return ((a + b) / 2) * height;
    }

    public double GetPerimeter()
    {
        return a + b + c + d;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"A: {a}");
        Console.WriteLine($"B: {b}");
        Console.WriteLine($"C: {c}");
        Console.WriteLine($"D: {d}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine("All fields are private");
    }
}
