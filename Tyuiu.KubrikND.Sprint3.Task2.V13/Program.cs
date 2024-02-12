using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task2.V13.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task2.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Оператор цикла do while                                           ");
            Console.WriteLine(" Задание #2                                                              ");
            Console.WriteLine(" Вариант 13                                                              ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("Написать программу используя цикл do...while, которая вычисляет сумму    ");
            Console.WriteLine("ряда по формуле, при t=0,7                                               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;
            Console.WriteLine("Переменная а = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
