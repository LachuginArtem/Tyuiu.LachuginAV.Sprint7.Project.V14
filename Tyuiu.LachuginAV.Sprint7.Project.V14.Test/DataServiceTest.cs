using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LachuginAV.Sprint7.Project.V14.Lib;
using System.IO;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Начало маршрута; Конец маршрута");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}