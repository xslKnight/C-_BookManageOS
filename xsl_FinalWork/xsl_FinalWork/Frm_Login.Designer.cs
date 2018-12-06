namespace xsl_FinalWork
{
    partial class Frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbl_Regit = new System.Windows.Forms.LinkLabel();
            this.txt_Idc = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_User = new xsl_FinalWork.TextBox_tm();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtn_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_GetIdc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.llbl_Regit);
            this.panel1.Controls.Add(this.txt_Idc);
            this.panel1.Controls.Add(this.txt_Pwd);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txt_GetIdc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(128, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 328);
            this.panel1.TabIndex = 0;
            // 
            // llbl_Regit
            // 
            this.llbl_Regit.AutoSize = true;
            this.llbl_Regit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llbl_Regit.LinkColor = System.Drawing.Color.White;
            this.llbl_Regit.Location = new System.Drawing.Point(370, 299);
            this.llbl_Regit.Name = "llbl_Regit";
            this.llbl_Regit.Size = new System.Drawing.Size(40, 16);
            this.llbl_Regit.TabIndex = 1;
            this.llbl_Regit.TabStop = true;
            this.llbl_Regit.Text = "注册";
            this.llbl_Regit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Regit_LinkClicked);
            this.llbl_Regit.MouseEnter += new System.EventHandler(this.llbl_Regit_MouseEnter);
            this.llbl_Regit.MouseLeave += new System.EventHandler(this.llbl_Regit_MouseLeave);
            // 
            // txt_Idc
            // 
            this.txt_Idc.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Idc.Location = new System.Drawing.Point(135, 142);
            this.txt_Idc.Name = "txt_Idc";
            this.txt_Idc.Size = new System.Drawing.Size(103, 29);
            this.txt_Idc.TabIndex = 18;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Pwd.Location = new System.Drawing.Point(135, 89);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(221, 29);
            this.txt_Pwd.TabIndex = 17;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Name.Location = new System.Drawing.Point(135, 32);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(221, 29);
            this.txt_Name.TabIndex = 16;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Exit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Exit.Location = new System.Drawing.Point(59, 264);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(104, 40);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "退出(&E)";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.SystemColors.Control;
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_User.Location = new System.Drawing.Point(136, 35);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(220, 22);
            this.txt_User.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rbtn_3);
            this.panel2.Controls.Add(this.rbtn_2);
            this.panel2.Controls.Add(this.rbtn_1);
            this.panel2.Location = new System.Drawing.Point(3, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 44);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(39, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户类型：";
            // 
            // rbtn_3
            // 
            this.rbtn_3.AutoSize = true;
            this.rbtn_3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_3.ForeColor = System.Drawing.Color.Transparent;
            this.rbtn_3.Location = new System.Drawing.Point(304, 15);
            this.rbtn_3.Name = "rbtn_3";
            this.rbtn_3.Size = new System.Drawing.Size(49, 16);
            this.rbtn_3.TabIndex = 2;
            this.rbtn_3.Text = "教师";
            this.rbtn_3.UseVisualStyleBackColor = true;
            // 
            // rbtn_2
            // 
            this.rbtn_2.AutoSize = true;
            this.rbtn_2.Checked = true;
            this.rbtn_2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_2.ForeColor = System.Drawing.Color.Transparent;
            this.rbtn_2.Location = new System.Drawing.Point(225, 16);
            this.rbtn_2.Name = "rbtn_2";
            this.rbtn_2.Size = new System.Drawing.Size(49, 16);
            this.rbtn_2.TabIndex = 1;
            this.rbtn_2.TabStop = true;
            this.rbtn_2.Text = "学生";
            this.rbtn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_1.ForeColor = System.Drawing.Color.Transparent;
            this.rbtn_1.Location = new System.Drawing.Point(133, 16);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(62, 16);
            this.rbtn_1.TabIndex = 0;
            this.rbtn_1.Text = "管理员";
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Login.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Login.Location = new System.Drawing.Point(250, 264);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(104, 40);
            this.btn_Login.TabIndex = 9;
            this.btn_Login.Text = "登录(&L)";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_GetIdc
            // 
            this.txt_GetIdc.BackColor = System.Drawing.Color.Gray;
            this.txt_GetIdc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_GetIdc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_GetIdc.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_GetIdc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_GetIdc.Location = new System.Drawing.Point(252, 141);
            this.txt_GetIdc.Name = "txt_GetIdc";
            this.txt_GetIdc.ReadOnly = true;
            this.txt_GetIdc.Size = new System.Drawing.Size(104, 34);
            this.txt_GetIdc.TabIndex = 8;
            this.txt_GetIdc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_GetIdc.Click += new System.EventHandler(this.txt_GetIdc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(44, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "验证码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_GetIdc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtn_3;
        private System.Windows.Forms.RadioButton rbtn_2;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.Button btn_Login;
        private TextBox_tm txt_User;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_Idc;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.LinkLabel llbl_Regit;
    }
}

