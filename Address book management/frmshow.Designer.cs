
namespace WindowsFormsApp1
{
    partial class frmshow
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
            this.rbtnwork = new System.Windows.Forms.RadioButton();
            this.rbtnPerson = new System.Windows.Forms.RadioButton();
            this.lsboxshow = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtwork = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btndele = new System.Windows.Forms.Button();
            this.txtSearcher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearcher = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnshuaxin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnwork
            // 
            this.rbtnwork.Font = new System.Drawing.Font("宋体", 11F);
            this.rbtnwork.Location = new System.Drawing.Point(33, 35);
            this.rbtnwork.Name = "rbtnwork";
            this.rbtnwork.Size = new System.Drawing.Size(104, 24);
            this.rbtnwork.TabIndex = 1;
            this.rbtnwork.TabStop = true;
            this.rbtnwork.Text = "办公类";
            this.rbtnwork.UseVisualStyleBackColor = true;
            this.rbtnwork.CheckedChanged += new System.EventHandler(this.rbtnwork_CheckedChanged);
            // 
            // rbtnPerson
            // 
            this.rbtnPerson.AutoSize = true;
            this.rbtnPerson.Font = new System.Drawing.Font("宋体", 11F);
            this.rbtnPerson.Location = new System.Drawing.Point(200, 35);
            this.rbtnPerson.Name = "rbtnPerson";
            this.rbtnPerson.Size = new System.Drawing.Size(87, 23);
            this.rbtnPerson.TabIndex = 2;
            this.rbtnPerson.TabStop = true;
            this.rbtnPerson.Text = "私有类";
            this.rbtnPerson.UseVisualStyleBackColor = true;
            this.rbtnPerson.CheckedChanged += new System.EventHandler(this.rbtnPerson_CheckedChanged);
            // 
            // lsboxshow
            // 
            this.lsboxshow.FormattingEnabled = true;
            this.lsboxshow.ItemHeight = 15;
            this.lsboxshow.Location = new System.Drawing.Point(32, 69);
            this.lsboxshow.Name = "lsboxshow";
            this.lsboxshow.Size = new System.Drawing.Size(566, 529);
            this.lsboxshow.TabIndex = 3;
            this.lsboxshow.SelectedIndexChanged += new System.EventHandler(this.lblshow1_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(660, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 25);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(712, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 38);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加联系人";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(660, 165);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(234, 25);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtwork
            // 
            this.txtwork.Location = new System.Drawing.Point(660, 241);
            this.txtwork.Name = "txtwork";
            this.txtwork.Size = new System.Drawing.Size(234, 25);
            this.txtwork.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "电话：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "单位：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "添加/修改/删除联系人";
            // 
            // btndele
            // 
            this.btndele.Location = new System.Drawing.Point(712, 347);
            this.btndele.Name = "btndele";
            this.btndele.Size = new System.Drawing.Size(142, 38);
            this.btndele.TabIndex = 12;
            this.btndele.Text = "删除选定联系人";
            this.btndele.UseVisualStyleBackColor = true;
            this.btndele.Click += new System.EventHandler(this.btndele_Click);
            // 
            // txtSearcher
            // 
            this.txtSearcher.Location = new System.Drawing.Point(660, 516);
            this.txtSearcher.Name = "txtSearcher";
            this.txtSearcher.Size = new System.Drawing.Size(234, 25);
            this.txtSearcher.TabIndex = 13;
            this.txtSearcher.TextChanged += new System.EventHandler(this.txtSearcher_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(638, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "搜索联系人（据姓名关键字搜索）";
            // 
            // btnSearcher
            // 
            this.btnSearcher.Location = new System.Drawing.Point(712, 560);
            this.btnSearcher.Name = "btnSearcher";
            this.btnSearcher.Size = new System.Drawing.Size(142, 38);
            this.btnSearcher.TabIndex = 16;
            this.btnSearcher.Text = "搜索联系人";
            this.btnSearcher.UseVisualStyleBackColor = true;
            this.btnSearcher.Click += new System.EventHandler(this.btnSearcher_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(712, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(142, 38);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "修改选定联系人";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnshuaxin
            // 
            this.btnshuaxin.Location = new System.Drawing.Point(496, 29);
            this.btnshuaxin.Name = "btnshuaxin";
            this.btnshuaxin.Size = new System.Drawing.Size(102, 35);
            this.btnshuaxin.TabIndex = 19;
            this.btnshuaxin.Text = "刷新";
            this.btnshuaxin.UseVisualStyleBackColor = true;
            this.btnshuaxin.Click += new System.EventHandler(this.btnshuaxin_Click);
            // 
            // frmshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 650);
            this.Controls.Add(this.btnshuaxin);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearcher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearcher);
            this.Controls.Add(this.btndele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwork);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lsboxshow);
            this.Controls.Add(this.rbtnPerson);
            this.Controls.Add(this.rbtnwork);
            this.Name = "frmshow";
            this.Text = "Address book management terminal                                                 " +
    "            --by  YameMres";
            this.Load += new System.EventHandler(this.frmshow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnwork;
        private System.Windows.Forms.RadioButton rbtnPerson;
        private System.Windows.Forms.ListBox lsboxshow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndele;
        private System.Windows.Forms.TextBox txtSearcher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearcher;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnshuaxin;
    }
}