using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Cone: Body
    {
        public double R { get; }
        public double H { get; }

        public Cone(double r, double h)
        {
            R = r;
            H = h;
        }

        public override double Square()
        {
            return Math.PI * R * (R + Math.Sqrt(R * R + H * H));
        }

        public override double Volume()
        {
            return Math.PI * R * R * H / 3;
        }

        public override string ToStr()
        {
            string result = String.Format("Cone - Radius: {0:F2}, Height: {1:F2}", R, H);
            return result;
        }
    }
}
