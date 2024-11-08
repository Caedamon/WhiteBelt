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
        {
            Hero.name = "Jim, The Hero";
            Hero.healthPoints = 80;
            Hero.attackPower = 15f;
            Hero.dodgeChance = 10;
        }
        
        CharValues Goblin = new CharValues();
        {
            Goblin.name = "Goblin";
            Goblin.healthPoints = 50;
            Goblin.attackPower = 10f;
            Goblin.dodgeChance = 30;
        }
        
        Hero.PrintStats();
        Console.WriteLine();
        Goblin.PrintStats();

        Console.WriteLine("You are being attacked by a Goblin! Defeat it!");
        Console.ReadKey();

        while (Hero.healthPoints > 0 && Goblin.healthPoints > 0)
        {
            Console.Clear();
            
            Console.WriteLine($"\nHero's Health: {Hero.healthPoints} \nGoblin's Health: {Goblin.healthPoints}");
            
            Console.WriteLine("\nChose an action!");
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
                continue; 
                //should i have this? i mean if you "fugg upp" during combat, you will give the enemy a free turn...
                //is it cheating? xD
            }

            if (Goblin.healthPoints <= 0)
            {
                Console.WriteLine("\nAfter a brutal and gruesome battle.");
                Console.WriteLine("You stand Victorious over the vanquished Goblin!");
                Console.WriteLine("Loot and Gloory await you back in town!");
                break;
            }

            Console.WriteLine("The Goblin, fearing for its life! Attacks!");

            if (Hero.TryDodge(random))
            {
                Console.WriteLine("You managed to dodge the attack!");
            }
            else
            {
                Hero.healthPoints -= (int)Goblin.attackPower;
                Console.WriteLine($"The goblin smashes in to you and deals {Goblin.attackPower} damage!");
            }

            if (Hero.healthPoints <= 0)
            {
                Console.WriteLine("The Goblins power is to much for you!");
                Console.WriteLine("Weather due to Luck or skill on its part, you succumb to its wounds");
                Console.WriteLine("*** The Hero Has Ended Up As A Snack For The Goblin***");
                break;
            }
            Console.WriteLine("\nPress Enter to continue to the next turn...");
            Console.ReadLine();
        }
        Console.WriteLine("Game over, it was fun! (Press any key to quit)");
        Console.ReadKey();
    }
}

