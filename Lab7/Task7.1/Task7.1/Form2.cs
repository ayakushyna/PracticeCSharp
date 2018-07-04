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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if( textBox1.TextLength > 0 && textBox2.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else if(button1.Enabled) button1.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && (checkBox1.Checked || checkBox2.Checked))
            {
                button1.Enabled = true;
            }
            else if (button1.Enabled) button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) == 0 || Convert.ToInt32(textBox2.Text) == 0)
                    throw new Exception();
                Common.FirstNumber = Convert.ToInt32(textBox1.Text);
                Common.SecondNumber = Convert.ToInt32(textBox2.Text);
                Common.BackColorIndex = comboBox1.SelectedIndex;
                Common.Calc = true; 
                Form3 form3 = new Form3(checkBox1.Checked, checkBox2.Checked);
                form3.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Введите натуральные числа.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
