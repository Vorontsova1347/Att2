using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();

                int[] mas1 = new int[10];
                byte[] mas2 = new byte[10];
                double[] mas3 = new double[10];
   /* Основные методы:
    Название                    Описание
    Next()            Возвращает целое положительное число во всем положительном диапазоне int
    Next(max)         Возвращает целое положительное число в диапазоне [0, max]
    Next(min,max)     Возвращает целое положительное число в диапазоне [min, max]
    NextBytes(массив) Возвращает массив чисел в диапазоне [0, 255]
    NextDouble()      Возвращает вещественное положительное число в диапазоне [0, 1)  */
            Console.WriteLine("Массив целых чисел вдиапазоне - 50..50");

            for (int i = 0; i < 10; i++)
                mas1[i] = (a.Next(-50, 50)); // Next()

            foreach (int m in mas1)
                Console.Write("{0} ", m);
                Console.WriteLine();

            Console.WriteLine("Массив целых чисел в диапазоне 0..255");

                a.NextBytes(mas2); //NextBytes(массив)

            foreach (int m in mas2)
                Console.Write("{0} ", m);
                Console.WriteLine();

            Console.WriteLine("Массив вещественных чисел в диапазоне - 50..50");

            for (int i = 0; i < 10; i++)
                mas3[i] = (a.NextDouble() - 0.5) * 100; //NextDouble()

            foreach (double m in mas3)
                Console.Write("{0:00.00} ", m);

            Console.WriteLine();


            int[] c = { 1, 2, 3, 4, 54 }; 
            // Объявили и определили массив
            foreach (int i in c) 
            //foreach (тип имя in выражение) оператор;
                Console.Write(i);
                Console.WriteLine();
            Console.WriteLine("Свойство Length определяет количество элементов массива(по всем размерностям)");
            for (int i = 0; i < c.Length; i++)
            //Свойство Length определяет количество элементов массива(по всем размерностям)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Свойство Rank показывает размерность массива)");
            Console.WriteLine(c.Rank);
            //Свойство Rank показывает размерность массива

            Console.WriteLine("возвращает номер первого вхождения указанного элемента.");
            int w = Array.IndexOf(c, 54);
            Console.WriteLine(w);
            /*Метод IndexOf() возвращает номер первого вхождения указанного элемента.
             * Если элемент не найден, то возвращается -1*/

            Console.WriteLine("возвращает номер последнего вхождения указанного элемента.");
            int b = Array.LastIndexOf(c, 2);
            Console.WriteLine(b);
            /*Метод LastIndexOf() возвращает номер последнего вхождения указанного элемента.
             * Если элемент не найден, то возвращается -1*/

            Console.WriteLine("сортирует одномерный массив встроенных типов данных");
            Array.Sort(c);
            for (int i = 0; i < c.Length; i++) // вывод отсортированного массива                 
            Console.Write(" " + c[i]);
            /*Метод Sort() сортирует одномерный массив встроенных типов данных, 
             * причем массив передается как параметр.*/

            Console.WriteLine("расставляет элементы одномерного массива в обратном порядке");
            Array.Reverse(c);
            /*Метод Reverse() позволяет расставить элементы одномерного массива в обратном порядке,
             * причем массив передается как параметр.*/

            Console.WriteLine(" выполняет двоичный поиск в отсортированном массиве");
            Array.Sort(c);
            Console.WriteLine(Array.BinarySearch(c, 3));
            /*Метод BinarySearch() выполняет двоичный поиск в отсортированном массиве.
             *Возвращает индекс элемента.*/

            Console.WriteLine("копирует элементы из исходного массива в массив назначения.");
            int[] d = new int[6];
            c.CopyTo(d, 0);
            /*Метод CopyTo() используется для копирования 
             * элементов из исходного массива в массив назначения.*/


            Console.WriteLine("копирует элементы заданного диапазона из исходного массива в массив назначения.");
            int[] h = new int[5];
            Array.Copy(c, h, 3); // 12 32 3 0 0 0
            Array.Copy(c, 1, h, 2, 3); // 0 0 32 3 54 0
            /*Метод Copy() используется для копирования заданного диапазона 
             * элементов из исходного массива в массив назначения.*/

            Array.Clear(c, 0, c.Length);
            /*Метод Clear(имя массива, индекс, с которого происходит очистка, число элементов.) 
             * позволяет очистить указанный диапазон элементов
             * (числовые элементы приобретут значения 0, ссылки на объекты — null,
             * логические элементы -false).*/

            Console.ReadKey();
        }
    }
}
