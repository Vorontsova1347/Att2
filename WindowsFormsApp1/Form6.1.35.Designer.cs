namespace _6._1._35
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Conclusion = new System.Windows.Forms.Label();
            this.ValueE = new System.Windows.Forms.TextBox();
            this.ValueN = new System.Windows.Forms.TextBox();
            this.NameE = new System.Windows.Forms.Label();
            this.NameN = new System.Windows.Forms.Label();
            this.ValueX = new System.Windows.Forms.TextBox();
            this.NameX = new System.Windows.Forms.Label();
            this.CulcConclution = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Conclusion);
            this.groupBox1.Controls.Add(this.ValueE);
            this.groupBox1.Controls.Add(this.ValueN);
            this.groupBox1.Controls.Add(this.NameE);
            this.groupBox1.Controls.Add(this.NameN);
            this.groupBox1.Controls.Add(this.ValueX);
            this.groupBox1.Controls.Add(this.NameX);
            this.groupBox1.Controls.Add(this.CulcConclution);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выражение";
            // 
            // Conclusion
            // 
            this.Conclusion.AutoSize = true;
            this.Conclusion.Location = new System.Drawing.Point(10, 136);
            this.Conclusion.Name = "Conclusion";
            this.Conclusion.Size = new System.Drawing.Size(0, 13);
            this.Conclusion.TabIndex = 9;
            // 
            // ValueE
            // 
            this.ValueE.Location = new System.Drawing.Point(154, 92);
            this.ValueE.Name = "ValueE";
            this.ValueE.Size = new System.Drawing.Size(100, 20);
            this.ValueE.TabIndex = 8;
            // 
            // ValueN
            // 
            this.ValueN.Location = new System.Drawing.Point(154, 59);
            this.ValueN.Name = "ValueN";
            this.ValueN.Size = new System.Drawing.Size(100, 20);
            this.ValueN.TabIndex = 7;
            // 
            // NameE
            // 
            this.NameE.AutoSize = true;
            this.NameE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameE.Location = new System.Drawing.Point(9, 92);
            this.NameE.Name = "NameE";
            this.NameE.Size = new System.Drawing.Size(93, 20);
            this.NameE.TabIndex = 6;
            this.NameE.Text = "Введите е:";
            // 
            // NameN
            // 
            this.NameN.AutoSize = true;
            this.NameN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameN.Location = new System.Drawing.Point(9, 59);
            this.NameN.Name = "NameN";
            this.NameN.Size = new System.Drawing.Size(93, 20);
            this.NameN.TabIndex = 5;
            this.NameN.Text = "Введите n:";
            // 
            // ValueX
            // 
            this.ValueX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValueX.Location = new System.Drawing.Point(154, 26);
            this.ValueX.Name = "ValueX";
            this.ValueX.Size = new System.Drawing.Size(100, 20);
            this.ValueX.TabIndex = 2;
            // 
            // NameX
            // 
            this.NameX.AutoSize = true;
            this.NameX.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameX.Location = new System.Drawing.Point(9, 26);
            this.NameX.Name = "NameX";
            this.NameX.Size = new System.Drawing.Size(91, 20);
            this.NameX.TabIndex = 1;
            this.NameX.Text = "Введите х:";
            // 
            // CulcConclution
            // 
            this.CulcConclution.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CulcConclution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CulcConclution.Location = new System.Drawing.Point(13, 224);
            this.CulcConclution.Name = "CulcConclution";
            this.CulcConclution.Size = new System.Drawing.Size(194, 39);
            this.CulcConclution.TabIndex = 0;
            this.CulcConclution.Text = "Вычислить ";
            this.CulcConclution.UseVisualStyleBackColor = false;
            this.CulcConclution.Click += new System.EventHandler(this.CulcConclution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 460);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ValueX;
        private System.Windows.Forms.Label NameX;
        private System.Windows.Forms.Button CulcConclution;
        private System.Windows.Forms.TextBox ValueE;
        private System.Windows.Forms.TextBox ValueN;
        private System.Windows.Forms.Label NameE;
        private System.Windows.Forms.Label NameN;
        private System.Windows.Forms.Label Conclusion;
    }
}

