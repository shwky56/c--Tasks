
using System;
using System.Collections.Generic;

namespace Inventor
{
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

public class InventoryManagementSystem
{
    private List<Product> inventory = new List<Product>();

    // Method to add a new product to the inventory
    public void AddProduct()
    {
        Console.WriteLine("Enter product name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter product price:");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Enter product quantity:");
        int quantity = int.Parse(Console.ReadLine());

        Product product = new Product
        {
            Name = name,
            Price = price,
            Quantity = quantity
        };

        inventory.Add(product);

        Console.WriteLine("Product added successfully!");
    }

    // Method to remove a product from the inventory
    public void RemoveProduct()
    {
        Console.WriteLine("Enter the name of the product you want to remove:");
        string productName = Console.ReadLine();

        Product productToRemove = inventory.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

        if (productToRemove != null)
        {
            inventory.Remove(productToRemove);
            Console.WriteLine("Product removed successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    // Method to update a product in the inventory
    public void UpdateProduct()
    {
        Console.WriteLine("Enter the name of the product you want to update:");
        string productName = Console.ReadLine();

        Product productToUpdate = inventory.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));

        if (productToUpdate != null)
        {
            Console.WriteLine("Enter updated product name:");
            string updatedName = Console.ReadLine();

            Console.WriteLine("Enter updated product price:");
            decimal updatedPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter updated product quantity:");
            int updatedQuantity = int.Parse(Console.ReadLine());

            productToUpdate.Name = updatedName;
            productToUpdate.Price = updatedPrice;
            productToUpdate.Quantity = updatedQuantity;

            Console.WriteLine("Product updated successfully!");
        }
        else
        {
            Console.WriteLine("Product not found!");
        }
    }

    // Method to display all products in the inventory
    public void DisplayInventory()
    {
        if (inventory.Count > 0)
        {
            Console.WriteLine("Inventory:");
            foreach (var product in inventory)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
        else
        {
            Console.WriteLine("Inventory is empty!");
        }
    }
}

public class Program
{
    private static InventoryManagementSystem inventorySystem = new InventoryManagementSystem();

    private static void Main()
    {
        Console.WriteLine("Welcome to the Inventory Management System!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Product");
            Console.WriteLine("4. Display Inventory");
            Console.WriteLine("5. Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    inventorySystem.AddProduct();
                    break;
                case 2:
                    inventorySystem.RemoveProduct();
                    break;
                case 3:
                    inventorySystem.UpdateProduct();
                    break;
                case 4:
                    inventorySystem.DisplayInventory();
                    break;
                case 5:
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