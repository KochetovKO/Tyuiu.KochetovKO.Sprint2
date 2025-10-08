using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KochetovKO.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public static bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if (x >= 9 && x <= 12 && y >= 3 && y <= 10)
            {
                res = true;
            }
            else if (x >= 6 && x <= 8 && y >= 10 && y <= 11)
            {
                res = true;
            }
            else if (x == 4 && y >= 2 && y <= 8)
            {
                res = true;
            }
            else if (x >= 3 && x <= 5 && y == 11)
            {
                res = true;
            }
            else if (x >= 5 && x <= 8 && y == 6)
            {
                res = true;
            }
            else if (x == 13 && y >= 6 && y <= 8) 
            {
                res = true;
            }
            else if (x == 8 && y >= 7 && y <= 9)
            {
                res = true;
            }
            else if (x >= 7 && x <= 9 && y == 12)
            {
                res = true;
            }

            else if (x == 8 && y == 5)
            {
                res = true;
            }
            else if (x == 3 && y == 6)
            {
                res = true;
            }
            else if (x == 9 && y == 11)
            {
                res = true;
            }

            return res;
        }
    }
}   
