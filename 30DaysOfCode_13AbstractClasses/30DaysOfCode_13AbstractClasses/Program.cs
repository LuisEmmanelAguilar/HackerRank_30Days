using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_13AbstractClasses
{
	class Program
	{
		static void Main(String[] args)
		{
			String title = Console.ReadLine();
			String author = Console.ReadLine();
			int price = Int32.Parse(Console.ReadLine());
			Book new_novel = new MyBook(title, author, price);
			new_novel.display();
		}
	}
}