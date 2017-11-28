namespace _6._1._25
{
    partial class Form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.OutText = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Ввод N ";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(81, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Вывод строки ";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(96, 11);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(39, 20);
            this.N.TabIndex = 2;
            // 
            // OutText
            // 
            this.OutText.Location = new System.Drawing.Point(96, 91);
            this.OutText.Name = "OutText";
            this.OutText.Size = new System.Drawing.Size(100, 20);
            this.OutText.TabIndex = 3;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(15, 120);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(96, 40);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(39, 20);
            this.C1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ввод С1";
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(96, 66);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(39, 20);
            this.C2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ввод С2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.OutText);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox OutText;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox C1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox C2;
        private System.Windows.Forms.Label label4;
    }
}

