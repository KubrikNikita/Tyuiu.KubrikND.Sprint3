using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint3.Task3.V1.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" Спринт #3                                                               ");
            Console.WriteLine(" Тема: Оператор цикла do while                                           ");
            Console.WriteLine(" Задание #3                                                              ");
            Console.WriteLine(" Вариант 1                                                               ");
            Console.WriteLine(" Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               ");
            Console.WriteLine("Используя цикл foreach подсчитать количество букв “а” в строке:          ");
            Console.WriteLine("have a nice time                                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Исходные данные:                                                       ");
            Console.WriteLine("*************************************************************************");
            string value = "have a nice time";
            char chr = 'a';
            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Искомый символ: " + chr);
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*Результат:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Найдено символов: " + ds.GetCharCount(value, chr));
            Console.ReadKey();
        }
    }
}
