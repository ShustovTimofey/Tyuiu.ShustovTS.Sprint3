using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint3.Task0.V3.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            Console.Title = "Спринт #2 | Выполнил: Шустов Т.С. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Начало цикла: {startValue}");
            Console.WriteLine($" Конец цикла: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Сумма ряда: {ds.GetSumSeries(startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
