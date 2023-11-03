using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AlexandrovaEA.Sprint4.Task2.V5.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint4.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            int[] array = new int[14];
            Console.Title = "Спринт #4 | Выполнил: Александрова Е. А. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Александрова Е. А. | ИСПБ-23-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный        * ");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  С клавиатуры: 8, 2, 7, 5, 0, 7, 4, 7, 5, 7          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(3, 9);
            }

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент [" + i + "] - " + array[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(array));

            Console.ReadKey();
        }
    }
}
