using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int j = 0;
            double f = 0;
            string q = "";
            // Read and save an integer, double, and String to your variables.
            j = Convert.ToInt32(Console.ReadLine().Trim());
            f = Convert.ToDouble(Console.ReadLine().Trim());
            q = Console.ReadLine();
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + j);
            Console.WriteLine(Convert.ToDecimal(string.Format("{0:0.0}", (d + f))));
            Console.WriteLine(s + q);
            Console.ReadLine();
            // Print the sum of the double variables on a new line.

        }
    }
}
