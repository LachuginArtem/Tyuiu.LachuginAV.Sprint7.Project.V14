using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint7.Project.V14.Lib;
using System.Collections.Generic;
using System.IO;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaleSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 4] {{ "Avtobus1", "Place1", 30, 500},
                                                    {"Avtobus2", "Place2", 40, 350}};

            object[,] dataWait = new object[2, 4] { { "Avtobus2", "Place2", 40, 350 },
                                                    { "Avtobus1", "Place1", 30, 500} };

            CollectionAssert.AreEqual(dataWait, ds.SaleSort(dataTest));
        }

        [TestMethod]
        public void ValidYearSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 4] {{ "Avtobus1", "Place1", "23", "10"},
                                                    {"Avtobus2", "Place2", "20", "35"}};

            object[,] dataWait = new object[2, 4] { { "Avtobus2", "Place2", "20", "35" },
                                                    { "Avtobus1", "Place1", "23", "10"} };

            CollectionAssert.AreEqual(dataWait, ds.YearSort(dataTest));
        }

        [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 3] {{"Avtobus1", "Place1", "30"},
                                                   {"Avtobus2", "Place2", "30"}};

            string[] dataWait = new string[3] { "Avtobus2", "Place2", "30" };

            CollectionAssert.AreEqual(dataWait, ds.Search(dataTest, "Avtobus2"));
        }

        [TestMethod]
        public void ValidDataStatisticsSum()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtobus1", "100"},
                                                   {"Avtobus2", "200"},
                                                   {"Avtobus3", "50"}};

            double dataWait = 350;

            string command = "sum";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMin()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtobus1", "100"},
                                                   {"Avtobus2", "200"},
                                                   {"Avtobus3", "40"}};

            double dataWait = 40;

            string command = "min";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMax()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtobus1", "100"},
                                                   {"Avtobus2", "300"},
                                                   {"Avtobus3", "50"}};

            double dataWait = 300;

            string command = "max";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsAvarage()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtobus1", "100"},
                                                   {"Avtobus2", "200"},
                                                   {"Avtobus3", "50"}};

            double dataWait = 116.67;

            string command = "avarage";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }
    }
}