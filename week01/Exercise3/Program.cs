using System;

class Program
{
    static void Main(string[] args)
    {   string tryAgain;
        do
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);
            
            int guess = -1;
            int guessCount = 0;

            while (guess != magicNum)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess > magicNum)
                {
                    Console.WriteLine("Lower");           
                }
                else if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess == magicNum)
                {
                    Console.WriteLine("You Guessed It!");
                }

            }
            Console.Write("Do you want to try again?(yes/no): ");
            tryAgain = Console.ReadLine().ToLower();
        } while (tryAgain == "yes");
        Console.WriteLine("Thank you for playing!");
    }
}