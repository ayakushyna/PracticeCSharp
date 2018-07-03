using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Man
    {
        public string Name { get; }
        public int BirthYear { get; }

        public Man(string name, int bYear)
        {
            Name = name;
            BirthYear = bYear;
        }

        public void Print()
        {
            Console.WriteLine("Name: {0}, birth year: {1}", Name, BirthYear);
        }

        public int Age(int currYear)
        {
            return currYear - BirthYear;
        }
    }
}
