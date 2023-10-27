using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double Func(int x)
        { 
            if (Math.Cos(x) + 1 == 0)
            {
                return 0.00;
            }

            return Math.Round(3 * x + 2 - (2.0 * x - x) / (Math.Cos(x) + 1), 2);
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];

            int id = 0;

            for (int i = startValue; i <= stopValue; ++i)
            {
                result[id++] = Func(i);
            } 

            

            return result;
        }
    }
}
