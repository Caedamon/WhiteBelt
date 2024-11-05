using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare and initialize variables
        string name = "Trimmy Malone";
        int healthPoints = 100;
        float attackPower = 30.5f;
        bool isParalyzed = false;
        double currencyAmount = 150.75;

        // Display initial values
        Console.WriteLine("Initial Values:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health Points (int): {healthPoints}");
        Console.WriteLine($"Attack Power (float): {attackPower}");
        Console.WriteLine($"Paralyzed? (bool): {isParalyzed}");
        Console.WriteLine($"Currency (double): {currencyAmount}\n");

        // Implicit Conversion: int to double
        double healthDouble = healthPoints;
        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine($"Health as Double: {healthDouble}\n");

        // Explicit Conversion (Casting): float to int
        int attackPowerInt = (int)attackPower;
        Console.WriteLine("Explicit Conversion:");
        Console.WriteLine($"Attack Power as Int: {attackPowerInt}\n");

        // Using the Convert Class: double to int
        double experiencePoints = 250.99;
        int experienceInt = Convert.ToInt32(experiencePoints);
        Console.WriteLine("Convert Class:");
        Console.WriteLine($"Experience as Int: {experienceInt}\n");

        // Parsing a string to a double
        string doubleString = "150.3333333";
        double parsedDouble = double.Parse(doubleString);
        Console.WriteLine("Parsing a string to a double:");
        Console.WriteLine($"Gold Coins (parsed from string): {parsedDouble}\n");

        // Safe Conversion using TryParse
        string invalidString = name;
        bool parseSuccess = int.TryParse(invalidString, out int parsedInt);
        Console.WriteLine("Safe Conversion using TryParse:");
        if (parseSuccess)
        {
            Console.WriteLine($"Parsing Succeeded: {parsedInt}");
        }
        else
        {
            Console.WriteLine($"Parsing Failed: '{invalidString}' is not a number.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
