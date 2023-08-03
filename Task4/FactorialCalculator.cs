using System;

namespace FactorialCalculator
{
    class Program
    {
        // Memoization array to store previously calculated factorials
        static long[] memo;

        static void Main()
        {
            Console.Write("Enter a number to calculate its factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
            }
            else
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }

            // Initialize the memoization array
            memo = new long[number + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1; // -1 indicates that the factorial is not yet calculated for the corresponding index
            }
        }

        // Recursive method to calculate factorial
        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1; // Base case: Factorial of 0 and 1 is 1
            }
            else
            {
                return n * CalculateFactorial(n - 1); // Recursion: n! = n * (n-1)!
            }
        }
        static long CalculateFactorialDp(int n)
        {
            // Base case: Factorial of 0 is 1
            if (n == 0)
            {
                return 1;
            }

            // If the factorial is already calculated for this number, return the stored value
            if (memo[n] != -1)
            {
                return memo[n];
            }

            // Otherwise, calculate the factorial recursively and store the result in the memoization array
            memo[n] = n * CalculateFactorial(n - 1);

            return memo[n];
        }
    }
}
