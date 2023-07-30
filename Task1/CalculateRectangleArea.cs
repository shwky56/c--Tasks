using System;

namespace RectangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Length");
            double length = GetDoubleInput();

            Console.WriteLine("Enter the Width");
            double width = GetDoubleInput();


            double area = CalculateRectangleArea(length, width);

            Console.WriteLine($"The Area is {area}");
        }

         // Function to get a valid double input from the user
        static double GetDoubleInput()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            return number;
        }

        // Function to calculate the area of the rectangle
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}