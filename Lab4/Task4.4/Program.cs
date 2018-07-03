using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Man man = new Man("0", 1998);
            man.Print();
            Console.WriteLine("Age: {0}", man.Age(2018));

            int passScore = random.Next(0, 200);
            Console.WriteLine("\nPassing score: {0}", passScore);
            Entrant entrant1 = new Entrant("1",random.Next(1990,2001), random.Next(0, 200));
            Entrant entrant2 = new Entrant("2", random.Next(1990, 2001), random.Next(0, 200));

            entrant1.Print();
            Console.WriteLine("Age: {0}", entrant1.Age(2018));
            entrant1.Entered(passScore);
            entrant1.PrintE();

            entrant2.Print();
            Console.WriteLine("Age: {0}", entrant2.Age(2018));
            entrant2.Entered(passScore);
            entrant2.PrintE();

            int minScore = random.Next(0, 100);
            Console.WriteLine("\nMinimal score: {0}", minScore);
            Student student1 = new Student("3", random.Next(1990, 2001), "MEO", 3, random.Next(0, 100));
            Student student2 = new Student("4", random.Next(1990, 2001), "CE", 1, random.Next(0, 100));

            student1.Print();
            Console.WriteLine("Age: {0}", student1.Age(2018));
            student1.Grant(minScore);
            student1.PrintS();

            student2.Print();
            Console.WriteLine("Age: {0}", student2.Age(2018));
            student2.Grant(minScore);
            student2.PrintS();

            Console.ReadKey();
        }
    }
}
