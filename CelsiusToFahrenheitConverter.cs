using System;

namespace CelsiusToFahrenheitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = GetDoubleInput();

            // Convert Celsius to Fahrenheit
            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

            // Display the equivalent temperature in Fahrenheit
            Console.WriteLine($"The equivalent temperature in Fahrenheit is: {fahrenheit:F2}°F");
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

        // Function to convert Celsius to Fahrenheit
        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}