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
    public partial class FormGenerationNumber : Form
    {
        public FormGenerationNumber()
        {
            InitializeComponent();
        }
        int sum = 0;
        int y = 120;
        private void textBoxStartNumber_Click(object sender, EventArgs e)
        {
            int StartNumber = Convert.ToInt32(textBoxStartNumber.Text);
            int QuantityNumber = Convert.ToInt32(textBoxQuantityNumber.Text);
            //проверка на правильный ввод
            if (Convert.ToInt32(QuantityNumber) > 100)
            {
                MessageBox.Show("Чел, число от 0 до 100");
            }
            else
            {
                //цикл создающий надписи
                for (int i = StartNumber; i <= StartNumber + QuantityNumber - 1; i++)
                {
                    y += 30;
                    Label labelGenerate = new Label()
                    {
                        Text = "&число " + i + ": ",
                        Location = new Point(20, y),
                        TabIndex = 10,
                        Name = "l" + i,
                        Font = new Font("Microsoft Sans Serif", 10)
                    };
                    Controls.Add(labelGenerate);
                    //цикл создающий текстбоксы
                    System.Windows.Forms.TextBox textBoxGenerate = new System.Windows.Forms.TextBox()
                    {

                        Location = new Point(120, y),
                        TabIndex = 10,
                        Name = "t" + i,
                    };
                    Controls.Add(textBoxGenerate);
                }
            }
        }
        //цикл подсчитывающий сумму всех текстбоксов
        private void buttonSum_Click(object sender, EventArgs e)
        {
            int StartNumber = Convert.ToInt32(textBoxStartNumber.Text);
            int QuantityNumber = Convert.ToInt32(textBoxQuantityNumber.Text);
            sum = 0;
            for (int i = StartNumber; i <= StartNumber + QuantityNumber - 1; i++)
            {
                System.Windows.Forms.TextBox chislo = (System.Windows.Forms.TextBox)this.Controls.Find("t" + i, true)[0];
                sum += Convert.ToInt32(chislo.Text);
            }
            buttonSum.Text = Convert.ToString(sum);
        }
        //функции непозволяющие вводить ничего кроме чисел в текстбоксы
        private void textBoxStartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBoxQuantityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

    }
}
