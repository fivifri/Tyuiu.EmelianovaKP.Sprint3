﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task0.V21.Lib
{
    public class DataService : ISprint3Task0V21
    {
        public double GetSumSeries(double value)
        {
            double sum = 0;

            for (int k = 1; k <= 13; ++k)
            {
                sum += Math.Sin(k) * (0.25 + Math.Pow(value, k));
            }

            return Math.Round(sum, 3);
        }
    }
}
