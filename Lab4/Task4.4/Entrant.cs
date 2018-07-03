using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Entrant: Man
    {
        public int Sum { get; }
        public bool Enter { get; private set; }

        public Entrant(string name, int bYear, int sum) : base(name, bYear)
        {
            Sum = sum;
        }

        public void Entered(int passScore)
        {
            Enter = (Sum >= passScore);
        }

        public void PrintE()
        {
            Console.WriteLine("Sum: {0}, entered: {1}", Sum, Enter);
        }
    }
}
