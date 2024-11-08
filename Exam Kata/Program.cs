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

public class CharValues
{
    public string name;
    public int healthPoints;
    public float attackPower;
    public int dodgeChance;
    
    public void PrintStats()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: {0}", healthPoints);
        Console.WriteLine("Attack Power: {0}", attackPower);
        Console.WriteLine("Dodge Chance: {0}", dodgeChance);
    }

    public bool TryDodge(Random random)
    {
        return random.Next(1,101) <= dodgeChance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        
        CharValues Hero = new CharValues();
        Hero.name = "Jim";
        Hero.healthPoints = 80;
        Hero.attackPower = 15f;
        Hero.dodgeChance = 10;
        
        CharValues Goblin = new CharValues();
        Goblin.name = "Goblin";
        Goblin.healthPoints = 50;
        Goblin.attackPower = 10f;
        Goblin.dodgeChance = 30;

        Hero.PrintStats();
        Goblin.PrintStats();
        Console.WriteLine("Next");
        Console.ReadKey();
        Console.Clear();
        
        Console.WriteLine("You are beeing attacked by a Goblin! Defeat it!");

        while (Hero.healthPoints > 0 && Goblin.healthPoints > 0)
        {
            Console.WriteLine("\nCurrent Stats:");
            Hero.PrintStats();
            Goblin.PrintStats();
            
            Console.WriteLine("Chose an action!");
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Heal");
            Console.Write("> ");
            string choise = Console.ReadLine();

            if (choise == "1")
            {
                Console.WriteLine("You Attack!");
                if (Goblin.TryDodge(random))
                {
                    Console.WriteLine("The Goblin Dodges your pathetic attempt at an attack!");
                }
                else
                {
                    Goblin.healthPoints -= (int)Hero.attackPower;
                    Console.WriteLine($"Goblin takes {Hero.attackPower} damage!");
                }
            }
            else if (choise == "2")
            {
                int healAmount = 10;
                Hero.healthPoints += healAmount;
                Console.WriteLine($"You Heal yourself for {healAmount} health!!");
            }
            else
            {
                Console.WriteLine($"{choise}??? the hell is that! Try again! 1, or 2 damnit!");
            }
            
            Console.WriteLine("");
            if (Hero.TryDodge(random))
            Console.WriteLine("Press any key to quit...");
            Console.ReadKey();
        }
    }
}

