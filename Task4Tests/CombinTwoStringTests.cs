using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task4.Tests
{
    [TestClass()]
    public class CombinTwoStringTests
    {
        [TestMethod()]
        public void GetTest()
        {
            string first = "dsafw";
            string second = "wqewqd";
            Assert.AreEqual(CombinTwoString.Get(first,second),"dsafwqe");
        }
    }
}