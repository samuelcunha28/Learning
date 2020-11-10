using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = null;
            int counter = 0;
            int limit = 3;
            bool reachLimit = false;

            while(guess != secretWord && !reachLimit)
            {
                if (counter < limit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    counter++;
                } else
                {
                    reachLimit = true;
                }
            }

            if (reachLimit)
            {
                Console.WriteLine("You lose! The secret word was: " + secretWord);
            } else
            {
                Console.WriteLine("You win!");
            }   
        }
    }
}
