using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr arr1 = new Arr(5, 1, 21);
            arr1.Print();

            Console.WriteLine("Multiplication of the absolute values of the elements located after the first even element: {0}", arr1.AbsMultiplication());
            Console.WriteLine("Number of elements that are less than 50: {0}", arr1.LessThan50);

            string str = "123;1;456;23;2;-54;32;-9";
            Arr arr2 = new Arr(str);
            arr2.Print();

            Console.WriteLine("Multiplication of the absolute values of the elements located after the first even element: {0}", arr2.AbsMultiplication());
            Console.WriteLine("Number of elements that are less than 50: {0}", arr2.LessThan50);

            Console.ReadKey();
        }
    }
}
