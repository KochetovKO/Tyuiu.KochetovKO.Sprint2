using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KochetovKO.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool xRange = (x > 0);
            bool yRange = (y > 0) && (y <= 4);

            if (xRange && yRange)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
