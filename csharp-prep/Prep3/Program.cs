using System;

class Program
{
    static void Main(string[] args)
    {
        // intialize variable and get random number
        int guess = 0;
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);

        // have them guess till they get it correct
        while (guess != magic)
        {
            Console.WriteLine("What is your guess?");
            string guessNumb = Console.ReadLine();
            guess = int.Parse(guessNumb);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic)
            {
                Console.WriteLine("Correct");
            }
        }
    }
}
