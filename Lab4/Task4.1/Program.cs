using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = 5;
            Passenger[] passengers = new Passenger[n];
            for (int i = 0; i < n; i++)
            {
                passengers[i] = new Passenger(i.ToString(), random.Next(0, 30));
                Console.WriteLine(passengers[i].ToStr());
            }

            Airplane airplane = new Airplane(random.Next(2, 6), random.Next(0, 150));

            foreach(Passenger passenger in passengers)
            {
                if(!airplane.Place(passenger))
                    Console.WriteLine("{0} didn't get on the plane.", passenger.Name);
            }
            Console.WriteLine(airplane.ToStr());

            Passenger maxPassenger = airplane.Maximal();
            if(maxPassenger!= null)
                Console.WriteLine("{0} has the hardest luggage.", airplane.Maximal().Name);
            else
                Console.WriteLine("There are no passengers.");

            Console.ReadKey();
        }
    }
}
