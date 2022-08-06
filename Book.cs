using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{
    internal class Book : Item

    {
        protected int pages;
        protected Book () : base ()
        {

        }

        protected Book (string title, string author, char genre, bool finished, int pageCount)
            : base (title, author, genre, finished)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isFinished = finished;
            pages = pageCount;

        }
    } 
}
