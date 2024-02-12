using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task4.V26.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Использование операторов continue и break в циклах                ");
            Console.WriteLine(" Задание #4                                                              ");
            Console.WriteLine(" Вариант 26                                                              ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("На отрезке, где x принимает значения от -5 до 5, вычислить значение      ");
            Console.WriteLine("функции y=(cos(x)-sin(x))/x                                              ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}