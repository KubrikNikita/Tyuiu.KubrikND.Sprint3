using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task6.V2.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Обработка целочисленной информации                                ");
            Console.WriteLine(" Задание #6                                                              ");
            Console.WriteLine(" Вариант 2                                                               ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("Напишите программу, которая ищет среди целых чисел, принадлежащих        ");
            Console.WriteLine("числовому отрезку [12, 18] количество всех делителей                     ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            int startValue = 12;
            int stopValue = 18;
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат                                                              *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
