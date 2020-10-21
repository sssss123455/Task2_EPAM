using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    public class Filter
    {
        public static List<int> FilterDigit(int[] array, int num)
        {

            List<int> answer = new List<int>();
            // поиск чисел из массива которые равны num
            foreach (var item in array)
            {
                string text = item.ToString();
                int length = text.Length;
                for (int i = 0; i < length; i++)
                {
                    if (int.Parse(text[i].ToString()) == num)
                    {
                        answer.Add(item);
                    }
                }
            }
            return answer;
        }
    }
}
