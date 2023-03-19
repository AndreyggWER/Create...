using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Создание_текстбокса_и_надписи
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum = 0;
        int y = 120;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) > 100)
            {
                MessageBox.Show("Чел, число от 0 до 100");
            }
            else
            {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
                for (int i = a; i <= a + b - 1; i++)
                {
                    y += 30;
                    Label label3 = new Label()
                    {
                        Text = "&число " + i + ": ",
                        Location = new Point(20, y),
                        TabIndex = 10,
                        Name = "l" + i,
                        Font = new Font("Microsoft Sans Serif", 10)
                    };
                    Controls.Add(label3);
                    System.Windows.Forms.TextBox textBox3 = new System.Windows.Forms.TextBox()
                    {

                        Location = new Point(120, y),
                        TabIndex = 10,
                        Name = "t" + i,
                    };
                    Controls.Add(textBox3);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            sum = 0;
            for (int i = a; i <= a + b - 1; i++)
            {
                System.Windows.Forms.TextBox t = (System.Windows.Forms.TextBox)this.Controls.Find("t" + i, true)[0];
                sum += Convert.ToInt32(t.Text);
            }
            button2.Text = Convert.ToString(sum);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

    }
}
