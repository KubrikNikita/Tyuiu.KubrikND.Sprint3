﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint3.Task6.V2.Lib;

namespace Tyuiu.KubrikND.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 12;
            int stopValue = 18;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 178;
            Assert.AreEqual(wait, res);
        }
    }
}
