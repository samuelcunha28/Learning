﻿using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 35;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge +" years old");
            // characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}
