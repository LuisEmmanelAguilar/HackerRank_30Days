using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_112DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            List<int> sums = new List<int>();

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    try
                    {
                        temp += arr[i][j];
                        temp += arr[i][j + 1];
                        temp += arr[i][j + 2];
                        temp += arr[i + 1][j + 1];
                        temp += arr[i + 2][j];
                        temp += arr[i + 2][j + 1];
                        temp += arr[i + 2][j + 2];

                        sums.Add(temp);
                        temp = 0;

                    }
                    catch (Exception)
                    {
                        temp = 0;
                    }
                }

            }
            sums.Sort();
            Console.WriteLine(sums[sums.Count - 1]);

        }
    }
}
