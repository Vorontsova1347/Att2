using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;


namespace _6._1._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                OutText.Text = StringUtility.CharsToStr(int.Parse(N.Text), C1.Text[0], C2.Text[0]); 
                // вывод результата
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Вывод сообщения об ошибке
        }

      
    }
}
