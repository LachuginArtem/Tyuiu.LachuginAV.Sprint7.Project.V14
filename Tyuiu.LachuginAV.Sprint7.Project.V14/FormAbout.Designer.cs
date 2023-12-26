
using System;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormAbout
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
            this.pictureBoxInfo_LAV = new System.Windows.Forms.PictureBox();
            this.labelInfo_LAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxInfo_LAV
            // 
            this.pictureBoxInfo_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources._2023_12_26_20_17_59;
            this.pictureBoxInfo_LAV.Location = new System.Drawing.Point(12, 8);
            this.pictureBoxInfo_LAV.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxInfo_LAV.Name = "pictureBoxInfo_LAV";
            this.pictureBoxInfo_LAV.Size = new System.Drawing.Size(192, 256);
            this.pictureBoxInfo_LAV.TabIndex = 0;
            this.pictureBoxInfo_LAV.TabStop = false;
            // 
            // labelInfo_LAV
            // 
            this.labelInfo_LAV.AutoSize = true;
            this.labelInfo_LAV.Location = new System.Drawing.Point(234, 9);
            this.labelInfo_LAV.Name = "labelInfo_LAV";
            this.labelInfo_LAV.Size = new System.Drawing.Size(284, 91);
            this.labelInfo_LAV.TabIndex = 2;
            this.labelInfo_LAV.Text = "Разработчик: Лачугин А.В.\r\nгруппа АСОиУБ-23-3\r\n\r\nПрограмма разработана в рамках изучен" +
    "ия языка C#\r\n\r\nТюменский индустриальный университет (с) 2023\r\nВысшая школа цифро" +
    "вых технологий (с) 2023\r\n";
            this.labelInfo_LAV.Click += new System.EventHandler(this.labelInfo_LAV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 292);
            this.Controls.Add(this.labelInfo_LAV);
            this.Controls.Add(this.pictureBoxInfo_LAV);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_LAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_LAV;
        private System.Windows.Forms.Label labelInfo_LAV;
    }
}