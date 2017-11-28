using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mass
{
    public enum OrderType
    {
        Asc, // Не убывание
        Desc // Не возрастает
    }

    public class ArrayUtils
    {
        public int[][] Arr { get; set; }

        public ArrayUtils(int[][] arr)
        {
            this.Arr = arr;
        }

        public int[] GetIndexesForOrderedSequence(OrderType orderType) 
        {
            int[] indexes = new int[Arr.Length];

            Array.Sort(Arr, (int[] v1, int[] v2) => (orderType == OrderType.Asc) ? v1[1] - v2[1] : v2[1] - v1[1]);

            for (int i = 0; i < Arr.Length; i++)
            {
                indexes[i] = Arr[i][0];
            }

            return indexes;
        }


    }
}
