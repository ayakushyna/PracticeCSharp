using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int n = 5;
            List<Passenger> passengers = new List<Passenger>();
            for (int i = 0; i < n; i++)
            {
                passengers.Add(new Passenger(i.ToString(), random.Next(0, 30)));
                Console.WriteLine(passengers[i].ToStr());
            }

            Airplane airplane = new Airplane(random.Next(0, 150));

            foreach (Passenger passenger in passengers)
            {
                if (!airplane.Place(passenger))
                    Console.WriteLine("{0} didn't get on the plane.", passenger.Name);
            }
            Console.WriteLine(airplane.ToStr());

            Passenger maxPassenger = airplane.Maximal();
            if (maxPassenger != null)
                Console.WriteLine("{0} has the hardest luggage.", airplane.Maximal().Name);
            else
                Console.WriteLine("There are no passengers.");

            Console.ReadKey();
        }
    }
}
