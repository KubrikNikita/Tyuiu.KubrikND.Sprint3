﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint3.Task4.V26.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, startValue);
            double wait = 0.135;
            Assert.AreEqual(wait,res);
        }
    }
}
