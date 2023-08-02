using System;

namespace ParameterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Before swap: a = {a}, b = {b}");

            // Using "ref" to swap values
            SwapValuesWithRef(ref a, ref b);
            Console.WriteLine($"After swap with 'ref': a = {a}, b = {b}");

            // Using "out" to swap values
            SwapValuesWithOut(out a, out b);
            Console.WriteLine($"After swap with 'out': a = {a}, b = {b}");
        }

        // Method to swap values using "ref" parameters
        static void SwapValuesWithRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Method to swap values using "out" parameters
        static void SwapValuesWithOut(out int x, out int y)
        {
            // We must assign a value to "out" parameters before returning from the method
            x = 0;
            y = 0;

            int temp = x;
            x = y;
            y = temp;
        }
    }
}
