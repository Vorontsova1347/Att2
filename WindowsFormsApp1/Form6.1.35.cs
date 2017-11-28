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
                int n = int.Parse(ValueN.Text);
                double e = double.Parse(ValueE.Text);


                CalcSequence calc = new CalcSequence(x);

                int c;
                string answer = "Ответ: " + Environment.NewLine;

                answer += "Точная сумма: " + calc.CalcValue() + Environment.NewLine;

                answer += "Сумма N слагаемых: " + calc.SumSequence(n, 0, out c) + ", " +
                "Из них больше E: " + c + " штук" + Environment.NewLine;

                answer += "Сумма N слагаемых, больших E: " + calc.SumSequence(n, e, out c) + ", " +
                "Из них больше E: " + c + " штук" + Environment.NewLine;

                answer += "Сумма N слагаемых, больших E/10: " + calc.SumSequence(n, e, out c) + ", " +
                "Из них больше E/10: " + c + " штук" + Environment.NewLine;

                Conclusion.Text = answer;
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message, "Ошибка! Введите (-1)< х < 1, 0 < e < 1!");
            }

        }

    }
}
