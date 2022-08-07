using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
      class Item
    {
       public string title;
        public  string author;
        public char genre;
        public bool isFinished;
        public Item()
        {
           title ="";
           author = "";
         
           isFinished = false;
        }

        public Item(string title, string author, char genre, bool finished)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isFinished = finished;
        }

        protected string getTitle()
        {
            return title;
        }

        protected void setTitle()
        {
            this.title = Console.ReadLine();
        }

        protected string getAuthor()
        {
            return author;
        }

        protected void setAuthor()
        {
            this.author = Console.ReadLine();
        }

        public override string ToString()
        {
            return "Title: " + title + " By: " + author;
        }

    }
}
