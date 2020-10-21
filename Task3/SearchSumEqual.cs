using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class SearchSumEqual
    {
        public static int Get(double[] array)
        {
            // принемает значния номера 
            int number = -1;
            for (int i = 1; i < array.Count(); i++)
            {
                //сумма до числа 
                double sumBefore = 0;
                //сумма после числа 
                double sumAfter = 0;
                // считаем сумму после 
                for (int j = i + 1; j < array.Count(); j++)
                {
                    sumAfter += array[j];
                }
                //счиатем сумму после 
                for (int k = 0; k < i; k++)
                {
                    sumBefore += array[k];
                }
                // сравниваем обе суммы если совпадают до number изменяем на текуший индекс числа и выходим из цикла 
                if (sumBefore == sumAfter)
                {
                    number = i;
                    break;
                }
            }
            return number;
        }
    }
}
