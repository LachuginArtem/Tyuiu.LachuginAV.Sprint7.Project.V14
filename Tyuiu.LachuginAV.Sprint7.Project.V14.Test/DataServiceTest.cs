using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint7.Project.V14.Lib;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public DataService ds = new DataService();

        [TestMethod]
        public void ValidAverage()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            double res = ds.Average(array);
            double wait = 3;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMax()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int res = ds.Max(array);
            int wait = 5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidMin()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int res = ds.Min(array);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}