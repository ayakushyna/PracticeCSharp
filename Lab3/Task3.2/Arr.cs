using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Arr
    {
        private int n;
        private int[] array;
        private int lessThan50;

        public Arr(int n, int x1, int d)
        {
            this.n = n;
            array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = x1 + d * i;
            }
        }

        public Arr(string str)
        {
            string[] numbers = str.Split(new char[] { ';' });
            this.n = numbers.Length;
            array = new int[n];

            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(numbers[i]);
            }

        }

        public int LessThan50
        {
            get
            { 
                lessThan50 = 0;

                foreach(int number in array)
                {
                    if (number < 50) lessThan50++;
                }

                return lessThan50;
            }
        }

        public void Print()
        {
            foreach (int number in array)
            {
                Console.Write("{0} | ", number);
            }
            Console.WriteLine();
        }

        public int AbsMultiplication()
        {
            int result = 1,i = 0;
            bool t = false;

            while (i < n)
            {
                if(array[i] % 2 == 0)
                {
                    t = true;
                    break;
                }

                i++;
            }

            for ( ; i < n; i++)
            {
                result *= Math.Abs(array[i]);
            }

            return t? result: 0;
        }
    }
}
