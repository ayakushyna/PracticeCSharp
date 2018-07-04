using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7._1
{
    public partial class Form3 : Form
    {
        enum EColor { WHITE, GRAY, BLUE, PINK };

        private static string firstResult = " ", secondResult = " ";
        private static Color backColor = Color.White;

        public Form3()
        {
            InitializeComponent();

            label2.Text = firstResult;
            label4.Text = secondResult;

            BackColor = backColor;
        }

        public Form3(bool first, bool second)
        {
            InitializeComponent();

            if (first) firstResult = CheckDivision() ? "Делится" : "Не делится";
            else firstResult = " ";
            if (second) secondResult = PrimeNumbers().ToString();
            else secondResult = " ";

            label2.Text = firstResult;
            label4.Text = secondResult;
            
            switch (Common.BackColorIndex)
            {
                case (int)EColor.WHITE:
                    {
                        backColor = Color.White;
                        break;
                    }
                case (int)EColor.GRAY:
                    {
                        backColor = Color.Gray;
                        break;
                    }
                case (int)EColor.BLUE:
                    {
                        backColor = Color.LightBlue;
                        break;
                    }
                case (int)EColor.PINK:
                    {
                        backColor = Color.LightPink;
                        break;
                    }
            }

            this.BackColor = backColor;
        }

        private bool CheckDivision()
        {
            return (Common.FirstNumber % Common.SecondNumber == 0);
        }

        private int PrimeNumbers()
        {
            int count = 0;
            int from = (Common.FirstNumber > Common.SecondNumber) ? Common.SecondNumber : Common.FirstNumber;
            int to = (from == Common.SecondNumber) ? Common.FirstNumber : Common.SecondNumber;

            bool[] arr = new bool[to+1];
            for (int i = 2; i <= to; i++)
                arr[i] = true;

            for (int i = 2; i <= to; i++)
            {
                if (arr[i] == true)
                {
                    for (int j = i * i; j <= to; j += i)
                        arr[j] = false;
                }
            }

            for (int i = from; i <= to; i++)
            {
                if (arr[i] == true)
                    count++;
            }
            return count;
        }
        

    }
}
