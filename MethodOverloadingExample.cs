using System;

namespace MethodOverloadingExample
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to add three integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Method to add two double values
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Using the Add method with two integers
            int sum1 = calculator.Add(5, 10);
            Console.WriteLine($"Sum of 5 and 10 is: {sum1}");

            // Using the Add method with three integers
            int sum2 = calculator.Add(10, 20, 30);
            Console.WriteLine($"Sum of 10, 20, and 30 is: {sum2}");

            // Using the Add method with two double values
            double sum3 = calculator.Add(3.14, 2.71);
            Console.WriteLine($"Sum of 3.14 and 2.71 is: {sum3}");

            Console.ReadLine();
        }
    }
}
