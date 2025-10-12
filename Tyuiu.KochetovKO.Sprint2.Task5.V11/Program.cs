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

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите год :");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите месяц :");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число :");
            int date = Convert.ToInt32(Console.ReadLine());


            string res = ds.FindDateOfNextDay(year, month, date); date.ToString("dd.MM.yyyy");  

            DateTime res1 = DateTime.Parse(res); 
            string fd = res1.ToString("dd.MM.yyyy");


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Следующий день: " + fd);
            Console.ReadKey();


        }
    }
}