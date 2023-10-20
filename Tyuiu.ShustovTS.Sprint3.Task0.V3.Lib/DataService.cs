using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ShustovTS.Sprint3.Task0.V3.Lib
{
    public class DataService : ISprint3Task0V3
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                res += Math.Sin(i) / 4;
            }
            return Math.Round(res, 3);
        }
    }
}
