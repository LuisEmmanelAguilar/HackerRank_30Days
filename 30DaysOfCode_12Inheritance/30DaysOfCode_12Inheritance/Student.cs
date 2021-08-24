using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_12Inheritance
{
    class Student : Person 
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.testScores = scores;
        }

        public string Calculate()
        {
            var average = testScores.Average();
            var res = IsWithin(average, 90, 100) ? "O" :
                      IsWithin(average, 80, 89) ? "E" :
                      IsWithin(average, 70, 79) ? "A" :
                      IsWithin(average, 55, 69) ? "P" :
                      IsWithin(average, 40, 54) ? "D" :
                      "T";
            return res;
        }


        private bool IsWithin(double value, int minimum, int maximum)
        {
            return value >= minimum && value <= maximum;
        }

    }
}
