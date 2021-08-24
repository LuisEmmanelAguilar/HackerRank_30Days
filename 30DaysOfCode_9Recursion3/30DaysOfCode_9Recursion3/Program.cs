using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_9Recursion3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = Result.factorial(n);

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
