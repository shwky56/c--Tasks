using System;

// Define the IShape interface with a method to calculate the area
public interface IShape
{
    double CalculateArea();
}

// Circle class implementing the IShape interface
public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Calculate the area of the circle
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Triangle class implementing the IShape interface
public class Triangle : IShape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }

    // Calculate the area of the triangle
    public double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}

// Square class implementing the IShape interface
public class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    // Calculate the area of the square
    public double CalculateArea()
    {
        return Side * Side;
    }
}

public class Program
{
    public static void Main()
    {
        // Create instances of different shapes
        var circle = new Circle(5.0);
        var triangle = new Triangle(4.0, 6.0);
        var square = new Square(3.0);

        // Calculate and display the area of each shape
        Console.WriteLine("Area of the Circle: " + circle.CalculateArea());
        Console.WriteLine("Area of the Triangle: " + triangle.CalculateArea());
        Console.WriteLine("Area of the Square: " + square.CalculateArea());
    }
}
