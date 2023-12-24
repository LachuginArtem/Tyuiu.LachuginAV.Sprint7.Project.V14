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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonOpen_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_LAV.ShowDialog();
                openFilePath = openFileDialog_LAV.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_LAV.RowCount = rows + 1;
                dataGridView_LAV.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_LAV.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_LAV.AutoResizeColumns();
                dataGridView_LAV.ScrollBars = ScrollBars.Both;
                buttonSave_LAV.Enabled = true;
                buttonAdd_LAV.Enabled = true;
                buttonDelete_LAV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_LAV.FileName = ".csv";
                saveFileDialog_LAV.InitialDirectory = @":L";
                if (saveFileDialog_LAV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_LAV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridView_LAV.RowCount;
                    int columns = dataGridView_LAV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridView_LAV.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_LAV.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_LAV_Click(object sender, EventArgs e)
        {
            if (dataGridView_LAV.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridView_LAV.CurrentCell.RowIndex;
                    dataGridView_LAV.Rows.Remove(dataGridView_LAV.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxBus_LAV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueFilt = comboBoxBus_LAV.SelectedItem.ToString(); //извлечение строкового значения выбранного элемента ComboBox
            if (!string.IsNullOrEmpty(valueFilt))
            {
                foreach (DataGridViewRow row in dataGridView_LAV.Rows)
                {
                    if (!row.IsNewRow) // проверка новая ли строка
                    {
                        if (row.Cells["Number_CSR"].Value != null && row.Cells["Number_CSR"].Value.ToString() == valueFilt)
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void buttonHelp_LAV_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}