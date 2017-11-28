using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class IOUtils
    {
        public static int[] ConvertStringToArray(string str)//преобразование строки в массив
        {
            string[] temp = str.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);//разбиение строки по разделителям 
            int[] arr = new int[temp.Length];

            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = int.Parse(temp[i]);
            }

            return arr;
        }

        public static string ConvertArrayToString(int[] arr)//конвертация массива в строку
        {
            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];

                if (i != arr.Length - 1)
                    result += " ";
            }

            return result;
        }
    }
}
