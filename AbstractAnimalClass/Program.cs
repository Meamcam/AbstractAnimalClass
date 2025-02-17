using System;

abstract class Animal
{
        // abstract property //
    public abstract string Name { get; set; }

        // abstract method (must be overridden) //
    public abstract string DescribeAnimal();
}

class Hamster : Animal
{
        // properties //
    public override string Name { get; set; }
    public string Color { get; set; }
    public double Weight { get; set; }

        // default constructor //
    public Hamster()
    {
        Name = "Unknown";
        Color = "Brown";
        Weight = 0.5; // default hampster weight in ounces
    }

        // parameterized constructor //
    public Hamster(string name, string color, double weight)
    {
        Name = name;
        Color = color;
        Weight = weight;
    }

        // overriding the DescribeAnimal method //
    public override string DescribeAnimal()
    {
        return $"This hamster's name is {Name}, it has {Color} fur and weighs {Weight} ounces.";
    }
}

class Program
{
    static void Main()
    {
            // using the default constructor //
        Hamster hamster1 = new Hamster();
        Console.WriteLine(hamster1.DescribeAnimal());

         // using the parameterized constructor //
        Hamster hamster2 = new Hamster("Zero", "Golden", 3.2);
        Console.WriteLine(hamster2.DescribeAnimal());
    }
}
