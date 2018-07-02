using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 6;
            Console.WriteLine("Всего детей: {0}", n);

            Child[] children = new Child[n];
            for(int i = 0; i < n; i++)
            {
                children[i] = new Child(i+1);
            }

            int m = 4;
            Console.WriteLine("Всего мест: {0}", m);
            PlaySchool playSchool = new PlaySchool(m);
            Manageress manageress = new Manageress();
            Department department = new Department();

            playSchool.NotPlaces += manageress.Queue;
            manageress.Registration += department.Place;

            foreach(Child child in children)
            {
                playSchool.PushChild(child);
            }

            Console.ReadKey();
        }
    }
}
