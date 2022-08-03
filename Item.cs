using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     class Item
    {
       private string title;
       private string author;
       private char genre;
        private bool isFinished;
        private Item()
        {
           title = Console.ReadLine();
           author = Console.ReadLine();
           genre = Char.Parse(Console.ReadLine());
           isFinished = false;
        }

        private Item(string title, string author, char genre, bool finished)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isFinished = finished;
        }

        private string getTitle()
        {
            return title;
        }

        private void setTitle()
        {
            this.title = Console.ReadLine();
        }

        private string getAuthor()
        {
            return author;
        }

        private void setAuthor()
        {
            this.author = Console.ReadLine();
        }



    }
}
