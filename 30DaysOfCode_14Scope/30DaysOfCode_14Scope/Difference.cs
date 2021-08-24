using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Submitted 23/08/2021
namespace _30DaysOfCode_14Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public int computeDifference()
        {
            int maxItem = elements[0];
            int minItem = elements[0];

            for(int i=0; i < elements.Length; i++)
            {
                if(elements[i] < minItem)
                {
                    minItem = elements[i];
                }
                
                if(elements[i] > maxItem)
                {
                    maxItem = elements[i];
                }
            }

            maximumDifference = Math.Abs(maxItem - minItem);
            return maximumDifference;
        }
    }
}
