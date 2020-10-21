using NUnit.Framework;
using System;

namespace Task3Tests
{
    public class Tests
    {


        [TestCase(new double[]{ 12, 21.22, 23.344, 5555.4, 12, 21.22, 23.344 },ExpectedResult =3)]
        public int CheckSearchSumEqual(double[] array)
        {
            return Task3.SearchSumEqual.Get(array);
        }
    }
}