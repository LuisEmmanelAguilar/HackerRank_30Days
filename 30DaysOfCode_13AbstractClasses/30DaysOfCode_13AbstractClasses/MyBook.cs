using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Submitted August 23, 2021
namespace _30DaysOfCode_13AbstractClasses
{
    class MyBook : Book
    {
        private int price = 0;
        
        public MyBook(String title, String author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.Write("Title: {0} \nAuthor: {1} \nPrice: {2}", title, author, price);
            Console.ReadLine();
        }
    }
}
