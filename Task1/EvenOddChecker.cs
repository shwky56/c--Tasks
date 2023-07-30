using System;

namespace EvenOddChecker
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            int number = GetIntInput();

            // Check if the number is even or odd and display the result
            string result = IsEven(number) ? "even" : "odd";
            Console.WriteLine($"The number {number} is {result}.");
        }

        // Function to get a valid integer input from the user
        static int GetIntInput()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return number;
        }

        // Function to check if a number is even
        static bool IsEven(int number)
        {
            // Using the modulo operator (%) to check if the remainder is 0
            return number % 2 == 0;
        }
    }
}
