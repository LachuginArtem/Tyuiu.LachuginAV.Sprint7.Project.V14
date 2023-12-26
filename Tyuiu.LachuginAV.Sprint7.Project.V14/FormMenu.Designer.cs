
namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    partial class FormMenu
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonInfo_LAV = new System.Windows.Forms.Button();
            this.buttonLibrary_LAV = new System.Windows.Forms.Button();
            this.buttonTask_LAV = new System.Windows.Forms.Button();
            this.toolTipMenu_LAV = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonInfo_LAV
            // 
            this.buttonInfo_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonInfo_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.help;
            this.buttonInfo_LAV.Location = new System.Drawing.Point(223, 30);
            this.buttonInfo_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo_LAV.Name = "buttonInfo_LAV";
            this.buttonInfo_LAV.Size = new System.Drawing.Size(85, 45);
            this.buttonInfo_LAV.TabIndex = 0;
            this.toolTipMenu_LAV.SetToolTip(this.buttonInfo_LAV, "Информация о проекте");
            this.buttonInfo_LAV.UseVisualStyleBackColor = false;
            this.buttonInfo_LAV.Click += new System.EventHandler(this.buttonInfo_LAV_Click);
            // 
            // buttonLibrary_LAV
            // 
            this.buttonLibrary_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonLibrary_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.book_open;
            this.buttonLibrary_LAV.Location = new System.Drawing.Point(223, 101);
            this.buttonLibrary_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLibrary_LAV.Name = "buttonLibrary_LAV";
            this.buttonLibrary_LAV.Size = new System.Drawing.Size(85, 45);
            this.buttonLibrary_LAV.TabIndex = 1;
            this.toolTipMenu_LAV.SetToolTip(this.buttonLibrary_LAV, "Библиотека");
            this.buttonLibrary_LAV.UseVisualStyleBackColor = false;
            this.buttonLibrary_LAV.Click += new System.EventHandler(this.buttonLibrary_LAV_Click);
            // 
            // buttonTask_LAV
            // 
            this.buttonTask_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonTask_LAV.Image = global::Tyuiu.LachuginAV.Sprint7.Project.V14.Properties.Resources.layout;
            this.buttonTask_LAV.Location = new System.Drawing.Point(223, 173);
            this.buttonTask_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTask_LAV.Name = "buttonTask_LAV";
            this.buttonTask_LAV.Size = new System.Drawing.Size(85, 45);
            this.buttonTask_LAV.TabIndex = 2;
            this.toolTipMenu_LAV.SetToolTip(this.buttonTask_LAV, "Техническое задание");
            this.buttonTask_LAV.UseVisualStyleBackColor = false;
            this.buttonTask_LAV.Click += new System.EventHandler(this.buttonTask_LAV_Click);
            // 
            // toolTipMenu_LAV
            // 
            this.toolTipMenu_LAV.IsBalloon = true;
            this.toolTipMenu_LAV.ToolTipTitle = "Подсказка";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(532, 282);
            this.Controls.Add(this.buttonTask_LAV);
            this.Controls.Add(this.buttonLibrary_LAV);
            this.Controls.Add(this.buttonInfo_LAV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonInfo_LAV;
        private System.Windows.Forms.Button buttonLibrary_LAV;
        private System.Windows.Forms.Button buttonTask_LAV;
        private System.Windows.Forms.ToolTip toolTipMenu_LAV;
    }
}