using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class Derived: BeautyQueen
    {
        public int Intelligence { get; }

        public Derived(int beauty, int height, int intelligence): base(beauty, height)
        {
            Intelligence = intelligence;
        }

        public double Qi()
        {
            return Q() + 0.01 * Intelligence;
        }
        
    }
}
