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

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        

        private void 办公ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"E:\tools\visual\WindowsFormsApp1\work.txt";
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnentersystem_Click(object sender, EventArgs e)
        {
            frmshow fs = new frmshow();
            fs.Show();
        }
    }
}
