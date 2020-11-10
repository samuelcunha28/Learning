using System;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling", 679);
            book1.Title = "Order of the Fenix";
            Console.WriteLine(book1.Title);

            Chef chef = new Chef();
            chef.MakeChicken();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();

        }
    }
}
