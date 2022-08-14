using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    internal class Book : Item

    {
        public int pages;
        public Book () : base ()
        {

        }

        public Book (string title, string author, char genre, bool finished, int pageCount)
            : base (title, author, genre, finished)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isFinished = finished;
            pages = pageCount;

        }

        public override string ToString()
        {
            return base.ToString() + "Format: Book";
        }
    } 
}
