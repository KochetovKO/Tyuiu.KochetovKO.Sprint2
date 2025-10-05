using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KochetovKO.Sprint2.Task1.V5.Lib
{
    public class DataService : ISprint2Task1V5
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[]res = new bool[6];
            res[0] = (a + b) == (c + d + 46);
            res[1] = ((d + c) > (a + b)) & ((a + b) != (d + c));
            res[2] = ((b + c) == (a + d)) || ((a + b) < (d + c));
            res[3] = ((a - c) > (b - d)) && (a + 10 < b);
            res[4] = !false;
            res[5] = ((a + b) > (c + d)) ^ ((c + d) < (a + b));

            return res;
        }
    }
}
