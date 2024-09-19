using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int magicNumber = rand.Next(1, 101);
            int guesses = 0;
            bool playAgain = true;

            while (playAgain)
            {
                guesses = 0;
                magicNumber = rand.Next(1, 101);

                while (true)
                {
                    Console.Write("What is your guess? ");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    guesses++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guesses} guesses.");
                        break;
                    }
                }

                Console.Write("Do you want to play again? (yes/no) ");
                playAgain = Console.ReadLine().ToLower() == "yes";
            }
        }
    }
}
