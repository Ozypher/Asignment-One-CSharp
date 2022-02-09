using System;

namespace CorrectNumberGame
{
    class CorrectNumberGame
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            int guessed = 0;
            while (guessed != correctNumber)
            {
                guessed = Guess();
                if (guessed > correctNumber && guessed < 4)
                {
                    Console.WriteLine("Lower.");
                }
                else if (guessed < correctNumber && guessed > 0)
                {
                    Console.WriteLine("Higher.");
                }
                else if (guessed == correctNumber)
                {
                    Console.WriteLine("Correct Number!");
                }
                else
                {
                    Console.WriteLine("Out of the range, please stay between 1 and 3");
                }
            }
        }
        static int Guess()
        {
            Console.WriteLine("Guess a number 1 to 3.");
            int guessed = int.Parse(Console.ReadLine());
            return guessed;
        }
    }
}
