using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AlexandrovaEA.Sprint4.Task2.V5.Lib;

namespace Tyuiu.AlexandrovaEA.Sprint4.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
            var res = ds.Calculate(array);
            Assert.AreEqual(32, res);
        }
    }
}
