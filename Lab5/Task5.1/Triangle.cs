using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Triangle
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }
        public double AngleAB { get; protected set; }
        public double SemiP { get; protected set; }
        public double Square { get; protected set; }

        public Triangle() { }
        public Triangle(double a, double b, int angleAB)
        {
            A = a;
            B = b;
            AngleAB = angleAB * Math.PI / 180;
            C = Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(AngleAB));
            SemiP = (A + B + C) / 2;
        }

        virtual public void Sqr()
        {
            Square = Math.Sqrt(SemiP * (SemiP - A) * (SemiP - B) * (SemiP - C));
            Console.WriteLine("Calculate common triangle square...\nSquare: {0:F2}", Square);
        }

        public double Radius()
        {
            return Square / SemiP;
        }

        public void Print()
        {
            Console.WriteLine("A: {0:F2}, B: {1:F2}, C: {2:F2}, AngleAB in rad: {3:F2}", A, B, C, AngleAB);
        }
    }
}
