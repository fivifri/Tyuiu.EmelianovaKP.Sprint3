using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EmelianovaKP.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int count = 0;
            int max_count = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
                    ++count;
                } else
                {
                    if (count > max_count)
                    {
                        max_count = count;
                    }

                    count = 0;
                }
            }

            return max_count;
        }
    }
}
