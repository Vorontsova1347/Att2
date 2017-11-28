using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class CalcSequence
    {
        public double X{ get; set; }//Св-во
        public CalcSequence(double x)//конструктор 
        {
            if (x > 1 || x < -1)
            {
                throw new Exception();

            }
            this.X = x;

        }
        public double CalcValue()//Метод
        {
            return Math.Atan(X);//вычисляет arctang(x);
        }

        public double SumSequence(int n, double e, out int c) //SumSequence - сумма последовательности
        {
            c = 0;

            double sum = X;
            double currentTerm = X; //currentTerm - текущее слагаемое

            if (currentTerm > e)
            {
                c = 1;
            for (int i = 1; i < n; i++)
            {
                currentTerm *= (-1) * X * X * ((double)(2 * i + 1) / (2 * i + 3));

                if (currentTerm > e)
                {
                    sum += currentTerm;
                    c++;
                }
                               
            }
            return sum;
            }
            else
            {
                return sum = 0;
            }
        }
    }
}
