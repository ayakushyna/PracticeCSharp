using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7._2
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[4,3];
        private TextBox textBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox = new TextBox
            {
                ReadOnly = true,
                Location = new Point(60, 50),
                Size = new Size(300, 20)
            };
            Controls.Add(textBox);

            int number = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Size = new Size(80, 50),
                        Location = new Point(70 + j * 100, 100 + i * 70)
                    };

                    if (number < 10) buttons[i, j].Text = number.ToString();
                    else if (number == 10)
                    {
                        buttons[i, j].Text = "Корень";
                    }
                    else buttons[i, j].Text = "C";

                    number++;

                    buttons[i, j].Click += new EventHandler(buttons_Click);
                    Controls.Add(buttons[i, j]);
                }
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                if (button.Text.Length == 1 && button.Text != "C")
                {
                    if (textBox.Text.Contains(","))
                        textBox.Clear();
                    textBox.Text += button.Text;
                }
                else if (button.Text == "C") textBox.Clear();
                else textBox.Text = String.Format("{0:F5}", Math.Sqrt(Convert.ToDouble(textBox.Text)));
            }
            catch
            {
                MessageBox.Show("Введите число");
            }
        }
        
    }
}
