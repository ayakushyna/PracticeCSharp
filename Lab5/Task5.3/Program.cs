using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarriage carriage;
            Reserved reserved = new Reserved(50, 56, 10);
            Sleeping sleeping = new Sleeping(100, 23, 30);

            carriage = reserved;
            carriage.Cost();
            Console.WriteLine(carriage.Info());

            carriage = sleeping;
            carriage.Cost();
            Console.WriteLine(carriage.Info());

            Sleeping[] sleepings = new Sleeping[2];
            sleepings[0] = new Sleeping(120, 33, 30);
            sleepings[0].Cost();
            sleepings[1] = new Sleeping(80, 20, 30);
            sleepings[1].Cost();

            Array.Sort(sleepings);
            Console.WriteLine(sleepings[0].Info());

            sleepings[0] = (Sleeping)sleepings[1].Clone();
            Console.WriteLine(sleepings[0].Info());

            Console.ReadKey();
        }
    }
}
