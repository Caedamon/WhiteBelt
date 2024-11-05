class Program
{
    private static readonly Random random = new Random();
    static void Main(string[] args)
    {
        int playerLuck = random.Next(1, 11);
        
        Console.WriteLine("Searching through the horde of your enemies you find a mysterious Chest!");
        Console.WriteLine("You marvel at its design, wondering what to do about it.");
        Console.WriteLine("1. Open the chest");
        Console.WriteLine("2. Ignore the chest");
        Console.WriteLine("3. Leave the area");
        Console.Write("> ");
        string choise = Console.ReadLine();

        if (choise == "1")
        {
            Console.WriteLine("You attempt to open the chest!");
            if (playerLuck > 7)
            {
                Console.WriteLine("Amazing! you sure are lucky today!");
                Console.WriteLine("The chest contains rare gems, what a good find!");
            }
            else if (playerLuck >= 5)
            {
                Console.WriteLine("You open the chest, sadly theres just some Gold Coins in it");
            }
            else
            {
                Console.WriteLine("Monsters... underware? what the hell? this is worthless!");
                Console.WriteLine("In your anger at finding such underwhelming offerings, you kick the chest!");
                Console.WriteLine("You broke your toes on the chest... Such bad luck!");
            }
        }
        else if (choise == "2")
        {
            Console.WriteLine("A chest belonging to monsters? Probably only undergarments in it. Not worth the time!");
            Console.WriteLine("You leave the chest along, gotta be better loot in here after all!");
        }
        else if (choise == "3")
        {
            Console.WriteLine("A lousy chest? what is this, dungeon crawling for nobs?");
            Console.WriteLine("You decide to leave the area, its probably a mimic chest! Better git while the goings safe");
        }
        else
        {
            Console.WriteLine($"{choise}??? the hell is that! Try again! 1, 2 or 3 damnit!");
        }
        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
    }
}