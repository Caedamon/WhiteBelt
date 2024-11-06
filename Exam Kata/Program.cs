// Requirements:
//
// Initialize the player's and enemy's stats (health, attack power, etc.).
// In a loop:
// Display each character's current health.
//     Ask the player to choose an action (attack or heal).
//     If the player chooses to attack, reduce the enemy’s health.
//     If the player chooses to heal, increase the player’s health.
//     Display messages reflecting each choice.
//     Automatically have the enemy attack the player after the player’s turn.
//     Check if either character’s health is 0 or below after each action and end the game if so.
//     Display a win or loss message depending on the outcome.

public class charValues
{
    public string name;
    public int healthPoints;
    public float attackPower;
    public bool isParalyzed;
    public double currency;

    public void PrintBase()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: {0}", healthPoints);
        Console.WriteLine("Attack Power: {0}", attackPower);
    }
}

class Program
{
    static void Main(string[] args)
    {
        charValues Hero = new charValues();
        Hero.name = "Jim";
        Hero.healthPoints = 80;
        Hero.attackPower = 7.5f;
        
        charValues Goblin = new charValues();
        Goblin.name = "Goblin King";
        Goblin.healthPoints = 50;
        Goblin.attackPower = 5f;

        Hero.PrintBase();
        Goblin.PrintBase();
        Console.WriteLine("Next");
        Console.ReadKey();
        Console.Clear();
        
        Console.WriteLine("You are beeing attacked by the Goblin King! Defeat him!");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Heal");
        Console.Write("> ");
        string choise = Console.ReadLine();

        if (choise == "1")
        {
            Console.WriteLine("You Attack!");
        }
        else if (choise == "2")
        {
            Console.WriteLine("You Heal yourself!!");
        }
        else
        {
            Console.WriteLine($"{choise}??? the hell is that! Try again! 1, 2 or 3 damnit!");
        }
        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
    }
}

