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
    public partial class frmshow : Form
    {
        void boolcreateFile()
        {
            FileInfo fi = new FileInfo("D:\\work.txt");
            if (!fi.Exists)
            {
                fi.Create();
            }
            fi.Attributes = FileAttributes.Normal;
        }
        string createFile(string path)
        {
            if (!File.Exists(path))
            {
                StreamWriter sw = File.CreateText(path);
                sw.Close();
            }
            return path;
        }
        string boolworkorperson()
        {
            string path="";
            if (rbtnwork.Checked)
            {
                path = "./work.txt";
                path = createFile(path);
            }
            else
            {
                path = "./person.txt";
                path = createFile(path);
            }
            return path;
        }
        void printdata(string path)
        {
            StreamReader sr = new StreamReader(path);
            lsboxshow.Items.Clear();
            for (int i = 0; sr.Peek() != -1; i++)
            {
                lsboxshow.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        void dele(string path)
        {
            string temp = "" + (lsboxshow.SelectedItem);
            lsboxshow.Items.Remove(temp);
            StreamReader sr = new StreamReader(path);
            string catper = "";
            while (sr.Peek() != -1)
            {
                string rl = sr.ReadLine();
                if (rl==temp)
                {
                    catper += "";
                }
                else
                {
                    catper += rl+"\n";
                }
            }
            sr.Close();
            File.WriteAllText(path, catper);
        }
        public frmshow()
        {
            InitializeComponent();
        }
        private void frmshow_Load(object sender, EventArgs e)
        {

        }
        private void lblshow1_Click(object sender, EventArgs e)
        {
            
        }
        private void rbtnwork_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnwork.Checked)
            {
                string path=boolworkorperson();
                printdata(path);
            }
        }
        private void rbtnPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPerson.Checked)
            {
                string path = boolworkorperson();
                printdata(path);
            }
        }
        private void lblshow1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void addFile(string path, string Name, string Phone, string work)
        {
            StreamWriter writeFile = File.AppendText(path);
            writeFile.Write("姓名：" + Name + "   ");
            writeFile.Write("电话：" + Phone + "   ");
            writeFile.WriteLine("单位：" + work);
            writeFile.Flush();
            writeFile.Close();
            
        }
        bool Brepeat(string path, string Name, string Phone, string work)
        {
            string s = File.ReadAllText(path);
            string temp=("姓名：" + Name + "   电话：" + Phone + "   单位：" + work);
            StreamReader sr = new StreamReader(path);
            while (sr.Peek() != -1)
            {
                string rl = sr.ReadLine();
                if (rl == temp)
                {
                    sr.Close();
                    return true;
                }
            }
            sr.Close();
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string work = txtwork.Text;
            string path = boolworkorperson();
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(work) || ((!rbtnwork.Checked) && (!rbtnPerson.Checked)))
            {
                MessageBox.Show("不能为空!请重新输入!");
            }
            else if (Phone.Length != 11)
            {
                MessageBox.Show("请输入正确的电话号码");
            }
            else if (Brepeat(path, Name, Phone, work))
            {
                MessageBox.Show("存在信息完全相同的联系人\n请重新输入");
            }
            else
            {
                MessageBox.Show("添加成功!");
                addFile(path, Name, Phone, work);
                printdata(path);
            }
            
        }

        private void btndele_Click(object sender, EventArgs e)
        {
            string path = boolworkorperson();
            dele(path);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        void Lsearcher(string path)
        {
            string temp = txtSearcher.Text;
            string s = File.ReadAllText(path);
            StreamReader sr = new StreamReader(path);
            if (s.Contains(temp))
            {
                string catper="";
                while(sr.Peek()!=-1)
                {
                    string rl = sr.ReadLine();
                    if (rl.Contains(temp))
                    {
                        catper += rl+"\n";
                    }
                }
                MessageBox.Show("搜索到关键字：如下:\n"+catper);
            }
            else
            {
                MessageBox.Show("不存在此联系人，请重新输入");
            }
            sr.Close();

        }
        private void txtSearcher_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearcher_Click(object sender, EventArgs e)
        {
            string path = boolworkorperson();
            Lsearcher(path);
        }

        void editperson(string path) {
            string Name = txtName.Text;
            string Phone = txtPhone.Text;
            string work = txtwork.Text;
            string choose = "" + (lsboxshow.SelectedItem);
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(work) || ((!rbtnwork.Checked) && (!rbtnPerson.Checked)))
            {
                MessageBox.Show("不能为空!请重新输入!");
            }
            else if (Phone.Length != 11)
            {
                MessageBox.Show("请输入正确的电话号码");
            }
            else if (choose=="")
            {
                MessageBox.Show("请选择要修改的联系人");
            }
            else
            {
                dele(path);
                addFile(path, Name, Phone, work);
                printdata(path);
                MessageBox.Show("修改成功");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string path = boolworkorperson();
            editperson(path);
        }
        private void btnshuaxin_Click(object sender, EventArgs e)
        {
            string path = boolworkorperson();
            printdata(path);
        }
    }
}
