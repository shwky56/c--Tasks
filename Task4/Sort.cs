using System;
using System.Linq;

public class Program
{
    private static void Main()
    {
        Console.WriteLine("Enter a list of strings separated by spaces:");
        string input = Console.ReadLine();

        // Split the input string into an array of strings using space as the delimiter
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Use LINQ to sort the array of strings in descending order based on their lengths
        var sortedWords = words.OrderByDescending(word => word.Length).ToArray();

        // Display the sorted array
        Console.WriteLine("\nSorted Array (Descending order based on length):");
        foreach (var word in sortedWords)
        {
            Console.WriteLine(word);
        }
    }
}
