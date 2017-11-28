namespace _8._1._25
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
            this.NameList1 = new System.Windows.Forms.Label();
            this.NameList2 = new System.Windows.Forms.Label();
            this.InputList1 = new System.Windows.Forms.TextBox();
            this.InputList2 = new System.Windows.Forms.TextBox();
            this.DOIT = new System.Windows.Forms.Button();
            this.ElemBox = new System.Windows.Forms.GroupBox();
            this.Aswer = new System.Windows.Forms.TextBox();
            this.NameList3 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.ElemBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameList1
            // 
            this.NameList1.AutoSize = true;
            this.NameList1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameList1.Location = new System.Drawing.Point(7, 82);
            this.NameList1.Name = "NameList1";
            this.NameList1.Size = new System.Drawing.Size(43, 20);
            this.NameList1.TabIndex = 0;
            this.NameList1.Text = "List1";
            // 
            // NameList2
            // 
            this.NameList2.AutoSize = true;
            this.NameList2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameList2.Location = new System.Drawing.Point(7, 139);
            this.NameList2.Name = "NameList2";
            this.NameList2.Size = new System.Drawing.Size(43, 20);
            this.NameList2.TabIndex = 1;
            this.NameList2.Text = "List2";
            // 
            // InputList1
            // 
            this.InputList1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InputList1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputList1.Location = new System.Drawing.Point(79, 82);
            this.InputList1.Name = "InputList1";
            this.InputList1.Size = new System.Drawing.Size(285, 26);
            this.InputList1.TabIndex = 2;
            // 
            // InputList2
            // 
            this.InputList2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.InputList2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputList2.Location = new System.Drawing.Point(79, 139);
            this.InputList2.Name = "InputList2";
            this.InputList2.Size = new System.Drawing.Size(285, 26);
            this.InputList2.TabIndex = 3;
            // 
            // DOIT
            // 
            this.DOIT.Location = new System.Drawing.Point(11, 318);
            this.DOIT.Name = "DOIT";
            this.DOIT.Size = new System.Drawing.Size(168, 41);
            this.DOIT.TabIndex = 4;
            this.DOIT.Text = "DOIT";
            this.DOIT.UseVisualStyleBackColor = true;
            this.DOIT.Click += new System.EventHandler(this.DOIT_Click);
            // 
            // ElemBox
            // 
            this.ElemBox.Controls.Add(this.labelText);
            this.ElemBox.Controls.Add(this.Aswer);
            this.ElemBox.Controls.Add(this.NameList3);
            this.ElemBox.Controls.Add(this.NameList1);
            this.ElemBox.Controls.Add(this.DOIT);
            this.ElemBox.Controls.Add(this.NameList2);
            this.ElemBox.Controls.Add(this.InputList2);
            this.ElemBox.Controls.Add(this.InputList1);
            this.ElemBox.Location = new System.Drawing.Point(3, 12);
            this.ElemBox.Name = "ElemBox";
            this.ElemBox.Size = new System.Drawing.Size(473, 432);
            this.ElemBox.TabIndex = 5;
            this.ElemBox.TabStop = false;
            this.ElemBox.Text = "ElemBox";
            // 
            // Aswer
            // 
            this.Aswer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Aswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Aswer.Location = new System.Drawing.Point(79, 225);
            this.Aswer.Name = "Aswer";
            this.Aswer.Size = new System.Drawing.Size(285, 26);
            this.Aswer.TabIndex = 6;
            // 
            // NameList3
            // 
            this.NameList3.AutoSize = true;
            this.NameList3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NameList3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameList3.Location = new System.Drawing.Point(7, 225);
            this.NameList3.Name = "NameList3";
            this.NameList3.Size = new System.Drawing.Size(61, 20);
            this.NameList3.TabIndex = 5;
            this.NameList3.Text = "Ответ:";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelText.Location = new System.Drawing.Point(7, 35);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(338, 20);
            this.labelText.TabIndex = 7;
            this.labelText.Text = "Введите значения через запятую и пробел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 470);
            this.Controls.Add(this.ElemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ElemBox.ResumeLayout(false);
            this.ElemBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameList1;
        private System.Windows.Forms.Label NameList2;
        private System.Windows.Forms.TextBox InputList1;
        private System.Windows.Forms.TextBox InputList2;
        private System.Windows.Forms.Button DOIT;
        private System.Windows.Forms.GroupBox ElemBox;
        private System.Windows.Forms.TextBox Aswer;
        private System.Windows.Forms.Label NameList3;
        private System.Windows.Forms.Label labelText;
    }
}

