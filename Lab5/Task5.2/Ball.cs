using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Ball: Body
    {
        public double R { get; }

        public Ball(double r)
        {
            R = r;
        }

        public override double Square()
        {
            return 4 * Math.PI * R * R;
        }

        public override double Volume()
        {
            return 4.0/ 3 * Math.PI * R * R * R;
        }

        public override string ToStr()
        {
            string result = String.Format("Ball - Radius: {0:F2}", R);
            return result;
        }
    }
}
