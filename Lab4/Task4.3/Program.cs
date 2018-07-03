using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            for(int i = 0; i < 3; i++)
            {
                int beauty = random.Next(1, 5);
                int height = random.Next(150, 200);
                int intelligence = random.Next(1, 5);

                Derived derived = new Derived(beauty, height, intelligence);
                Console.WriteLine("Beauty: {0}, height: {1}, intelligence: {2}", derived.Beauty, derived.Height, derived.Intelligence);
                Console.WriteLine("First grade: {0}", derived.Q());
                Console.WriteLine("Second grade: {0}", derived.Qi());
            }
            Console.ReadKey();

        }
    }
}
