using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Parallelepiped:Body
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Square()
        {
            return 2*(A * B + B * C + A * C);
        }

        public override double Volume()
        {
            return A * B * C;
        }

        public override string ToStr()
        {
            string result = String.Format("Parallelepiped - A: {0:F2}, B: {1:F2}, C: {2:F2}", A, B, C);
            return result;
        }
    }
}
