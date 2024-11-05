Console.WriteLine("Welcome, brave adventurer! What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Greetings, {name}! Your journey begins now...");

int level;
bool isValidInput = false;

while (!isValidInput)
{
    Console.WriteLine("So... What's your level of excitement for this? Give me a number from 1-10!");
    string excitement = Console.ReadLine();

    if (int.TryParse(excitement, out level))
    {
        if (level >= 1 && level <= 10)
        {
            isValidInput = true;
            if (level <= 3)
            {
                Console.WriteLine($"{level} huh... well, that's not very excited ::sad::");
            }
            else if (level <= 7)
            {
                Console.WriteLine($"{level} oh my, that's pretty good!");
            }
            else
            {
                Console.WriteLine($"{level} WOW! That's SUPER excited!");
            }
        }
        else
        {
            Console.WriteLine("That's not within the range of 1 to 10. Please, try again.");
        }
    }
    else
    {
        Console.WriteLine("That does not seem to be a number. Try again, 1 to 10 please.");
    }
}

