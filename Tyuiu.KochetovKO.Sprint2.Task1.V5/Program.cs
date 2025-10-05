using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task1.V5.Lib;
namespace Tyuiu.KochetovKO.Sprint2.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №2                                                                       ");
            Console.WriteLine("Тема: Логические операции                                                       ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №1                                                                      ");
            Console.WriteLine("Вариант №24                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Написать программу из операций сравнений                                        ");
            Console.WriteLine(" и логических операций                                                          ");
            Console.WriteLine("                                                                                ");

            int a = 154;
            int b = 163;
            int c = 134;
            int d = 137;
            bool[] res = new bool[6];
            res = res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + d);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                               ");
            Console.WriteLine("********************************************************************************");


            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}
