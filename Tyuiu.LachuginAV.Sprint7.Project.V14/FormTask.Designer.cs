
namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.groupBoxTask_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.groupBoxTask_LAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_LAV
            // 
            this.groupBoxTask_LAV.Controls.Add(this.textBoxTask_LAV);
            this.groupBoxTask_LAV.Location = new System.Drawing.Point(8, 8);
            this.groupBoxTask_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask_LAV.Name = "groupBoxTask_LAV";
            this.groupBoxTask_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxTask_LAV.Size = new System.Drawing.Size(517, 172);
            this.groupBoxTask_LAV.TabIndex = 0;
            this.groupBoxTask_LAV.TabStop = false;
            this.groupBoxTask_LAV.Text = "Вариант 14";
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.Location = new System.Drawing.Point(4, 16);
            this.textBoxTask_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.ReadOnly = true;
            this.textBoxTask_LAV.Size = new System.Drawing.Size(511, 152);
            this.textBoxTask_LAV.TabIndex = 0;
            this.textBoxTask_LAV.Text = resources.GetString("textBoxTask_LAV.Text");
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 183);
            this.Controls.Add(this.groupBoxTask_LAV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTask";
            this.Text = "Техническое задание";
            this.groupBoxTask_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
    }
}