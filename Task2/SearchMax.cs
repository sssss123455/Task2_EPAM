using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    public class SearchMax
    {

        public static int Get(int[] array)
        {
            // maxNum изночально принимает значение первого элемента из массива
            int maxNum = array[0];
            // а тут уже идет поиск через сравнения 
            for (int i = 1; i < array.Count(); i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];
                }
            }
            return maxNum;
        }
    }
}
