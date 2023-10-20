using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShustovTS.Sprint3.Task3.V7.Lib;
namespace Tyuiu.ShustovTS.Sprint3.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            Console.Title = "Спринт #2 | Выполнил: Шустов Т.С. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Шустов Тимофей Сергеевич | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы g на цифру 4 в искомой строке.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Искомая строка: {value}");
            Console.WriteLine($" Искомая буква, которую нужно заменить: {replaceable}");
            Console.WriteLine($" Цифра, на которую нужно заменить букву {replaceable}: {replacement}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($" Строка в итоге: {ds.ReplaceCharOnNum(value, replaceable, replacement)}");
            Console.ReadKey();
        }
    }
}
