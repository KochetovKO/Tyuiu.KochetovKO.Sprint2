using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task7.V8.Lib;
namespace Tyuiu.KochetovKO.Sprint2.Task7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №2                                                                       ");
            Console.WriteLine("Тема: Получение результата из switch                                            ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №7                                                                      ");
            Console.WriteLine("Вариант №8                                                                      ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Написать программу на C#, которая запрашивает исходные данные                   ");
            Console.WriteLine("и вычисляет, находится ли точка с координатами X,Y в заштрихованной области     ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            var res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            if (res = true)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
                Console.ReadKey();

        }
    }
}
