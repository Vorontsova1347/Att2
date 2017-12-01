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
using System.Threading;
using System.Globalization;

namespace _6._1._35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void CulcConclution_Click(object sender, EventArgs ev)
        {
            try
            {
                double x = double.Parse(ValueX.Text);
                double e = double.Parse(ValueE.Text);

                CalcSequence calc = new CalcSequence(x);

                int c;
                string answer = "Ответ: " + Environment.NewLine;

                answer += "Точная сумма: " + calc.CalcValue() + Environment.NewLine;

                /*answer += "Сумма N слагаемых: " + calc.SumSequence(n, 0, out c) + ", " +
                "Из них больше E: " + c + " штук" + Environment.NewLine;*/

                answer += "Сумма слагаемых, больших E: " + calc.SumSequence(e) + ", " +
                "Их кол-во: " + calc.CalcCountElem(e) + " шт" + Environment.NewLine;

                answer += "Сумма слагаемых, больших E/10: " + calc.SumSequence(e) + ", " +
                "Из них больше E/10: " + calc.CalcCountElem(e/10)+ " шт" + Environment.NewLine;

                Conclusion.Text = answer;
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message, "Ошибка! Введите (-1)< х < 1, 0 < e < 1!");
            }

        }

    }
}
