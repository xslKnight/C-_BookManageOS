namespace xsl_FinalWork
{
    partial class Frm_BookBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BookBorrow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_BookList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_Borrow = new System.Windows.Forms.DataGridView();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_BorRetMess = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Borrow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 25);
            this.menuStrip1.TabIndex = 0;
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
            // dgv_BookList
            // 
            this.dgv_BookList.AllowUserToAddRows = false;
            this.dgv_BookList.AllowUserToDeleteRows = false;
            this.dgv_BookList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BookList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_BookList.Location = new System.Drawing.Point(3, 17);
            this.dgv_BookList.Name = "dgv_BookList";
            this.dgv_BookList.ReadOnly = true;
            this.dgv_BookList.RowTemplate.Height = 23;
            this.dgv_BookList.Size = new System.Drawing.Size(712, 579);
            this.dgv_BookList.TabIndex = 0;
            this.dgv_BookList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_BookList_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_Borrow);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 496);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已借图书";
            // 
            // dgv_Borrow
            // 
            this.dgv_Borrow.AllowUserToAddRows = false;
            this.dgv_Borrow.AllowUserToDeleteRows = false;
            this.dgv_Borrow.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Borrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Borrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Borrow.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_Borrow.Location = new System.Drawing.Point(3, 17);
            this.dgv_Borrow.Name = "dgv_Borrow";
            this.dgv_Borrow.ReadOnly = true;
            this.dgv_Borrow.RowTemplate.Height = 23;
            this.dgv_Borrow.Size = new System.Drawing.Size(268, 476);
            this.dgv_Borrow.TabIndex = 0;
            this.dgv_Borrow.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Borrow_CellFormatting);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Submit.Location = new System.Drawing.Point(183, 605);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 44);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "提交选中";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_BookList);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(292, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 599);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书列表";
            // 
            // btn_BorRetMess
            // 
            this.btn_BorRetMess.BackColor = System.Drawing.Color.Transparent;
            this.btn_BorRetMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BorRetMess.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BorRetMess.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_BorRetMess.Location = new System.Drawing.Point(15, 605);
            this.btn_BorRetMess.Name = "btn_BorRetMess";
            this.btn_BorRetMess.Size = new System.Drawing.Size(100, 44);
            this.btn_BorRetMess.TabIndex = 6;
            this.btn_BorRetMess.Text = "借阅情况";
            this.btn_BorRetMess.UseVisualStyleBackColor = false;
            this.btn_BorRetMess.Click += new System.EventHandler(this.btn_BorRetMess_Click);
            // 
            // Frm_BookBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 663);
            this.Controls.Add(this.btn_BorRetMess);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_BookBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借还系统";
            this.Load += new System.EventHandler(this.Frm_BookBorrow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Borrow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_BookList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_BorRetMess;
        private System.Windows.Forms.DataGridView dgv_Borrow;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    }
}