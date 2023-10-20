using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint3.Task1.V24.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 12;
            Console.Title = "Спринт #3 | Выполнил: Шустов Т.С. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы цикличекой структуры                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при X = 5.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Переменная X: {value}");
            Console.WriteLine($"Старт шага: {startValue}");
            Console.WriteLine($"Конец шага: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.Write($"Сумма ряда = {dataService.GetSumSeries(value, startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
