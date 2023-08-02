using System;

class Progam
{
    static void Main()
    {
        try 
        {
            Console.Write("Enter an integer: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            Console.Write($"You entered number: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid ingegar");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"An error is: {exception}");
        }
    }
}