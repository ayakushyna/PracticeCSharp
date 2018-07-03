using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._2
{
    class Airplane
    {
        private List<Passenger> passengers;
        public int Weight { get; private set; }

        public Airplane(int weight)
        {
            Weight = weight;
            passengers = new List<Passenger>();
        }

        public bool Place(Passenger passenger)
        {
            int currWeight = 0;
            for (int i = 0; i < passengers.Count; i++)
            {
                if (passengers[i] != null) currWeight += passengers[i].Luggage;
            }

            if (currWeight + passenger.Luggage <= Weight)
            {
                passengers.Add(passenger);
                return true;
            }
            return false;
        }

        public Passenger Maximal()
        {
            Passenger maxPassenger = null;
            foreach (Passenger passenger in passengers)
            {
                if (passenger != null)
                    if (maxPassenger == null || passenger.Luggage > maxPassenger.Luggage)
                        maxPassenger = passenger;
            }
            return maxPassenger;
        }

        public string ToStr()
        {
            string result = String.Format("Max weight: {0}", Weight);
            foreach (Passenger passenger in passengers)
            {
                if (passenger != null)
                    result += "\n" + passenger.ToStr();
            }
            return result;
        }
    }
}
