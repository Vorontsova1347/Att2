using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1._25
{
    static class Program
    {//25. Дан массив размера N. Вывести индексы массива в том порядке, 
     //в котором соответствующие им элементы образуют возрастающую1|убывающую2 последовательность.

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
