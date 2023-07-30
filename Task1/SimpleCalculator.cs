using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            double number1 = GetDoubleInput();

            // Prompt the user to enter the operator
            Console.Write("Enter the operator (+, -, *, /): ");
            char @operator = GetOperatorInput();

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            double number2 = GetDoubleInput();

            // Calculate the result based on the operator
            double result = PerformCalculation(number1, @operator, number2);

            // Display the result
            Console.WriteLine($"Result: {result}");
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

        // Function to get a valid operator (+, -, *, or /) from the user
        static char GetOperatorInput()
        {
            char @operator;
            while (!char.TryParse(Console.ReadLine(), out @operator) || !IsValidOperator(@operator))
            {
                Console.WriteLine("Invalid input. Please enter a valid operator (+, -, *, /).");
            }
            return @operator;
        }

        // Function to check if the operator is valid
        static bool IsValidOperator(char @operator)
        {
            return @operator == '+' || @operator == '-' || @operator == '*' || @operator == '/';
        }

        // Function to perform the calculation based on the operator
        static double PerformCalculation(double number1, char @operator, double number2)
        {
            switch (@operator)
            {
                case '+':
                    return number1 + number2;
                case '-':
                    return number1 - number2;
                case '*':
                    return number1 * number2;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        Environment.Exit(1); // Exit the program with an error code
                    }
                    return number1 / number2;
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    Environment.Exit(1); // Exit the program with an error code
                    return 0; // This line is not necessary, but required by the compiler
            }
        }
    }
}
