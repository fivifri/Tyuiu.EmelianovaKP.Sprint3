using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sum = 0;

            while (stopValue >= startValue)
            {
                sum += Math.Sin(stopValue--) * Math.Pow(value, 2);
            }

            return Math.Round(sum, 3);
        }
    }
}
