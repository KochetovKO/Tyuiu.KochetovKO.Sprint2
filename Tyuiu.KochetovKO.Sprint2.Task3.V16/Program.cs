using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KochetovKO.Sprint2.Task3.V16.Lib;
namespace Tyuiu.KochetovKO.Sprint2.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ :                                                               ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Введите значение x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ :                                                                     ");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("Значение функции x : " + res);

            Console.ReadKey();



        }
    }
}
