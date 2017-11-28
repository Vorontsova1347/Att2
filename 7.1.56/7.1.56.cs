using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._1._56
{
    static class Program
    {//56. Вводится массив целых чисел. Найти сумму четных элементов массива, 
     //расположенных между первым простым (по модулю) элементом массива 
     //и последним простым (по модулю) элементом. Для проверки простоты числа реализовать отдельную функцию. 
     //Ноль считать простым числом. Подумать, как реализовать данный алгоритм в один проход
     //(т.е. один цикл; цикл, который, вероятно, будет использован в функции проверки простоты числа не считаем).

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
