using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KochetovKO.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 620 == y;
            res[1] = x != y;
            res[2] = y < x;
            res[3] = x > y;
            res[4] = x <= y;
            res[5] = y >= x;

            return res;
        }
    }
}
