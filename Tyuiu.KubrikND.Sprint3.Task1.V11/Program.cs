using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Оператор цикла while                                              ");
            Console.WriteLine(" Задание #1                                                              ");
            Console.WriteLine(" Вариант 11                                                              ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("Написать программу используя цикл while, которая вычисляет произведение  ");
            Console.WriteLine("ряда по формуле, при a=0,75                                              ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;
            Console.WriteLine("Переменная а = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
