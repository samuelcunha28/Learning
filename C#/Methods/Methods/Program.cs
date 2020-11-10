using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Samuel", 22);

            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
           
            Console.ReadLine();
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }

        static int cube(int num)
        {
            int result = num * num * num;

            return result;
        }
    }
}
