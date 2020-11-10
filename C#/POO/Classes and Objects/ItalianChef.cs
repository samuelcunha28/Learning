using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects
{
    class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes a special dish with italian vegetables");
        }
        public void MakePasta()
        {
            Console.WriteLine("The italian chef makes pasta");
        }
    }
}
