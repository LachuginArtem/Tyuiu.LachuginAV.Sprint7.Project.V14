
namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormMain_LAV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelButtons_LAV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_LAV = new System.Windows.Forms.GroupBox();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.panelOutPut_LAV = new System.Windows.Forms.Panel();
            this.groupBoxButtons_LAV = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_LAV = new System.Windows.Forms.DataGridView();
            this.ColumnNumber_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStop_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1_LAV = new System.Windows.Forms.Splitter();
            this.panelDiagram_LAV = new System.Windows.Forms.Panel();
            this.chartDiagram_LAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter2_LAV = new System.Windows.Forms.Splitter();
            this.panelInfo_LAV = new System.Windows.Forms.Panel();
            this.labelMin_LAV = new System.Windows.Forms.Label();
            this.labelMax_LAV = new System.Windows.Forms.Label();
            this.labelAverage_LAV = new System.Windows.Forms.Label();
            this.textBoxMin_LAV = new System.Windows.Forms.TextBox();
            this.textBoxMax_LAV = new System.Windows.Forms.TextBox();
            this.textBoxAverage_LAV = new System.Windows.Forms.TextBox();
            this.toolTip_LAV = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_LAV = new System.Windows.Forms.Button();
            this.panelButtons_LAV.SuspendLayout();
            this.groupBoxOutPut_LAV.SuspendLayout();
            this.panelOutPut_LAV.SuspendLayout();
            this.groupBoxButtons_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_LAV)).BeginInit();
            this.panelDiagram_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_LAV)).BeginInit();
            this.panelInfo_LAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_LAV
            // 
            this.panelButtons_LAV.Controls.Add(this.groupBoxOutPut_LAV);
            this.panelButtons_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LAV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelButtons_LAV.Name = "panelButtons_LAV";
            this.panelButtons_LAV.Size = new System.Drawing.Size(888, 81);
            this.panelButtons_LAV.TabIndex = 0;
            // 
            // groupBoxOutPut_LAV
            // 
            this.groupBoxOutPut_LAV.Controls.Add(this.buttonInfo_LAV);
            this.groupBoxOutPut_LAV.Controls.Add(this.buttonDone_LAV);
            this.groupBoxOutPut_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LAV.Name = "groupBoxOutPut_LAV";
            this.groupBoxOutPut_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LAV.Size = new System.Drawing.Size(888, 81);
            this.groupBoxOutPut_LAV.TabIndex = 0;
            this.groupBoxOutPut_LAV.TabStop = false;
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.control_play_blue;
            this.buttonDone_LAV.Location = new System.Drawing.Point(4, 10);
            this.buttonDone_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(65, 67);
            this.buttonDone_LAV.TabIndex = 0;
            this.toolTip_LAV.SetToolTip(this.buttonDone_LAV, "Вывести маршруты");
            this.buttonDone_LAV.UseVisualStyleBackColor = true;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            // 
            // panelOutPut_LAV
            // 
            this.panelOutPut_LAV.Controls.Add(this.groupBoxButtons_LAV);
            this.panelOutPut_LAV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_LAV.Location = new System.Drawing.Point(0, 81);
            this.panelOutPut_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOutPut_LAV.Name = "panelOutPut_LAV";
            this.panelOutPut_LAV.Size = new System.Drawing.Size(444, 375);
            this.panelOutPut_LAV.TabIndex = 1;
            // 
            // groupBoxButtons_LAV
            // 
            this.groupBoxButtons_LAV.Controls.Add(this.dataGridViewData_LAV);
            this.groupBoxButtons_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtons_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButtons_LAV.Name = "groupBoxButtons_LAV";
            this.groupBoxButtons_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxButtons_LAV.Size = new System.Drawing.Size(444, 375);
            this.groupBoxButtons_LAV.TabIndex = 0;
            this.groupBoxButtons_LAV.TabStop = false;
            this.groupBoxButtons_LAV.Text = "Вывод";
            // 
            // dataGridViewData_LAV
            // 
            this.dataGridViewData_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_LAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_LAV,
            this.ColumnType_LAV,
            this.ColumnStart_LAV,
            this.ColumnStop_LAV});
            this.dataGridViewData_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_LAV.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewData_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewData_LAV.Name = "dataGridViewData_LAV";
            this.dataGridViewData_LAV.ReadOnly = true;
            this.dataGridViewData_LAV.RowHeadersVisible = false;
            this.dataGridViewData_LAV.RowHeadersWidth = 51;
            this.dataGridViewData_LAV.RowTemplate.Height = 24;
            this.dataGridViewData_LAV.Size = new System.Drawing.Size(440, 358);
            this.dataGridViewData_LAV.TabIndex = 0;
            this.dataGridViewData_LAV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_LAV_CellContentClick);
            this.dataGridViewData_LAV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_LAV_CellContentClick);
            // 
            // ColumnNumber_LAV
            // 
            this.ColumnNumber_LAV.HeaderText = "Номер маршрута";
            this.ColumnNumber_LAV.MinimumWidth = 6;
            this.ColumnNumber_LAV.Name = "ColumnNumber_LAV";
            this.ColumnNumber_LAV.ReadOnly = true;
            this.ColumnNumber_LAV.Width = 125;
            // 
            // ColumnType_LAV
            // 
            this.ColumnType_LAV.HeaderText = "Вид транспорта";
            this.ColumnType_LAV.MinimumWidth = 6;
            this.ColumnType_LAV.Name = "ColumnType_LAV";
            this.ColumnType_LAV.ReadOnly = true;
            this.ColumnType_LAV.Width = 125;
            // 
            // ColumnStart_LAV
            // 
            this.ColumnStart_LAV.HeaderText = "Начальная остановка";
            this.ColumnStart_LAV.MinimumWidth = 6;
            this.ColumnStart_LAV.Name = "ColumnStart_LAV";
            this.ColumnStart_LAV.ReadOnly = true;
            this.ColumnStart_LAV.Width = 125;
            // 
            // ColumnStop_LAV
            // 
            this.ColumnStop_LAV.HeaderText = "Конечная остановка";
            this.ColumnStop_LAV.MinimumWidth = 6;
            this.ColumnStop_LAV.Name = "ColumnStop_LAV";
            this.ColumnStop_LAV.ReadOnly = true;
            this.ColumnStop_LAV.Width = 125;
            // 
            // splitter1_LAV
            // 
            this.splitter1_LAV.Location = new System.Drawing.Point(444, 81);
            this.splitter1_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1_LAV.Name = "splitter1_LAV";
            this.splitter1_LAV.Size = new System.Drawing.Size(2, 375);
            this.splitter1_LAV.TabIndex = 2;
            this.splitter1_LAV.TabStop = false;
            // 
            // panelDiagram_LAV
            // 
            this.panelDiagram_LAV.Controls.Add(this.chartDiagram_LAV);
            this.panelDiagram_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiagram_LAV.Location = new System.Drawing.Point(446, 81);
            this.panelDiagram_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDiagram_LAV.Name = "panelDiagram_LAV";
            this.panelDiagram_LAV.Size = new System.Drawing.Size(442, 251);
            this.panelDiagram_LAV.TabIndex = 3;
            // 
            // chartDiagram_LAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiagram_LAV.ChartAreas.Add(chartArea1);
            this.chartDiagram_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiagram_LAV.Legends.Add(legend1);
            this.chartDiagram_LAV.Location = new System.Drawing.Point(0, 0);
            this.chartDiagram_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartDiagram_LAV.Name = "chartDiagram_LAV";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SeriesDiagram_LAV";
            this.chartDiagram_LAV.Series.Add(series1);
            this.chartDiagram_LAV.Size = new System.Drawing.Size(442, 251);
            this.chartDiagram_LAV.TabIndex = 0;
            this.chartDiagram_LAV.Text = "chart1";
            // 
            // splitter2_LAV
            // 
            this.splitter2_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2_LAV.Location = new System.Drawing.Point(446, 332);
            this.splitter2_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2_LAV.Name = "splitter2_LAV";
            this.splitter2_LAV.Size = new System.Drawing.Size(442, 2);
            this.splitter2_LAV.TabIndex = 4;
            this.splitter2_LAV.TabStop = false;
            // 
            // panelInfo_LAV
            // 
            this.panelInfo_LAV.Controls.Add(this.labelMin_LAV);
            this.panelInfo_LAV.Controls.Add(this.labelMax_LAV);
            this.panelInfo_LAV.Controls.Add(this.labelAverage_LAV);
            this.panelInfo_LAV.Controls.Add(this.textBoxMin_LAV);
            this.panelInfo_LAV.Controls.Add(this.textBoxMax_LAV);
            this.panelInfo_LAV.Controls.Add(this.textBoxAverage_LAV);
            this.panelInfo_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_LAV.Location = new System.Drawing.Point(446, 334);
            this.panelInfo_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInfo_LAV.Name = "panelInfo_LAV";
            this.panelInfo_LAV.Size = new System.Drawing.Size(442, 122);
            this.panelInfo_LAV.TabIndex = 5;
            // 
            // labelMin_LAV
            // 
            this.labelMin_LAV.AutoSize = true;
            this.labelMin_LAV.Location = new System.Drawing.Point(265, 11);
            this.labelMin_LAV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMin_LAV.Name = "labelMin_LAV";
            this.labelMin_LAV.Size = new System.Drawing.Size(24, 13);
            this.labelMin_LAV.TabIndex = 2;
            this.labelMin_LAV.Text = "Min";
            // 
            // labelMax_LAV
            // 
            this.labelMax_LAV.AutoSize = true;
            this.labelMax_LAV.Location = new System.Drawing.Point(148, 11);
            this.labelMax_LAV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMax_LAV.Name = "labelMax_LAV";
            this.labelMax_LAV.Size = new System.Drawing.Size(27, 13);
            this.labelMax_LAV.TabIndex = 2;
            this.labelMax_LAV.Text = "Max";
            // 
            // labelAverage_LAV
            // 
            this.labelAverage_LAV.AutoSize = true;
            this.labelAverage_LAV.Location = new System.Drawing.Point(23, 11);
            this.labelAverage_LAV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAverage_LAV.Name = "labelAverage_LAV";
            this.labelAverage_LAV.Size = new System.Drawing.Size(111, 13);
            this.labelAverage_LAV.TabIndex = 2;
            this.labelAverage_LAV.Text = "Среднее количество";
            // 
            // textBoxMin_LAV
            // 
            this.textBoxMin_LAV.Location = new System.Drawing.Point(267, 29);
            this.textBoxMin_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMin_LAV.Name = "textBoxMin_LAV";
            this.textBoxMin_LAV.ReadOnly = true;
            this.textBoxMin_LAV.Size = new System.Drawing.Size(76, 20);
            this.textBoxMin_LAV.TabIndex = 1;
            // 
            // textBoxMax_LAV
            // 
            this.textBoxMax_LAV.Location = new System.Drawing.Point(150, 29);
            this.textBoxMax_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMax_LAV.Name = "textBoxMax_LAV";
            this.textBoxMax_LAV.ReadOnly = true;
            this.textBoxMax_LAV.Size = new System.Drawing.Size(76, 20);
            this.textBoxMax_LAV.TabIndex = 1;
            // 
            // textBoxAverage_LAV
            // 
            this.textBoxAverage_LAV.Location = new System.Drawing.Point(26, 29);
            this.textBoxAverage_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAverage_LAV.Name = "textBoxAverage_LAV";
            this.textBoxAverage_LAV.ReadOnly = true;
            this.textBoxAverage_LAV.Size = new System.Drawing.Size(76, 20);
            this.textBoxAverage_LAV.TabIndex = 1;
            // 
            // toolTip_LAV
            // 
            this.toolTip_LAV.ToolTipTitle = "Подсказка";
            // 
            // buttonInfo_LAV
            // 
            this.buttonInfo_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.help;
            this.buttonInfo_LAV.Location = new System.Drawing.Point(74, 10);
            this.buttonInfo_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_LAV.Name = "buttonInfo_LAV";
            this.buttonInfo_LAV.Size = new System.Drawing.Size(64, 67);
            this.buttonInfo_LAV.TabIndex = 1;
            this.toolTip_LAV.SetToolTip(this.buttonInfo_LAV, "О приложении");
            this.buttonInfo_LAV.UseVisualStyleBackColor = true;
            this.buttonInfo_LAV.Click += new System.EventHandler(this.buttonInfo_LAV_Click);
            // 
            // FormMain_LAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 456);
            this.Controls.Add(this.panelInfo_LAV);
            this.Controls.Add(this.splitter2_LAV);
            this.Controls.Add(this.panelDiagram_LAV);
            this.Controls.Add(this.splitter1_LAV);
            this.Controls.Add(this.panelOutPut_LAV);
            this.Controls.Add(this.panelButtons_LAV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(904, 495);
            this.Name = "FormMain_LAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 14 | Лачугин А.В";
            this.panelButtons_LAV.ResumeLayout(false);
            this.groupBoxOutPut_LAV.ResumeLayout(false);
            this.panelOutPut_LAV.ResumeLayout(false);
            this.groupBoxButtons_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_LAV)).EndInit();
            this.panelDiagram_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_LAV)).EndInit();
            this.panelInfo_LAV.ResumeLayout(false);
            this.panelInfo_LAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_LAV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.Panel panelOutPut_LAV;
        private System.Windows.Forms.GroupBox groupBoxButtons_LAV;
        private System.Windows.Forms.Splitter splitter1_LAV;
        private System.Windows.Forms.DataGridView dataGridViewData_LAV;
        private System.Windows.Forms.Panel panelDiagram_LAV;
        private System.Windows.Forms.Splitter splitter2_LAV;
        private System.Windows.Forms.Panel panelInfo_LAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_LAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber_LAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType_LAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart_LAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStop_LAV;
        private System.Windows.Forms.Label labelMin_LAV;
        private System.Windows.Forms.Label labelMax_LAV;
        private System.Windows.Forms.Label labelAverage_LAV;
        private System.Windows.Forms.TextBox textBoxMin_LAV;
        private System.Windows.Forms.TextBox textBoxMax_LAV;
        private System.Windows.Forms.TextBox textBoxAverage_LAV;
        private System.Windows.Forms.ToolTip toolTip_LAV;
        private System.Windows.Forms.Button buttonInfo_LAV;
    }
}