using System;

public class NumberGuessingGame
{
    private static readonly Random random = new Random();
    private static readonly int minNumber = 1;
    private static readonly int maxNumber = 100;

    private int targetNumber;

    public NumberGuessingGame()
    {
        targetNumber = random.Next(minNumber, maxNumber + 1);
    }

    public void StartGame()
    {
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine($"Guess a number between {minNumber} and {maxNumber}.");

        int attempts = 0;
        int guess;

        do
        {
            attempts++;
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out guess))
            {
                if (guess == targetNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.");
                    return;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (true);
    }
}

public class Program
{
    private static void Main()
    {
        NumberGuessingGame game = new NumberGuessingGame();
        game.StartGame();
    }
}
