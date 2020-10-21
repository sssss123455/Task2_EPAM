using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task4
{
    public class CombinTwoString
    {
        public static string Get(string first, string second)
        {
            //объединям два массива убираем повторяющиеся
            string text = new string(first.ToArray().Union(second.ToArray()).Distinct().ToArray());
            return text;
        }
    }
}
