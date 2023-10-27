﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task5.V9.Lib
{
    public class DataService : ISprint3Task5V9
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sum = 0;

            for (int i = startValue1; i <= stopValue1; ++i)
            {
                for (int k = startValue2; k <= stopValue2; ++k)
                {
                    sum += 1 / Math.Sin(k) + x;
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
