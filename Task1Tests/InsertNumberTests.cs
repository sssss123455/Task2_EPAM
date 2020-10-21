using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Tests
{
    [TestClass()]
    public class InsertNumberTests
    {
        [TestMethod()]
        public void GetTest()
        {
            int firstNum = 15;
            int secondNum = 15;
            int i = 0;
            int j = 0;
            int expected = 15;
            int actual = InsertNumber.Get(firstNum, secondNum, i, j);
            Assert.AreEqual(expected, actual);
        }
    }
}