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

namespace create_label_and_textbox
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
            string textBox1Text = textBox1.Text;
            string Kolvo4icel = textBox2.Text;
            //проверка на правильный ввод
            if (Convert.ToInt32(Kolvo4icel) > 100)
            {
                MessageBox.Show("Чел, число от 0 до 100");
            }
            else
            {
                int StartNumber = Convert.ToInt32(textBox1Text);
                int quantityNumber = Convert.ToInt32(Kolvo4icel);
                //цикл создающий надписи
                for (int i = StartNumber; i <= StartNumber + quantityNumber - 1; i++)
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
                    //цикл создающий текстбоксы
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
        //цикл подсчитывающий сумму всех текстбоксов
        private void button2_Click(object sender, EventArgs e)
        {
            int StartNumber = Convert.ToInt32(textBox1.Text);
            int quantityNumber = Convert.ToInt32(textBox2.Text);
            sum = 0;
            for (int i = StartNumber; i <= StartNumber + quantityNumber - 1; i++)
            {
                System.Windows.Forms.TextBox chislo = (System.Windows.Forms.TextBox)this.Controls.Find("t" + i, true)[0];
                sum += Convert.ToInt32(chislo.Text);
            }
            button2.Text = Convert.ToString(sum);
        }
        //функции непозволяющие вводить ничего кроме чисел в текстбоксы
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
