using System;

namespace MaxElementInArray
{
    class Program
    {
        static void Main()
        {
            // Initialize an array with values (you can change the values as needed)
            int[] numbers = { 10, 5, 15, 20, 7 };

            // Find the maximum element in the array
            int maxElement = FindMaxElement(numbers);

            // Display the result
            Console.WriteLine($"The maximum element in the array is: {maxElement}");
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

        // Function to find the maximum element in an array
        static int FindMaxElement(int[] array)
        {
            int maxElement = int.MinValue;
            foreach (int number in array)
            {
                if (number > maxElement)
                {
                    maxElement = number;
                }
            }
            return maxElement;
        }
    }
}
