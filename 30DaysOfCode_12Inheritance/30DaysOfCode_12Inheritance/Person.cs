using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode_12Inheritance
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nId: " + id);   
        }
    }
}
