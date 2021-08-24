using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_3IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if( N % 2 == 0 && N > 20)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N % 2 == 0 && N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N % 2 == 0 && N >= 2 && N <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else 
            {
                Console.WriteLine("Weird");
            }

            Console.ReadLine();
        }
    }
}
