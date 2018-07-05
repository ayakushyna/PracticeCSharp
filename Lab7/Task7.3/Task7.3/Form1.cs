using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7._3
{
    public partial class Form1 : Form
    {
        private int hours, minutes;

        public Form1()
        {
            InitializeComponent();
            hours = 0;
            minutes = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Пуск")
            {
                timer1.Start();
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Пуск";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = 0;
            minutes = 0;
            label1.Text = "00";
            label3.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (minutes < 59)
            {
                minutes++;
                label3.Text = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            }
            else
            {
                hours++;
                label1.Text = hours < 10 ? "0" + hours.ToString() : hours.ToString();
                minutes = 0;
                label3.Text = "00";
            }
        }
    }
}
