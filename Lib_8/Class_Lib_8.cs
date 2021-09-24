using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lib_8
{
    public class Class_Lib_8
    {/// <summary>
     /// Нахождение косинуса суммы чисел < 3
     /// </summary>
     /// <param name="mas">in int[] mas - массив, элементы которого нельзя изменить из-за модификатора "in"</param>
     /// <returns>result - результат вычислений</returns>
        public static double FindCosLess3(in int[] mas)
        {
            double result, sum = 0; 
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 3) sum += mas[i]; //Нахождение суммы чисел < 3
            }
            result = Math.Cos(sum); //Нахождение косинуса
            return result;
        }
    }
}
