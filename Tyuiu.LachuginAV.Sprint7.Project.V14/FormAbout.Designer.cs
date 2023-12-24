
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
            this.pictureBoxAvatar_LAV = new System.Windows.Forms.PictureBox();
            this.buttonOK_LAV = new System.Windows.Forms.Button();
            this.labelInfo_LAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_LAV
            // 
 
            this.pictureBoxAvatar_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxAvatar_LAV.Name = "pictureBoxAvatar_LAV";
            this.pictureBoxAvatar_LAV.Size = new System.Drawing.Size(112, 162);
            this.pictureBoxAvatar_LAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_LAV.TabIndex = 0;
            this.pictureBoxAvatar_LAV.TabStop = false;
            // 
            // buttonOK_LAV
            // 
            this.buttonOK_LAV.Location = new System.Drawing.Point(285, 132);
            this.buttonOK_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK_LAV.Name = "buttonOK_LAV";
            this.buttonOK_LAV.Size = new System.Drawing.Size(112, 41);
            this.buttonOK_LAV.TabIndex = 1;
            this.buttonOK_LAV.Text = "OK";
            this.buttonOK_LAV.UseVisualStyleBackColor = true;
            this.buttonOK_LAV.Click += new System.EventHandler(this.buttonOK_LAV_Click);
            // 
            // labelInfo_LAV
            // 
            this.labelInfo_LAV.AutoSize = true;
            this.labelInfo_LAV.Location = new System.Drawing.Point(126, 10);
            this.labelInfo_LAV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo_LAV.Name = "labelInfo_LAV";
            this.labelInfo_LAV.Size = new System.Drawing.Size(284, 91);
            this.labelInfo_LAV.TabIndex = 2;
            this.labelInfo_LAV.Text = "Разработчик: Лачугин.А.В\r\nгруппа АСОиУЬ-23-3\r\n\r\nПрограмма разработана в рамках из" +
    "учения языка С#\r\n\r\nТюменский индустриальный университет (с)2023\r\nВысшая школа ци" +
    "фровых технологий (с)2023\r\n";
        
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 188);
            this.Controls.Add(this.labelInfo_LAV);
            this.Controls.Add(this.buttonOK_LAV);
            this.Controls.Add(this.pictureBoxAvatar_LAV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(424, 227);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_LAV;
        private System.Windows.Forms.Button buttonOK_LAV;
        private System.Windows.Forms.Label labelInfo_LAV;
    }
}