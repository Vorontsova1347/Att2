using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public enum OrderType
    {
        Asc, // Не убывание
        Desc // Не возрастает
    }

    public class ArrayUtils
    {
        public int[] Arr { get; set; }

        public ArrayUtils(int[] arr)
        {
            this.Arr = arr;
        }

        public int[] GetIndexesForOrderedSequence(OrderType orderType) //сортировка массива с сохранением индексов
        {
            int[][] newArr = new int[Arr.Length][];

            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = new int[] { i, Arr[i] };
            }

            Array.Sort(newArr, (int[] v1, int[] v2) => (orderType == OrderType.Asc) ? v1[1] - v2[1] : v2[1] - v1[1]);


            int[] indexes = new int[Arr.Length];//массив индексов, чтобы их не потерять

            for (int i = 0; i < Arr.Length; i++)
            {
                indexes[i] = newArr[i][0];
            }

            return indexes;
        }
        public long Sum()
        {
            long Savedsum = 0;
            long Sum = 0;
            bool flag = false;
            int flagI = 0;
            for (int i = 0; i < Arr.Length-1;i++)
            {
                if (TestProst.prime(Arr[i]) && !flag)
                {
                    flag = true;
                    flagI = i;
                }
                if ( flag )
                {
                    
                    Sum += Arr[i];
                    
                } 
                if (TestProst.prime(Arr[i+1]))
                {
                    Savedsum = Sum;                 
                }
                
            }
            return Savedsum-Arr[flagI];
        }
        


    }
}
