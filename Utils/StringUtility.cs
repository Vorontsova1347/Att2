using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class StringUtility
    {
        public string Str { get; private set; } // Свойство
   

        public StringUtility(string s)
        {
            Str = s;
        }
   
        public string DeleteGaps()
        {
            string[] StrArr = Str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            // Разделение строки по пробелам с удалением пустых вхождений
            return string.Join(" ", StrArr); 
            //выводятся значения массива через пробел
        }

        public static string CharsToStr(int N,char C1, char C2)
        {
            if (N % 2 == 0 && N > 0)
            {
                string res = String.Empty; //создаём пустую строку
                for (int i = 0; i < N; i += 2)
                {
                    res += C1.ToString() + C2.ToString();
                }
                return res;
            }
           throw new Exception("Введено нечетное N");
        }

      

    }

}
