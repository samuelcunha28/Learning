using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) 
            {
                Console.WriteLine("You are not male but you are tall");
            } else
            {
                Console.WriteLine("You are not male and not tall");
            }
        }
    }
}
