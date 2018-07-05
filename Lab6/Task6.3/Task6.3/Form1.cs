using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6._3
{
    public partial class Form1 : Form
    {
        string firstStr, secondStr;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                firstStr = textBox1.Text;
                secondStr = textBox2.Text;

                if(firstStr.Length==0 || secondStr.Length==0)
                    throw new Exception();

                if (checkBox1.Checked)
                {
                    if (firstStr.Contains(secondStr))
                    {
                        label2.Text = "Результат: Входит";
                    }
                    else label2.Text = "Результат: Не входит";
                }
                else label2.Text = "Результат:";

                if (checkBox2.Checked)
                {
                    int count = 0, index = firstStr.IndexOf(secondStr);
                    while (index != -1)
                    {
                        count++;
                        index = firstStr.IndexOf(secondStr, index + 1);
                    }
                    label3.Text = "Результат: "+ count.ToString();
                }
                else label3.Text = "Результат:";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label2.Text = "Результат:";
            label3.Text = "Результат:";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
                button1.Enabled = true;
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
                button1.Enabled = true;
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && textBox1.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
                button1.Enabled = true;
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0 && textBox1.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
                button1.Enabled = true;
            else if (button1.Enabled) button1.Enabled = false;
        }



    }
}
