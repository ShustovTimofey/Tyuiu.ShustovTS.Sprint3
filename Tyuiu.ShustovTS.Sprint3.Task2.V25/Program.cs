using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint3.Task2.V25.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 13;
            Console.Title = "Спринт #2 | Выполнил: Мальсагов У.А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do-while, которая вычисляет сумму     *");
            Console.WriteLine("* ряда по формуле, при N = 5.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Переменная N: {value}");
            Console.WriteLine($" Начало цикла: {startValue}");
            Console.WriteLine($" Конец цикла: {stopValue}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Произведение ряда: {ds.GetSumSeries(value, startValue, stopValue)}");
            Console.ReadKey();
        }
    }
}
