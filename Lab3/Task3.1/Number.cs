using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Number
    {
        private int integer;

        public Number(int integer)
        {
            this.integer = integer;
        }

        public bool Prime()
        {
            for(int i = 2; i <= Math.Sqrt(integer); i++)
		        if (integer % i == 0)
                    return false;
            return true;
        }

        public bool Palindrome()
        {
            if( integer == Reverse(integer))
                    return true;
            return false;
        }

        private int Reverse(int num)
        {
            int rNum = 0;
            while (num != 0)
            {
                rNum = rNum * 10 + num % 10;
                num /= 10;
            }
            return rNum;
        }

        public void Print()
        {
            Console.WriteLine("Integer = {0}", integer);
        }
    }
}
