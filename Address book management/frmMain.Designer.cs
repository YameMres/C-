
namespace WindowsFormsApp1
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnentersystem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "退出系统";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("中山行书百年纪念版", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(70, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用通讯录管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnentersystem
            // 
            this.btnentersystem.Location = new System.Drawing.Point(248, 278);
            this.btnentersystem.Name = "btnentersystem";
            this.btnentersystem.Size = new System.Drawing.Size(132, 45);
            this.btnentersystem.TabIndex = 3;
            this.btnentersystem.Text = "进入系统";
            this.btnentersystem.UseVisualStyleBackColor = true;
            this.btnentersystem.Click += new System.EventHandler(this.btnentersystem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "---by  YameMres";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnentersystem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "通讯录管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnentersystem;
        private System.Windows.Forms.Label label2;
    }
}