class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Spawning Enemies using a For Loop:");
        int totalEnemiesForLoop = 5;

        for (int i = 1; i <= totalEnemiesForLoop; i++)
        {
            Console.WriteLine($"Enemy #{i} Spawned!");
        }
        
        Console.WriteLine("Spawning Enemies using a While Loop:");
        int enemiesSpawned = 0;
        int maxEnemiesWhileLoop = 3;

        while (enemiesSpawned < maxEnemiesWhileLoop)
        {
            enemiesSpawned++;
            Console.WriteLine($"Enemy #{enemiesSpawned} Spawned!");
        }
        Console.WriteLine("\nPress any key to Quit...");
        Console.ReadKey();
    }
}