using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Passenger
    {
        public string Name { get; private set; }
        public int Luggage { get; private set; }

        public Passenger(string name, int luggage)
        {
            Name = name;
            Luggage = luggage;
        }

        public string ToStr()
        {
            string result = String.Format("Passanger's name: {0}, weight of the luggage: {1}", Name, Luggage);
            return result;
        }
    }
}
