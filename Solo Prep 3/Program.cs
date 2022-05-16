// See https://aka.ms/new-console-template for more information
Random randomGenerator = new Random();
int number = randomGenerator.Next(1,100);
int input = 0;

while (input != number)
{
    Console.Write("Guess the number between 1 and 100: ");
    input = int.Parse(Console.ReadLine());
    if (input < number)
    {
        Console.WriteLine("Higher");
    }
    else if (input > number)
    {
        Console.WriteLine("Lower");
    }
    else
    {
        Console.WriteLine("You guessed it!");
    }
}
