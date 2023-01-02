using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "admin" && txtpwd.Text == "admin")
            {
                MessageBox.Show("登录成功", "用户登录", MessageBoxButtons.OKCancel);
                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("用户名或密码错误", "用户登录", MessageBoxButtons.OKCancel);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
