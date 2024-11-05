using System;

class Program
{
    static void Main(string[] args)
    {
        string name; "Trimmy Malone";
        int healthPoints = 100;
        float attackPower = 30.5f;
        bool isParalyzed = false;
        double currencyAmount = 150.75;

        Console.WriteLine("Initial Values");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health Points (int): {healthPoints}");
        Console.WriteLine($"Attack Power (float): {attackPower}");
        Console.WriteLine($"Paralyzed? (bool): {isParalyzed}");
        Console.WriteLine($"Currency (double): {currencyAmount}");

        double healthDouble = healthPoints;
        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine($"Health as Double: {healthDouble}");

        int attackPowerInt = (int)attackPower;
        Console.WriteLine("Implicit Conversion:");
        Console.WriteLine($"Attack Power as Int: {attackPowerInt}");
        
        
    }
}
