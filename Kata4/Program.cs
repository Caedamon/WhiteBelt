class Program
{
    static void Main(string[] args)
    {
        int totalWaves = 3;
        int enemiesPerWave = 4;

        for (int wave = 1; wave <= totalWaves; wave++)
        {
            Console.WriteLine($"\nWave {wave} is starting!");

            for (int enemy = 1; enemy <= enemiesPerWave; enemy++)
            {
                Console.WriteLine($"  Enemy #{enemy} has spawned.");
            }

            Console.WriteLine($"Wave {wave} completed. Preparing for the next wave...");

            Thread.Sleep(1000);
        }
        
        Console.WriteLine("\nAll waves completed! Victory is yours!");
    }
}