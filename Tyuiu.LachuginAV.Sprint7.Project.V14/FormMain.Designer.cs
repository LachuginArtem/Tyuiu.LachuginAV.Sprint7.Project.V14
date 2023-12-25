
using System;
using System.Windows.Forms;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormMain
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
            this.panelTop_LAV = new System.Windows.Forms.Panel();
            this.buttonHelp_LAV = new System.Windows.Forms.Button();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.panelLeft_LAV = new System.Windows.Forms.Panel();
            this.groupBoxBus_LAV = new System.Windows.Forms.GroupBox();
            this.comboBoxBus_LAV = new System.Windows.Forms.ComboBox();
            this.buttonDelete_LAV = new System.Windows.Forms.Button();
            this.buttonAdd_LAV = new System.Windows.Forms.Button();
            this.buttonSave_LAV = new System.Windows.Forms.Button();
            this.buttonOpen_LAV = new System.Windows.Forms.Button();
            this.panelRight_LAV = new System.Windows.Forms.Panel();
            this.dataGridView_LAV = new System.Windows.Forms.DataGridView();
            this.toolTip_LAV = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_LAV = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_LAV = new System.Windows.Forms.SaveFileDialog();
            this.ColumnNumber_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEnd_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBus_LAV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop_LAV.SuspendLayout();
            this.panelLeft_LAV.SuspendLayout();
            this.groupBoxBus_LAV.SuspendLayout();
            this.panelRight_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_LAV
            // 
            this.panelTop_LAV.Controls.Add(this.buttonHelp_LAV);
            this.panelTop_LAV.Controls.Add(this.textBoxTask_LAV);
            this.panelTop_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_LAV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop_LAV.Name = "panelTop_LAV";
            this.panelTop_LAV.Size = new System.Drawing.Size(600, 85);
            this.panelTop_LAV.TabIndex = 0;
            // 
            // buttonHelp_LAV
            // 
            this.buttonHelp_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.help;
            this.buttonHelp_LAV.Location = new System.Drawing.Point(0, 0);
            this.buttonHelp_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_LAV.Name = "buttonHelp_LAV";
            this.buttonHelp_LAV.Size = new System.Drawing.Size(61, 48);
            this.buttonHelp_LAV.TabIndex = 1;
            this.toolTip_LAV.SetToolTip(this.buttonHelp_LAV, "Сведения о программе");
            this.buttonHelp_LAV.UseVisualStyleBackColor = true;
            this.buttonHelp_LAV.Click += new System.EventHandler(this.buttonHelp_LAV_Click);
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_LAV.Location = new System.Drawing.Point(87, 37);
            this.textBoxTask_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.Size = new System.Drawing.Size(430, 21);
            this.textBoxTask_LAV.TabIndex = 0;
            this.textBoxTask_LAV.TabStop = false;
            this.textBoxTask_LAV.Text = "Тюменская Транспортная Система";
            this.textBoxTask_LAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelLeft_LAV
            // 
            this.panelLeft_LAV.Controls.Add(this.groupBoxBus_LAV);
            this.panelLeft_LAV.Controls.Add(this.buttonDelete_LAV);
            this.panelLeft_LAV.Controls.Add(this.buttonAdd_LAV);
            this.panelLeft_LAV.Controls.Add(this.buttonSave_LAV);
            this.panelLeft_LAV.Controls.Add(this.buttonOpen_LAV);
            this.panelLeft_LAV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_LAV.Location = new System.Drawing.Point(0, 85);
            this.panelLeft_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft_LAV.Name = "panelLeft_LAV";
            this.panelLeft_LAV.Size = new System.Drawing.Size(166, 281);
            this.panelLeft_LAV.TabIndex = 1;
            // 
            // groupBoxBus_LAV
            // 
            this.groupBoxBus_LAV.Controls.Add(this.comboBoxBus_LAV);
            this.groupBoxBus_LAV.Location = new System.Drawing.Point(8, 128);
            this.groupBoxBus_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxBus_LAV.Name = "groupBoxBus_LAV";
            this.groupBoxBus_LAV.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxBus_LAV.Size = new System.Drawing.Size(154, 41);
            this.groupBoxBus_LAV.TabIndex = 4;
            this.groupBoxBus_LAV.TabStop = false;
            this.groupBoxBus_LAV.Text = "Выбор маршрута:";
            // 
            // comboBoxBus_LAV
            // 
            this.comboBoxBus_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxBus_LAV.FormattingEnabled = true;
            this.comboBoxBus_LAV.Location = new System.Drawing.Point(2, 15);
            this.comboBoxBus_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBus_LAV.Name = "comboBoxBus_LAV";
            this.comboBoxBus_LAV.Size = new System.Drawing.Size(150, 21);
            this.comboBoxBus_LAV.TabIndex = 0;
            this.comboBoxBus_LAV.SelectedIndexChanged += new System.EventHandler(this.comboBoxBus_LAV_SelectedIndexChanged);
            // 
            // buttonDelete_LAV
            // 
            this.buttonDelete_LAV.BackgroundImage = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.table_row_delete;
            this.buttonDelete_LAV.Location = new System.Drawing.Point(11, 11);
            this.buttonDelete_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete_LAV.Name = "buttonDelete_LAV";
            this.buttonDelete_LAV.Size = new System.Drawing.Size(34, 34);
            this.buttonDelete_LAV.TabIndex = 3;
            this.toolTip_LAV.SetToolTip(this.buttonDelete_LAV, "Удаление строки");
            this.buttonDelete_LAV.UseVisualStyleBackColor = true;
            this.buttonDelete_LAV.Click += new System.EventHandler(this.buttonDelete_LAV_Click);
            // 
            // buttonAdd_LAV
            // 
            this.buttonAdd_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.table_row_insert;
            this.buttonAdd_LAV.Location = new System.Drawing.Point(10, 49);
            this.buttonAdd_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd_LAV.Name = "buttonAdd_LAV";
            this.buttonAdd_LAV.Size = new System.Drawing.Size(35, 35);
            this.buttonAdd_LAV.TabIndex = 2;
            this.toolTip_LAV.SetToolTip(this.buttonAdd_LAV, "Добавление строки");
            this.buttonAdd_LAV.UseVisualStyleBackColor = true;
            this.buttonAdd_LAV.Click += new System.EventHandler(this.buttonAdd_LAV_Click);
            // 
            // buttonSave_LAV
            // 
            this.buttonSave_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.database_save;
            this.buttonSave_LAV.Location = new System.Drawing.Point(115, 65);
            this.buttonSave_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave_LAV.Name = "buttonSave_LAV";
            this.buttonSave_LAV.Size = new System.Drawing.Size(45, 45);
            this.buttonSave_LAV.TabIndex = 1;
            this.toolTip_LAV.SetToolTip(this.buttonSave_LAV, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_LAV.UseVisualStyleBackColor = true;
            this.buttonSave_LAV.Click += new System.EventHandler(this.buttonSave_LAV_Click);
            // 
            // buttonOpen_LAV
            // 
            this.buttonOpen_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.book_open;
            this.buttonOpen_LAV.Location = new System.Drawing.Point(115, 11);
            this.buttonOpen_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_LAV.Name = "buttonOpen_LAV";
            this.buttonOpen_LAV.Size = new System.Drawing.Size(45, 43);
            this.buttonOpen_LAV.TabIndex = 0;
            this.toolTip_LAV.SetToolTip(this.buttonOpen_LAV, "Открыть файл\r\nВыберите нужный файл для обработки ");
            this.buttonOpen_LAV.UseVisualStyleBackColor = true;
            this.buttonOpen_LAV.Click += new System.EventHandler(this.buttonOpen_LAV_Click);
            // 
            // panelRight_LAV
            // 
            this.panelRight_LAV.Controls.Add(this.dataGridView_LAV);
            this.panelRight_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_LAV.Location = new System.Drawing.Point(166, 85);
            this.panelRight_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight_LAV.Name = "panelRight_LAV";
            this.panelRight_LAV.Size = new System.Drawing.Size(434, 281);
            this.panelRight_LAV.TabIndex = 2;
            // 
            // dataGridView_LAV
            // 
            this.dataGridView_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_LAV,
            this.ColumnStart_LAV,
            this.ColumnEnd_LAV,
            this.ColumnBus_LAV});
            this.dataGridView_LAV.Location = new System.Drawing.Point(3, 5);
            this.dataGridView_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_LAV.Name = "dataGridView_LAV";
            this.dataGridView_LAV.RowHeadersVisible = false;
            this.dataGridView_LAV.RowHeadersWidth = 51;
            this.dataGridView_LAV.RowTemplate.Height = 24;
            this.dataGridView_LAV.Size = new System.Drawing.Size(430, 276);
            this.dataGridView_LAV.TabIndex = 0;
            this.dataGridView_LAV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_LAV_CellContentClick);
            // 
            // toolTip_LAV
            // 
            this.toolTip_LAV.ToolTipTitle = "Справка";
            // 
            // openFileDialog_LAV
            // 
            this.openFileDialog_LAV.FileName = "openFileDialog1";
            // 
            // ColumnNumber_LAV
            // 
            this.ColumnNumber_LAV.HeaderText = "Номер маршрута";
            this.ColumnNumber_LAV.MinimumWidth = 6;
            this.ColumnNumber_LAV.Name = "ColumnNumber_LAV";
            this.ColumnNumber_LAV.Width = 125;
            // 
            // ColumnStart_LAV
            // 
            this.ColumnStart_LAV.HeaderText = "Вид транспорта";
            this.ColumnStart_LAV.MinimumWidth = 6;
            this.ColumnStart_LAV.Name = "ColumnStart_LAV";
            this.ColumnStart_LAV.Width = 125;
            // 
            // ColumnEnd_LAV
            // 
            this.ColumnEnd_LAV.HeaderText = "Начало маршрута";
            this.ColumnEnd_LAV.MinimumWidth = 6;
            this.ColumnEnd_LAV.Name = "ColumnEnd_LAV";
            this.ColumnEnd_LAV.Width = 125;
            // 
            // ColumnBus_LAV
            // 
            this.ColumnBus_LAV.HeaderText = "Конец маршрута";
            this.ColumnBus_LAV.MinimumWidth = 6;
            this.ColumnBus_LAV.Name = "ColumnBus_LAV";
            this.ColumnBus_LAV.Width = 125;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelRight_LAV);
            this.Controls.Add(this.panelLeft_LAV);
            this.Controls.Add(this.panelTop_LAV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 14 |Лачугин А.В.";
            this.panelTop_LAV.ResumeLayout(false);
            this.panelTop_LAV.PerformLayout();
            this.panelLeft_LAV.ResumeLayout(false);
            this.groupBoxBus_LAV.ResumeLayout(false);
            this.panelRight_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LAV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_LAV;
        private System.Windows.Forms.Button buttonHelp_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
        private System.Windows.Forms.Panel panelLeft_LAV;
        private System.Windows.Forms.GroupBox groupBoxBus_LAV;
        private System.Windows.Forms.ComboBox comboBoxBus_LAV;
        private System.Windows.Forms.Button buttonDelete_LAV;
        private System.Windows.Forms.Button buttonAdd_LAV;
        private System.Windows.Forms.Button buttonSave_LAV;
        private System.Windows.Forms.Button buttonOpen_LAV;
        private System.Windows.Forms.Panel panelRight_LAV;
        private System.Windows.Forms.DataGridView dataGridView_LAV;
        private System.Windows.Forms.ToolTip toolTip_LAV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LAV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_LAV;
        private DataGridViewTextBoxColumn ColumnNumber_LAV;
        private DataGridViewTextBoxColumn ColumnStart_LAV;
        private DataGridViewTextBoxColumn ColumnEnd_LAV;
        private DataGridViewTextBoxColumn ColumnBus_LAV;
    }
}