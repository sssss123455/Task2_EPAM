using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Tests
{
    [TestClass()]
    public class SearchMaxTests
    {
        [TestMethod()]
        public void GetTest()
        {
            int[] array = {1,3,7,5,10,-2};
            int expected = 10;
            int actual = SearchMax.Get(array);
            Assert.AreEqual(expected, actual);
        }
    }
}