using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_8DiccionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] namePhone = Console.ReadLine().Split(' ');
                phoneBook[namePhone[0]] = namePhone[1];
            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(name))
                    Console.WriteLine(name + "=" + phoneBook[name]);
                else
                    Console.WriteLine("Not found");
            }

        }
    }
}
