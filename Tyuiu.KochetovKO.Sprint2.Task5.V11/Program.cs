using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task5.V11.Lib;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.KochetovKO.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 2 | выполнил: Кочетов К.О. | ИСПБ-25-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Спринт №2                                                                       ");
            Console.WriteLine("Тема: Оператор switch                                                           ");
            Console.WriteLine("**********************************************                                  ");
            Console.WriteLine("Задание №5                                                                      ");
            Console.WriteLine("Вариант №11                                                                     ");
            Console.WriteLine("Выполнил: Кочетов Кирилл Олегович | ИСПБ-25-1                                   ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("УСЛОВИЕ:                                                                        ");
            Console.WriteLine("Написать программу, которая использует оператор switch                          ");
            Console.WriteLine("вычисляет требуемое значение и возвращает результат.                            ");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите год :");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц :");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число :");
            int date = Convert.ToInt32(Console.ReadLine());


            string res = ds.FindDateOfNextDay(year, month, date);  

            


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Следующий день: " + res);
            Console.ReadKey();


        }
    }
}