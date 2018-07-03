using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6._1
{
    public partial class Form : System.Windows.Forms.Form
    {
        int firstNumber, secondNumber;
        public Form()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(textBox2.Text);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(firstNumber) && Check(secondNumber))
                textBox3.Text = "Оба однозначные";
            else if (Check(firstNumber) || Check(secondNumber))
                textBox3.Text = "Одно однозначное";
            else
                textBox3.Text = "Оба не однозначные";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private bool Check(int number)
        {
            return (number % 10 == number);
        }


    }
}
