using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._1
{
    class Airplane
    {
        private Passenger[] passengers;
        public int Weight { get; private set; }

        public Airplane( int n, int weight)
        {
            passengers = new Passenger[n];
            Weight = weight;
        }

        public bool Place(Passenger passenger)
        {
            int currWeight = 0;
            bool t = false;

            for (int i = 0; i < passengers.Length; i++)
            {
                if (passengers[i] != null) currWeight += passengers[i].Luggage;
                if (passengers[i] == null && (currWeight + passenger.Luggage <= Weight))
                {
                    passengers[i] = passenger;
                    t = true;
                    break;
                }
            }
            return t;
        }

        public Passenger Maximal()
        {
            Passenger maxPassenger = null;
            foreach(Passenger passenger in passengers)
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
