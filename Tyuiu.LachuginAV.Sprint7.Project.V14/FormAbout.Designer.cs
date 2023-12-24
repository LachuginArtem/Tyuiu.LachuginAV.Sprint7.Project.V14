
namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormAbout_LAV
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
            this.buttonOK_LAV = new System.Windows.Forms.Button();
            this.label_LAV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK_LAV
            // 
            this.buttonOK_LAV.Location = new System.Drawing.Point(203, 83);
            this.buttonOK_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK_LAV.Name = "buttonOK_LAV";
            this.buttonOK_LAV.Size = new System.Drawing.Size(74, 32);
            this.buttonOK_LAV.TabIndex = 0;
            this.buttonOK_LAV.Text = "OK";
            this.buttonOK_LAV.UseVisualStyleBackColor = true;
            this.buttonOK_LAV.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_LAV
            // 
            this.label_LAV.AutoSize = true;
            this.label_LAV.Location = new System.Drawing.Point(9, 7);
            this.label_LAV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LAV.Name = "label_LAV";
            this.label_LAV.Size = new System.Drawing.Size(248, 39);
            this.label_LAV.TabIndex = 1;
            this.label_LAV.Text = "Проект выполнил студент группы АСОиУБ-23-3\r\nЛачугин А.В.\r\n\r\n";
            // 
            // FormAbout_LAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 124);
            this.Controls.Add(this.label_LAV);
            this.Controls.Add(this.buttonOK_LAV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAbout_LAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_LAV;
        private System.Windows.Forms.Label label_LAV;
    }
}