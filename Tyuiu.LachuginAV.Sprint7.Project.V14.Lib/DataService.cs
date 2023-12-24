using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public double Average(int[] array)
        {
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average = Math.Truncate(average / array.Length);
            return average;
        }
        public int Max(int[] array)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
            }
            return maxValue;
        }
        public int Min(int[] array)
        {
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < minValue) && (array[i] != 0))
                    minValue = array[i];
            }
            return minValue;
        }
    }
}