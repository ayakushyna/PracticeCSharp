using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Triangle triangle;

            for(int i = 0; i < 3; i++)
            {
                double a = random.Next(1,10);
                double b = random.Next(1, 10);
                int angleAB = random.Next(1, 180);

                if (angleAB == 90)
                    triangle = new Rectangular(a, b);
                else
                    triangle = new Triangle(a, b, angleAB);

                triangle.Print();
                triangle.Sqr();
                Console.WriteLine("Radius Vp: {0:F2}", triangle.Radius());
                if (angleAB == 90)
                {
                    Rectangular rectangular = (Rectangular)triangle;
                    Console.WriteLine("Radius Op: {0:F2}", rectangular.RadiusOp());
                }
            }
            Console.ReadKey();
        }
    }
}
