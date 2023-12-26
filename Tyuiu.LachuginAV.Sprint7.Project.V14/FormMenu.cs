using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.LachuginAV.Sprint7.Project.V14
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonInfo_LAV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonLibrary_LAV_Click(object sender, EventArgs e)
        {
            FormLibrary formLibrary = new FormLibrary();
            formLibrary.ShowDialog();
        }

        private void buttonTask_LAV_Click(object sender, EventArgs e)
        {
            FormTask formTask = new FormTask();
            formTask.ShowDialog();
        }
    }
}