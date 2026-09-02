using System;

class Program
{
    static void Main(string[] args)
    {
        /* 
            What is the magic number?
            What is your guess?
            
            Options:

            Higher
            Lower
            You guessed it!
        */
        // Console.Write("What is your magic number? ");
        // string magicNum = Console.ReadLine();

        // Replaced User Magic Number Entry with generated numbers between 1 and 100.
        int magicNumber = Random.Shared.Next(1, 101);

        Console.Write("What is your guess? ");
        string guessNum = Console.ReadLine();
        int guess = int.Parse(guessNum);

        while (guess != magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            guessNum = Console.ReadLine();
            guess = int.Parse(guessNum);
        }
        Console.WriteLine("You guessed it!");
    }
}