using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_9Recursion3
{
    class Result
    {
        public static int factorial(int n)
        {
            if (n == 0)
                return 1;

            int f = 1;
            for (int i = n; i >= 1; i--)
            {
                f = f * i;
            }

            return f;


        }

    }
}
