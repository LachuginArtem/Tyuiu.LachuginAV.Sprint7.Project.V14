using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LachuginAV.Sprint7.Project.V14.Lib;
using System.IO;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    public partial class FormLibrary : Form
    {
        public FormLibrary()
        {
            InitializeComponent();

            openFileDialogLibrary_LAV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogLibrary_LAV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        public static object[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            object[,] arrayValues = new object[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonSaleSort_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.SaleSort(LoadFromFileData(filePath: OpenFilePath));


                this.chartStatistics_LAV.ChartAreas[0].AxisX.Title = "Маршрут";
                this.chartStatistics_LAV.ChartAreas[0].AxisY.Title = "Места";

                chartStatistics_LAV.Series[0].Points.Clear();

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewResult_LAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }

                    chartStatistics_LAV.Series[0].Points.AddXY(r, arrayValues[r, 3]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_LAV_Click(Object sender, EventArgs e)
        {
            openFileDialogLibrary_LAV.ShowDialog();
            OpenFilePath = openFileDialogLibrary_LAV.FileName;

            object[,] arrayValues = new object[rows, columns];

            arrayValues = LoadFromFileData(OpenFilePath);

            dataGridViewInPut_LAV.ColumnCount = columns;
            dataGridViewInPut_LAV.RowCount = rows;

            dataGridViewResult_LAV.ColumnCount = columns;
            dataGridViewResult_LAV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_LAV.Columns[i].Width = 100;
                dataGridViewResult_LAV.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_LAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }


        }

        private void buttonYearSort_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartStatistics_LAV.ChartAreas[0].AxisX.Title = "Ожидание";
                this.chartStatistics_LAV.ChartAreas[0].AxisY.Title = "Маршрут";

                chartStatistics_LAV.Series[0].Points.Clear();

                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.YearSort(LoadFromFileData(filePath: OpenFilePath));

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewResult_LAV.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                    chartStatistics_LAV.Series[0].Points.AddXY(r, arrayValues[r, 2]);

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_LAV.Text);

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: OpenFilePath), targetElement);

                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_LAV.Rows[0].Cells[c].Value = arrayValues[c];
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStat_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(textBoxCommand_LAV.Text);
                int columnIndex = Convert.ToInt32(textBoxColumnNum_LAV.Text) - 1;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(filePath: OpenFilePath);

                textBoxResult_LAV.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_LAV_Click(object sender, EventArgs e)
        {
            saveFileDialogLibrary_LAV.FileName = "OutPutFileProjectV14.csv";
            saveFileDialogLibrary_LAV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogLibrary_LAV.ShowDialog();

            string path = saveFileDialogLibrary_LAV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_LAV.RowCount;
            int columns = dataGridViewResult_LAV.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewResult_LAV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_LAV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSaleSort_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void buttonYearSort_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void buttonSearch_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void buttonStatistics_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void buttonOpenFile_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void buttonSaveFile_LAV_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_LAV.ToolTipTitle = "Подсказка";
        }

        private void labelSort_LAV_Click(object sender, EventArgs e)
        {

        }

        private void labelSearch_LAV_Click(object sender, EventArgs e)
        {

        }

        private void labelColumn_LAV_Click(object sender, EventArgs e)
        {

        }

        private void labelCommand_LAV_Click(object sender, EventArgs e)
        {

        }

        private void textBoxColumnNum_LAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewInPut_LAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}