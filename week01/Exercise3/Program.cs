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
        int magicNumber;

        // Console.Write("What is your guess? ");
        // string guessNum = Console.ReadLine();
        // int guess = int.Parse(guessNum);
        
        int counter;
        bool playAgain;

        do
        {
            magicNumber = Random.Shared.Next(1, 101);
            counter = 0;

            Console.Write("What is your guess? ");
            string guessNum = Console.ReadLine();
            int guess = int.Parse(guessNum);
            while (guess != magicNumber)
            {
                counter++;
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
            counter++;
            Console.WriteLine($"You guessed it! The magic number is {magicNumber}.");
            // Report on the number of tries it took to guess the magic number.
            Console.WriteLine($"It took you {counter} tries to guess the magic number.");
            playAgain = false;

            Console.Write("Would you like to play again? (yes/no) ");
            string playAgainInput = Console.ReadLine();
            if (playAgainInput.ToLower() == "yes")
            {   
                playAgain = true;
            }
            else
            {
                Console.WriteLine("Thanks for playing! Goodbye.");
            }
        } while (playAgain);
    }
}