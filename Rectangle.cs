using System;

public class Rectangle
{
    // Properties for length and width
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor to initialize the length and width of the rectangle
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Method to calculate the area of the rectangle
    public double CalculateArea()
    {
        return Length * Width;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an object of the Rectangle class
        Rectangle myRectangle = new Rectangle(5.0, 3.0);

        // Calculate and display the area of the rectangle
        double area = myRectangle.CalculateArea();
        Console.WriteLine("The area of the rectangle is: " + area);
    }
}
