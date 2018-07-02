using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class PlaySchool
    {
        public int NumberOfPlaces { get; private set; }

        public delegate void NotPlacesEventHandler();
        public event NotPlacesEventHandler NotPlaces;

        public PlaySchool(int numberOfPlaces)
        {
            NumberOfPlaces = numberOfPlaces;
        }

        public void PushChild(Child child)
        {
            if(NumberOfPlaces > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ребенок {0} зачислен.", child.ChildId);
                NumberOfPlaces--;
                return;
            }
            NotPlaces();
        }
    }
}
