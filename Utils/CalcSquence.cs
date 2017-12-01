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

        public double SumSequence(double e) //SumSequence - сумма последовательности
        {
            int i = 0;
            double sum = 0;
            double currentTerm = X; //currentTerm - текущее слагаемое

            while (Math.Abs(currentTerm) > e)
            {
                sum += currentTerm;
                i++;
                currentTerm *= (-1) * X * X * ((double)(2 * i + 1) / (2 * i + 3));
            }

            return sum;
        }

        public double CalcCountElem(double e) //CalcCountElem - счёт кол-ва элементов 
        {
            int i = 0;
            int count = 0;
            double currentTerm = X; //currentTerm - текущее слагаемое

            while (Math.Abs(currentTerm) > e)
            {
                count++;
                i++;
                currentTerm *= (-1) * X * X * ((double)(2 * i + 1) / (2 * i + 3));
            }

            return count;
        }
    }
}
