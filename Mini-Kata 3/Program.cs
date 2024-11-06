class Program
{
    private static readonly Random random = new Random();
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Adventurer! Whats your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Well met Sir {name}!");
        Console.WriteLine("Today, we are on the border of a brightly lit magical Kingdom!");
        
        int playerLuck = random.Next(1, 11);
        Console.WriteLine("Le gasp! A Chupacabra Attacks! Defend yourself? (yes/no");
        string choise = Console.ReadLine().ToLower();

        if (choise == "yes")
        {
            Console.WriteLine("Drawing on your Guts! You Lash out with your fist to strike at the Chupacabra!");
            if (playerLuck > 7)
            {
                Console.WriteLine("You hit it on the snout! GREAT SUCCESS!");
                Console.WriteLine("Fearing your mighty fist the Chupacabra ran away!");
            }
            else if (playerLuck == 6 || playerLuck ==7)
            {
                Console.WriteLine("Seriously? you call that a hit? you barely managed to touch it!");
                Console.WriteLine("Sensing how pathetic weak your hit was, the chupacabra moved on to mightier foes!");
            }
            else
            {
                Console.WriteLine("OH NOES! YOU MISSED! HOW COULD YOU MISS!!!");
                Console.WriteLine("You got scared and ran away!");
            }
        }
        else if (choise == "no")
        {
            Console.WriteLine($"Brave brave sir {name}, sir {name} ran away!");
        }
        else
        {
            Console.WriteLine($"What do you mean {choise}? Thats not right! TRY AGAIN! Yes, or No!");
        }
        
        Console.WriteLine("\nPress any key to quit...");
        Console.ReadKey();
    }
}