using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_2Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Result.solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
