using System;

public class Square : PolygonInterface
{
    private double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetArea()
    {
        return side * side;
    }

    public double GetPerimeter()
    {
        return 4 * side;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Side: {side}");
        Console.WriteLine("All fields are private");
    }
}
