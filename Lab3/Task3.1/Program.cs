using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int integer = random.Next();

            Number number = new Number(integer);
            number.Print();

            Console.WriteLine("Prime number: {0}", number.Prime());
            Console.WriteLine("Palindrome: {0}", number.Palindrome());

            Console.ReadKey();
        }
    }
}
