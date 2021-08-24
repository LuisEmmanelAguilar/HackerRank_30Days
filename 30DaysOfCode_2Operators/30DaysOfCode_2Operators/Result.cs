using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_2Operators
{
    class Result
    {

        /*
         * Complete the 'solve' function below.
         *
         * The function accepts following parameters:
         *  1. DOUBLE meal_cost
         *  2. INTEGER tip_percent
         *  3. INTEGER tax_percent
         */

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            int total = 0;
            double tip = meal_cost / 100 * (tip_percent);
            double tax = meal_cost / 100 * (tax_percent);
            total = Convert.ToInt32((Math.Round(meal_cost + tip + tax)));

            Console.WriteLine(total);

        }

    }
}
