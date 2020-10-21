using NUnit.Framework;
using System.Collections.Generic;

namespace Task6Tests
{
    public class Tests
    {
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        public List<int> CheckFilterDigit(int[] array, int num)
        {
            return Task6.Filter.FilterDigit(array, num);
        }
    }
}