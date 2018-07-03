using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class BeautyQueen
    {
        public int Beauty { get; }
        public int Height { get; }

        public BeautyQueen(int beauty, int height)
        {
            Beauty = beauty;
            Height = height;
        }

        public double Q()
        {
            return Beauty + 0.5 * Height;
        }
        
    }
}
