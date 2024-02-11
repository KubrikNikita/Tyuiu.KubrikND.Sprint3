using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.005;
            Assert.AreEqual(wait, res);


        }
    }
}
