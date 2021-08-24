using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_6LestReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int stringsIn = 0; stringsIn < n; stringsIn++)
            {
                string str = Console.ReadLine();
                string even = "";
                string odd = "";

                for (int i = 0; i <= str.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        even += str[i];

                    }
                    else
                    {
                        odd += str[i];
                    }
                }

                Console.WriteLine("{0} {1}", even, odd);

            }

            Console.Read();

        }
    }
}
