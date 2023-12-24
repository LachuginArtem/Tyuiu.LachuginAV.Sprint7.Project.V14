using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.LachuginAV.Sprint7.Project.V14.Lib;


namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    public partial class FormMain_LAV : Form
    {
        public FormMain_LAV()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LAV_Click(object sender, EventArgs e)
        {
            string path = @"C:\"; 
            foreach (var line in File.ReadLines(path))
            {
                var array = line.Split(',');
                dataGridViewData_LAV.Rows.Add(array);
            }
        }

        private void dataGridViewData_LAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.chartDiagram_LAV.ChartAreas[0].AxisX.Title = "Время";
            this.chartDiagram_LAV.ChartAreas[0].AxisY.Title = "Количество автомобилей";
            chartDiagram_LAV.Series[0].Points.Clear();
            string path = @"C:\";

            int columns = 5;
            int rows = 23;

            string[] lines = File.ReadAllLines(path);
            int[,] matrix = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                int[] row = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[] array = new int[23];

            if (dataGridViewData_LAV.CurrentCell.RowIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewData_LAV.CurrentCell != null && dataGridViewData_LAV.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_LAV.Series[0].Points.AddXY(j + ":00", matrix[0, j]);
                        array[j] = matrix[0, j];
                    }
                    textBoxAverage_LAV.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_LAV.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_LAV.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_LAV.CurrentCell.RowIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridViewData_LAV.CurrentCell != null && dataGridViewData_LAV.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_LAV.Series[0].Points.AddXY(j + ":00", matrix[1, j]);
                        array[j] = matrix[1, j];
                    }
                    textBoxAverage_LAV.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_LAV.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_LAV.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_LAV.CurrentCell.RowIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridViewData_LAV.CurrentCell != null && dataGridViewData_LAV.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_LAV.Series[0].Points.AddXY(j + ":00", matrix[2, j]);
                        array[j] = matrix[2, j];
                    }
                    textBoxAverage_LAV.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_LAV.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_LAV.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_LAV.CurrentCell.RowIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridViewData_LAV.CurrentCell != null && dataGridViewData_LAV.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_LAV.Series[0].Points.AddXY(j + ":00", matrix[3, j]);
                        array[j] = matrix[3, j];
                    }
                    textBoxAverage_LAV.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_LAV.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_LAV.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_LAV.CurrentCell.RowIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dataGridViewData_LAV.CurrentCell != null && dataGridViewData_LAV.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_LAV.Series[0].Points.AddXY(j + ":00", matrix[4, j]);
                        array[j] = matrix[4, j];
                    }
                    textBoxAverage_LAV.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_LAV.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_LAV.Text = Convert.ToString(ds.Min(array));
                }
            }
        }

        private void buttonInfo_LAV_Click(object sender, EventArgs e)
        {
            FormAbout_LAV formAbout = new FormAbout_LAV();
            formAbout.ShowDialog();
        }
    }
}
