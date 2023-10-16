using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task2.V28.Lib
{
    public class DataService : ISprint3Task2V28
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double product = 1;

            do
            {
                product *= Math.Cos(value) * Math.Pow(2, startValue) / (startValue + 1);
                ++startValue;

            } while (startValue <= stopValue);

            return Math.Round(product, 3);
        }
    }
}
