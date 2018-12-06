namespace xsl_FinalWork
{
    partial class Frm_ManageTea
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("信息技术学院");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("外国语学院");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("动物科学学院");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("农业科学学院");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("机械与电器工程学院");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("艺术学院");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("土木与水利工程学院");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("二级学院", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("教研室主任");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("教研室副主任");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("教研室成员");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("职称", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("本科生");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("研究生");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("博士生");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("副教授");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("教授");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("学历", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("全部信息", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode12,
            treeNode18});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ManageTea));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Tea = new System.Windows.Forms.DataGridView();
            this.trView_List = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Add = new System.Windows.Forms.ToolStripButton();
            this.btn_RunSearch = new System.Windows.Forms.ToolStripButton();
            this.txt_Search = new System.Windows.Forms.ToolStripTextBox();
            this.cmb_Cols = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Updata = new System.Windows.Forms.ToolStripButton();
            this.btn_Delet = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tea)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_Tea);
            this.panel1.Location = new System.Drawing.Point(219, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 528);
            this.panel1.TabIndex = 0;
            // 
            // dgv_Tea
            // 
            this.dgv_Tea.AllowUserToOrderColumns = true;
            this.dgv_Tea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Tea.Location = new System.Drawing.Point(0, 0);
            this.dgv_Tea.Name = "dgv_Tea";
            this.dgv_Tea.RowTemplate.Height = 23;
            this.dgv_Tea.Size = new System.Drawing.Size(847, 528);
            this.dgv_Tea.TabIndex = 0;
            // 
            // trView_List
            // 
            this.trView_List.Location = new System.Drawing.Point(12, 95);
            this.trView_List.Name = "trView_List";
            treeNode1.Name = "节点2";
            treeNode1.Text = "信息技术学院";
            treeNode2.Name = "节点3";
            treeNode2.Text = "外国语学院";
            treeNode3.Name = "节点5";
            treeNode3.Text = "动物科学学院";
            treeNode4.Name = "节点6";
            treeNode4.Text = "农业科学学院";
            treeNode5.Name = "节点7";
            treeNode5.Text = "机械与电器工程学院";
            treeNode6.Name = "节点8";
            treeNode6.Text = "艺术学院";
            treeNode7.Name = "节点9";
            treeNode7.Text = "土木与水利工程学院";
            treeNode8.Name = "节点1";
            treeNode8.Text = "二级学院";
            treeNode9.Name = "节点11";
            treeNode9.Text = "教研室主任";
            treeNode10.Name = "节点12";
            treeNode10.Text = "教研室副主任";
            treeNode11.Name = "节点13";
            treeNode11.Text = "教研室成员";
            treeNode12.Name = "节点10";
            treeNode12.Text = "职称";
            treeNode13.Name = "节点16";
            treeNode13.Text = "本科生";
            treeNode14.Name = "节点17";
            treeNode14.Text = "研究生";
            treeNode15.Name = "节点18";
            treeNode15.Text = "博士生";
            treeNode16.Name = "节点20";
            treeNode16.Text = "副教授";
            treeNode17.Name = "节点21";
            treeNode17.Text = "教授";
            treeNode18.Name = "节点15";
            treeNode18.Text = "学历";
            treeNode19.BackColor = System.Drawing.Color.White;
            treeNode19.Checked = true;
            treeNode19.ForeColor = System.Drawing.Color.Black;
            treeNode19.Name = "mess_All";
            treeNode19.Text = "全部信息";
            this.trView_List.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode19});
            this.trView_List.Size = new System.Drawing.Size(190, 528);
            this.trView_List.TabIndex = 1;
            this.trView_List.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trView_List_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
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
            this.btn_RunSearch,
            this.txt_Search,
            this.cmb_Cols,
            this.btn_Updata,
            this.btn_Delet,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 44);
            this.toolStrip1.TabIndex = 3;
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
            // btn_RunSearch
            // 
            this.btn_RunSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_RunSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RunSearch.Image = ((System.Drawing.Image)(resources.GetObject("btn_RunSearch.Image")));
            this.btn_RunSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RunSearch.Name = "btn_RunSearch";
            this.btn_RunSearch.Size = new System.Drawing.Size(29, 41);
            this.btn_RunSearch.Text = "查询";
            this.btn_RunSearch.Click += new System.EventHandler(this.btn_RunSearch_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(100, 44);
            // 
            // cmb_Cols
            // 
            this.cmb_Cols.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmb_Cols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cols.Items.AddRange(new object[] {
            "二级学院",
            "职称",
            "学历"});
            this.cmb_Cols.Name = "cmb_Cols";
            this.cmb_Cols.Size = new System.Drawing.Size(75, 44);
            this.cmb_Cols.ToolTipText = "选择查询列";
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 41);
            this.toolStripLabel1.Text = "精确查询：";
            // 
            // Frm_ManageTea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 643);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trView_List);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_ManageTea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "教师信息管理";
            this.Load += new System.EventHandler(this.Frm_ManageTea_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tea)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Tea;
        private System.Windows.Forms.TreeView trView_List;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Add;
        private System.Windows.Forms.ToolStripButton btn_RunSearch;
        private System.Windows.Forms.ToolStripTextBox txt_Search;
        private System.Windows.Forms.ToolStripComboBox cmb_Cols;
        private System.Windows.Forms.ToolStripButton btn_Updata;
        private System.Windows.Forms.ToolStripButton btn_Delet;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    }
}