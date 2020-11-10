using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * EXAMPLE OF CONDITIONS
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
            */

            // Console.WriteLine(GetMax(20, 10));
            // Console.WriteLine(GetMax(2, 10, 30));

        }
        static int GetMax(int num1, int num2)
        {
            int result = 0;

            if (num1 > num2)
            {
                Console.WriteLine("Number " + num1 + " is the biggest number");
                result = num1; 
            } else
            {
                Console.WriteLine("Number " + num2 + " is the biggest number");
                result = num2;
            }

            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result = 0;

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("Number " + num1 + " is the biggest number");
                result = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("Number " + num2 + " is the biggest number");
                result = num2;
            } else
            {
                Console.WriteLine("Number " + num3 + " is the biggest number");
                result = num3;
            }

            return result;
        }
    }
}