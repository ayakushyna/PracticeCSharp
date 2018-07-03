using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Rectangular:Triangle
    {
        public Rectangular() { }
        public Rectangular(double a, double b)
        {
            A = a;
            B = b;
            AngleAB = Math.PI / 2;
            C = Math.Sqrt(A * A + B * B);
            SemiP = (A + B + C) / 2;
        }

        override public void Sqr()
        {
            Square = A * B / 2;
            Console.WriteLine("Calculate rectangular triangle square...\nSquare: {0:F2}", Square);
        }

        public double RadiusOp()
        {
            return (A * B * C) / (4 * Square);
        }
    }
}
