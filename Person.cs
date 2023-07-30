using System;

class Person
{
    // Properties of the Person class
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    // Constructor to initialize the properties
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Program
{
    static void Main()
    {
        // Creating objects of the Person class
        Person person1 = new Person("Alice", 30, "Female");
        Person person2 = new Person("Bob", 25, "Male");

        // Displaying details of the objects
        Console.WriteLine("Person 1 Details:");
        Console.WriteLine($"Name: {person1.Name}");
        Console.WriteLine($"Age: {person1.Age}");
        Console.WriteLine($"Gender: {person1.Gender}");
        Console.WriteLine();

        Console.WriteLine("Person 2 Details:");
        Console.WriteLine($"Name: {person2.Name}");
        Console.WriteLine($"Age: {person2.Age}");
        Console.WriteLine($"Gender: {person2.Gender}");
    }
}
