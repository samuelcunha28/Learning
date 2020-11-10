using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Classes_and_Objects
{
    class Book
    {
        private string title;
        private string author;
        private int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            this.title = aTitle;
            this.author = aAuthor;
            this.pages = aPages;
        }

        public string Title
        {
            get {return title;}
            set
            {
                title = value;
            }
        }

        public bool moreThan500Pages()
        {
            if (this.pages > 500)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void ReadBook()
        {
            Console.WriteLine("Nice");
        }
    }
}
