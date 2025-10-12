using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task5.V11.Lib;

namespace Tyuiu.KochetovKO.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число:");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("********************************************************************************");

            try
            {
                string res = ds.FindDateOfNextDay(year, month, date);

                // Проверяем, вернула ли функция корректную дату
                if (DateTime.TryParse(res, out DateTime nextDate))
                {
                    string formattedDate = nextDate.ToString("dd.MM.yyyy");
                    Console.WriteLine("Следующий день: " + formattedDate);
                }
                else
                {
                    Console.WriteLine("Ошибка: Некорректная дата возвращена из метода");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}

