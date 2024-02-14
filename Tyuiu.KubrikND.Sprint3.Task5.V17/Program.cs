using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task5.V17.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task5.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Вложенные циклы                                                   ");
            Console.WriteLine(" Задание #5                                                              ");
            Console.WriteLine(" Вариант 17                                                              ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            int x = 2;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 12;
            Console.WriteLine("Переменная х = " +x);
            Console.WriteLine("Старт шага первой суммы ряда: "+startvalue1);
            Console.WriteLine("Конец шага первой сумму ряда: "+stopvalue1);
            Console.WriteLine("Старт шага второй суммы ряда: "+startvalue2);
            Console.WriteLine("Конец шага второй суммы ряда: "+stopvalue2);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат                                                              *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2));
            Console.ReadKey();
        }
    }
}
