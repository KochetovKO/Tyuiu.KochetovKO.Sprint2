﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KochetovKO.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool isInCircle = x * x + y * y <= 4.0;
            bool isAboveLine = y >= x;

            if (isInCircle && isAboveLine)
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
