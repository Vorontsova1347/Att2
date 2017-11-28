using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassUtils
{
    public class Class1
    {
        public static int[] ConvertStringToArray(string str)
        {
            string[] parts = str.Split(' ');

            int[] result = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                result[i] = int.Parse(parts[i]);
            }

            return result;
        }
        
            /* Создаём класс Массив
             * Св-ва класса: размер массива
             * Методы: ввод в массив, вывод массива, сортировка массива по возрастанию/убыванию,
             * вывод индексов отсортированных элементов массива*/
        }
    }
}
