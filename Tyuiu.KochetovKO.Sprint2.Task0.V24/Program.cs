using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task0.V24.Lib;
namespace Tyuiu.KochetovKO.Sprint2.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №2                                                                       ");
            Console.WriteLine("Тема: Операции сравнения                                                        ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №0                                                                      ");
            Console.WriteLine("Вариант №24                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Написать программу из операций сравнений                                        ");
            Console.WriteLine("и арифметических выражений, которая вернет логическую последовательность(массив)");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            int x = 135;
            int y = 755;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("X = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬАТ                                                                        ");
            Console.WriteLine("********************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
        
            Console.ReadKey();
        }
    }
}