using System;

namespace solo3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            do
            {
                Console.WriteLine("\nI am going to select a number between 1 and 100.");
            
                Random randomGenerator = new Random();
                int correctNum = randomGenerator.Next(1,100);
            
                int guess = 0;
                int guessNum = 0;
            
                do
                {
                    Console.WriteLine("\nWhat is your guess?");
                    guessNum += 1;
                    guess = int.Parse(Console.ReadLine());
                    if (guess < correctNum)
                    {
                        Console.WriteLine("The number is higher than that.");
                    }
                    else if (guess > correctNum)
                    {
                        Console.WriteLine("The number is lower than that.");
                    }            
                } while (guess != correctNum);

                Console.WriteLine($"\nThat is correct! You made {guessNum} guesses!\n\nWould you like to play again? (y/n) ");
                char playAnswer = char.Parse(Console.ReadLine().ToLower());
            
                if (playAnswer == 'y')
                {
                    playAgain = true;
                }
                else if (playAnswer == 'n')
                {
                    Console.WriteLine("Thanks for playing!");
                    playAgain = false;
                }
            } while (playAgain);
        }
    }
}
