using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KubrikND.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MultiplySeries = MultiplySeries + (Math.Pow(value, i) + 4) * Math.Cos(value);
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}