using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Body body;
            for(int i = 0; i < 3;i++)
            {
                double x = random.Next(1, 5);
                double y = random.Next(0, 5);
                double z = random.Next(0, 2);

                if (y == 0 && z == 0)
                    body = new Ball(x);
                else if (y == 0)
                    body = new Cone(x, z);
                else if (z == 0)
                    body = new Cone(x, y);
                else
                    body = new Parallelepiped(x, y, z);

                Console.WriteLine("\n" + body.ToStr());
                Console.WriteLine("Square: {0:F2}, Volume: {1:F2}", body.Square(), body.Volume());
            }
            Console.ReadKey();
        }
    }
}
