﻿using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            luckyNumbers[1] = 7;

            string[] friends = new string[5];
            friends[0] = "Jim";
            friends[1] = "Kelly";
            Console.WriteLine(luckyNumbers[1]);
            
        }
    }
}
