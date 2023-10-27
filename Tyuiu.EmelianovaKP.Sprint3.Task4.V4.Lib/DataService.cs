using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task4.V4.Lib
{
    public class DataService : ISprint3Task4V4
    {
        public double Calculate(int startValue, int stopValue)
        {
            double answer = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }

                answer += x / (Math.Cos(x) + Math.Sin(x));
            }

            return Math.Round(answer, 3);
        }
    }
}
