using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_13AbstractClasses
{
    abstract class Book
    {
        protected String title { get; set; }
        protected String author { get; set; }
 
        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
        }

        public abstract void display();

    }
}
