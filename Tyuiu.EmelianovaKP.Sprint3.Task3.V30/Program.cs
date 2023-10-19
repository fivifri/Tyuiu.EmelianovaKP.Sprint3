using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint3.Task3.V30.Lib;

namespace Tyuiu.EmelianovaKP.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Емельянова К. П. | ПКТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Емельянова К. П. | ПКТб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
            Console.WriteLine("* находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string str = "fyyklbtyn ygrc vfyyyyh";
            char c = 'y';
            Console.WriteLine("Исходная строка = " + str);
            Console.WriteLine("Искомый символ = " + c);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetMaxCharCount(str, c));

            Console.ReadKey();
        }
    }
}
