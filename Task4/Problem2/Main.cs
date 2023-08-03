
using System;
using System.Collections.Generic;
namespace Book

{

    public class Program
    {
        private static List<Book> books = new List<Book>();

        private static void AddBook()
        {
            Console.WriteLine("Enter book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter book author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter publication year:");
            int publicationYear = int.Parse(Console.ReadLine());

            Book book = new Book
            {
                Title = title,
                Author = author,
                PublicationYear = publicationYear
            };

            books.Add(book);

            Console.WriteLine("Book added successfully!");
        }

        private static void RemoveBook()
        {
            Console.WriteLine("Enter the title or author of the book you want to remove:");
            string searchTerm = Console.ReadLine();

            Book bookToRemove = books.Find(book => book.Title.Equals(searchTerm, StringComparison.OrdinalIgnoreCase)
                                                || book.Author.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully!");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }

        private static void SearchBooks()
        {
            Console.WriteLine("Enter the title or author to search for:");
            string searchTerm = Console.ReadLine();

            List<Book> matchingBooks = books.FindAll(book => book.Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
                                                        || book.Author.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

            if (matchingBooks.Count > 0)
            {
                Console.WriteLine("Matching books:");
                foreach (var book in matchingBooks)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Publication Year: {book.PublicationYear}");
                }
            }
            else
            {
                Console.WriteLine("No books found!");
            }
        }

        private static void Main()
        {
            Console.WriteLine("Welcome to the Book Manager!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Search Books");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        SearchBooks();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
