namespace create_label_and_textbox
{
    partial class FormGenerationNumber
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxStartNumber = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxQuantityNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStartNumber
            // 
            this.textBoxStartNumber.AcceptsReturn = true;
            this.textBoxStartNumber.Location = new System.Drawing.Point(183, 12);
            this.textBoxStartNumber.Name = "textBoxStartNumber";
            this.textBoxStartNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartNumber.TabIndex = 0;
            this.textBoxStartNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartNumber_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxQuantityNumber
            // 
            this.textBoxQuantityNumber.Location = new System.Drawing.Point(183, 35);
            this.textBoxQuantityNumber.Name = "textBoxQuantityNumber";
            this.textBoxQuantityNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantityNumber.TabIndex = 2;
            this.textBoxQuantityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantityNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начальное число(любое):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество чисел(от 0 до 100):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.textBoxStartNumber_Click);
            // 
            // ButtonSum
            // 
            this.ButtonSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSum.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSum.Location = new System.Drawing.Point(15, 80);
            this.ButtonSum.Name = "ButtonSum";
            this.ButtonSum.Size = new System.Drawing.Size(121, 22);
            this.ButtonSum.TabIndex = 6;
            this.ButtonSum.Text = "Подсчитать сумму";
            this.ButtonSum.UseVisualStyleBackColor = false;
            this.ButtonSum.Click += new System.EventHandler(this.ButtonSum_Click);
            // 
            // FormGenerationNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuantityNumber);
            this.Controls.Add(this.textBoxStartNumber);
            this.Name = "FormGenerationNumber";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStartNumber;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxQuantityNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonSum;
    }
}

