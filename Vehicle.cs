using System;

// Base class Vehicle
class Vehicle
{
    // Properties of the Vehicle class
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor to initialize the properties
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

// Derived class Car
class Car : Vehicle
{
    // Additional property for Car class
    public int NumberOfDoors { get; set; }

    // Constructor to initialize the Car properties
    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
}

// Derived class Motorcycle
class Motorcycle : Vehicle
{
    // Additional property for Motorcycle class
    public bool HasSideCar { get; set; }

    // Constructor to initialize the Motorcycle properties
    public Motorcycle(string make, string model, int year, bool hasSideCar)
        : base(make, model, year)
    {
        HasSideCar = hasSideCar;
    }
}

class Program
{
    static void Main()
    {
        // Create objects of the derived classes
        Car car1 = new Car("Toyota", "Corolla", 2023, 4);
        Motorcycle motorcycle1 = new Motorcycle("Harley-Davidson", "Sportster", 2022, false);

        // Display the properties of the objects
        Console.WriteLine("Car 1:");
        Console.WriteLine($"Make: {car1.Make}");
        Console.WriteLine($"Model: {car1.Model}");
        Console.WriteLine($"Year: {car1.Year}");
        Console.WriteLine($"Number of Doors: {car1.NumberOfDoors}");

        Console.WriteLine("\nMotorcycle 1:");
        Console.WriteLine($"Make: {motorcycle1.Make}");
        Console.WriteLine($"Model: {motorcycle1.Model}");
        Console.WriteLine($"Year: {motorcycle1.Year}");
        Console.WriteLine($"Has Sidecar: {motorcycle1.HasSideCar}");
    }
}
