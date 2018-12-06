namespace xsl_FinalWork
{
    partial class Frm_ManageStu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageStu));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("信息技术学院");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("动物科学学院");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("体育学院");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("经济与管理学院");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("土木与水利工程学院");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("二级学院", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("计算机科学与技术");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("动物科学");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("体育教育");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("机械与电子科学与技术");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("专业", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("男");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("女");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("性别", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("全部信息", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode11,
            treeNode14});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_Updata = new System.Windows.Forms.ToolStripButton();
            this.btn_Delet = new System.Windows.Forms.ToolStripButton();
            this.btn_Search = new System.Windows.Forms.ToolStripButton();
            this.txt_Mess = new System.Windows.Forms.ToolStripTextBox();
            this.cmb_Cols = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.trView_List = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Stu = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统sToolStripMenuItem
            // 
            this.系统sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit});
            this.系统sToolStripMenuItem.Name = "系统sToolStripMenuItem";
            this.系统sToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统sToolStripMenuItem.Text = "系统(&S)";
            // 
            // tsmi_Exit
            // 
            this.tsmi_Exit.Name = "tsmi_Exit";
            this.tsmi_Exit.Size = new System.Drawing.Size(115, 22);
            this.tsmi_Exit.Text = "退出(&E)";
            this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Add,
            this.btn_Updata,
            this.btn_Delet,
            this.btn_Search,
            this.txt_Mess,
            this.cmb_Cols,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1190, 44);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Add
            // 
            this.btn_Add.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.Image")));
            this.btn_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(52, 41);
            this.btn_Add.Text = "增加(&A)";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Updata
            // 
            this.btn_Updata.Image = ((System.Drawing.Image)(resources.GetObject("btn_Updata.Image")));
            this.btn_Updata.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Updata.Name = "btn_Updata";
            this.btn_Updata.Size = new System.Drawing.Size(56, 41);
            this.btn_Updata.Text = "修改(&M)";
            this.btn_Updata.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Updata.Click += new System.EventHandler(this.btn_Updata_Click);
            // 
            // btn_Delet
            // 
            this.btn_Delet.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delet.Image")));
            this.btn_Delet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Delet.Name = "btn_Delet";
            this.btn_Delet.Size = new System.Drawing.Size(53, 41);
            this.btn_Delet.Text = "删除(&D)";
            this.btn_Delet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Delet.Click += new System.EventHandler(this.btn_Delet_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_Search.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(29, 41);
            this.btn_Search.Text = "查询";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Mess
            // 
            this.txt_Mess.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_Mess.Name = "txt_Mess";
            this.txt_Mess.Size = new System.Drawing.Size(100, 44);
            // 
            // cmb_Cols
            // 
            this.cmb_Cols.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_Cols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cols.Items.AddRange(new object[] {
            "二级学院",
            "专业",
            "性别"});
            this.cmb_Cols.Name = "cmb_Cols";
            this.cmb_Cols.Size = new System.Drawing.Size(75, 44);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 41);
            this.toolStripLabel1.Text = "精确查询：";
            // 
            // trView_List
            // 
            this.trView_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trView_List.Location = new System.Drawing.Point(12, 95);
            this.trView_List.Name = "trView_List";
            treeNode1.Name = "节点4";
            treeNode1.Text = "信息技术学院";
            treeNode2.Name = "节点5";
            treeNode2.Text = "动物科学学院";
            treeNode3.Name = "节点6";
            treeNode3.Text = "体育学院";
            treeNode4.Name = "节点7";
            treeNode4.Text = "经济与管理学院";
            treeNode5.Name = "节点8";
            treeNode5.Text = "土木与水利工程学院";
            treeNode6.Name = "节点1";
            treeNode6.Text = "二级学院";
            treeNode7.Name = "节点9";
            treeNode7.Text = "计算机科学与技术";
            treeNode8.Name = "节点10";
            treeNode8.Text = "动物科学";
            treeNode9.Name = "节点11";
            treeNode9.Text = "体育教育";
            treeNode10.Name = "节点12";
            treeNode10.Text = "机械与电子科学与技术";
            treeNode11.Name = "节点2";
            treeNode11.Text = "专业";
            treeNode12.Name = "节点1";
            treeNode12.Text = "男";
            treeNode13.Name = "节点2";
            treeNode13.Text = "女";
            treeNode14.Name = "节点3";
            treeNode14.Text = "性别";
            treeNode15.Name = "节点0";
            treeNode15.Text = "全部信息";
            this.trView_List.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15});
            this.trView_List.Size = new System.Drawing.Size(181, 512);
            this.trView_List.TabIndex = 2;
            this.trView_List.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trView_List_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Stu);
            this.panel1.Location = new System.Drawing.Point(210, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 512);
            this.panel1.TabIndex = 3;
            // 
            // dgv_Stu
            // 
            this.dgv_Stu.AllowUserToOrderColumns = true;
            this.dgv_Stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Stu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Stu.Location = new System.Drawing.Point(0, 0);
            this.dgv_Stu.Name = "dgv_Stu";
            this.dgv_Stu.RowTemplate.Height = 23;
            this.dgv_Stu.Size = new System.Drawing.Size(968, 512);
            this.dgv_Stu.TabIndex = 0;
            // 
            // Frm_ManageStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trView_List);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_ManageStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "学生信息管理";
            this.Load += new System.EventHandler(this.Frm_ManageStu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Stu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统sToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.TreeView trView_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Stu;
        private System.Windows.Forms.ToolStripButton btn_Updata;
        private System.Windows.Forms.ToolStripButton btn_Delet;
        private System.Windows.Forms.ToolStripButton btn_Search;
        private System.Windows.Forms.ToolStripTextBox txt_Mess;
        private System.Windows.Forms.ToolStripComboBox cmb_Cols;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    }
}