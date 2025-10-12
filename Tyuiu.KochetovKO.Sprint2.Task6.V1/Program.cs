using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task6.V1.Lib;
namespace Tyuiu.KochetovKO.Sprint2.Task6.V1
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
            Console.WriteLine("Задание №6                                                                      ");
            Console.WriteLine("Вариант №1                                                                      ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("По данному номеру месяца, определите количество дней в этом месяце.             ");
            Console.WriteLine("                                                                                ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");            

            Console.WriteLine("Введите номер месяца : ");
            int digital = Convert.ToInt32(Console.ReadLine());

            var res = ds.FindMonthDaysCount(digital);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("в этом месяце : " + res);

            Console.ReadKey();
        
        }
    }
}