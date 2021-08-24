using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int[] a = arr.ToArray();
            Array.Reverse(a);

            List<int> backwards = new List<int>();

            foreach (int num in a)
            {
                backwards.Add(num);
            }

            Console.WriteLine("{0}", string.Join(" ", backwards.ToArray()));

            Console.ReadLine();

        }
    }
}
