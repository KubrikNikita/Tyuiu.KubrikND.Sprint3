using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint3.Task5.V17.Lib;
namespace Tyuiu.KubrikND.Sprint3.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startvalue1 = 1;
            int stopvalue1 = 3;
            int startvalue2 = 1;
            int stopvalue2 = 12;
            double res = ds.GetSumSumSeries(x, startvalue1, stopvalue1, startvalue2, stopvalue2);
            double wait = 38.124;
            Assert.AreEqual(wait, res);
        }
    }
}
