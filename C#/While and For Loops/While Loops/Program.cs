﻿using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int index = 1;

            while(index <= 5) 
            {
                Console.WriteLine(index);
                index++;
            }

            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index2 <= 5);
            */
            int[] numbers = { 1, 5, 6, 13, 56 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
