using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }

            Console.ReadLine();
        }
    }
}
