class Program
{
    static void Main(string[] args)
    {
        string name = "Lira";
        int level = 5;
        float healthPoints = 75.5f;
        double experiencePoints = 1025.75;
        bool magicAbility = true;
        char rank = 'A';

        double nextLevelThreshold = 1200.0;
        double pointsToNextLevel = nextLevelThreshold - experiencePoints;

        Console.WriteLine("Character Attributes:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Level: {level}");
        Console.WriteLine($"Health Points: {healthPoints}");
        Console.WriteLine($"Experience Points: {experiencePoints}");
        Console.WriteLine($"Has Magic Ability: {magicAbility}");
        Console.WriteLine($"Rank: {rank}");
        Console.WriteLine($"Points needed to Level Up: {pointsToNextLevel}");
        
        Console.WriteLine("Press any key to end...");
        Console.ReadKey();
    }
}