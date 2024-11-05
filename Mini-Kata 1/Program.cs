using System;

public class PlayerValues
{
    public string name;
    public int health;
    public float attackPower;
    public bool isParalyzed;
    public double currency;

    public void PrintBase()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: {0}", health);
        Console.WriteLine("Attack Power: {0}", attackPower);
        Console.WriteLine("Is Paralyzed: {0}", isParalyzed);
        Console.WriteLine("Currency: {0}", currency);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PlayerValues player = new PlayerValues();
        player.name = "Jim";
        player.health = 100;
        player.attackPower = 7.5f;
        player.isParalyzed = false;
        player.currency = 100.5;

        player.PrintBase();
        Console.WriteLine("Next");
        Console.ReadKey();
        Console.Clear();
    }
}

