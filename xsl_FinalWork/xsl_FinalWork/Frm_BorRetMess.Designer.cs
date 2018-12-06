namespace xsl_FinalWork
{
    partial class Frm_BorRetMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BorRetMess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_ToRet = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_IsRet = new System.Windows.Forms.DataGridView();
            this.btn_ToRet = new System.Windows.Forms.Button();
            this.btn_BookRet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ToRet = new System.Windows.Forms.TextBox();
            this.btn_BookBorrow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_isRet = new System.Windows.Forms.TextBox();
            this.btn_isRet = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ToRet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IsRet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_ToRet);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 567);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "未还图书";
            // 
            // dgv_ToRet
            // 
            this.dgv_ToRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ToRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ToRet.Location = new System.Drawing.Point(3, 17);
            this.dgv_ToRet.Name = "dgv_ToRet";
            this.dgv_ToRet.RowTemplate.Height = 23;
            this.dgv_ToRet.Size = new System.Drawing.Size(633, 547);
            this.dgv_ToRet.TabIndex = 0;
            this.dgv_ToRet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ToRet_CellFormatting_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgv_IsRet);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(670, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(575, 567);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "已还图书";
            // 
            // dgv_IsRet
            // 
            this.dgv_IsRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_IsRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_IsRet.Location = new System.Drawing.Point(3, 17);
            this.dgv_IsRet.Name = "dgv_IsRet";
            this.dgv_IsRet.RowTemplate.Height = 23;
            this.dgv_IsRet.Size = new System.Drawing.Size(569, 547);
            this.dgv_IsRet.TabIndex = 0;
            this.dgv_IsRet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_IsRet_CellFormatting);
            // 
            // btn_ToRet
            // 
            this.btn_ToRet.BackColor = System.Drawing.Color.Transparent;
            this.btn_ToRet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ToRet.Location = new System.Drawing.Point(158, 598);
            this.btn_ToRet.Name = "btn_ToRet";
            this.btn_ToRet.Size = new System.Drawing.Size(58, 24);
            this.btn_ToRet.TabIndex = 2;
            this.btn_ToRet.Text = "查询";
            this.btn_ToRet.UseVisualStyleBackColor = false;
            this.btn_ToRet.Click += new System.EventHandler(this.btn_ToRet_Click);
            // 
            // btn_BookRet
            // 
            this.btn_BookRet.BackColor = System.Drawing.Color.Transparent;
            this.btn_BookRet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BookRet.Location = new System.Drawing.Point(551, 595);
            this.btn_BookRet.Name = "btn_BookRet";
            this.btn_BookRet.Size = new System.Drawing.Size(100, 28);
            this.btn_BookRet.TabIndex = 3;
            this.btn_BookRet.Text = "归还图书";
            this.btn_BookRet.UseVisualStyleBackColor = false;
            this.btn_BookRet.Click += new System.EventHandler(this.btn_BookRet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "未还图书总数:";
            // 
            // txt_ToRet
            // 
            this.txt_ToRet.Location = new System.Drawing.Point(96, 599);
            this.txt_ToRet.Name = "txt_ToRet";
            this.txt_ToRet.Size = new System.Drawing.Size(62, 21);
            this.txt_ToRet.TabIndex = 5;
            // 
            // btn_BookBorrow
            // 
            this.btn_BookBorrow.BackColor = System.Drawing.Color.Transparent;
            this.btn_BookBorrow.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_BookBorrow.Location = new System.Drawing.Point(1147, 595);
            this.btn_BookBorrow.Name = "btn_BookBorrow";
            this.btn_BookBorrow.Size = new System.Drawing.Size(100, 28);
            this.btn_BookBorrow.TabIndex = 6;
            this.btn_BookBorrow.Text = "借阅图书";
            this.btn_BookBorrow.UseVisualStyleBackColor = false;
            this.btn_BookBorrow.Click += new System.EventHandler(this.btn_BookBorrow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(671, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "归还图书总数:";
            // 
            // txt_isRet
            // 
            this.txt_isRet.Location = new System.Drawing.Point(752, 599);
            this.txt_isRet.Name = "txt_isRet";
            this.txt_isRet.Size = new System.Drawing.Size(62, 21);
            this.txt_isRet.TabIndex = 8;
            // 
            // btn_isRet
            // 
            this.btn_isRet.BackColor = System.Drawing.Color.Transparent;
            this.btn_isRet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_isRet.Location = new System.Drawing.Point(821, 597);
            this.btn_isRet.Name = "btn_isRet";
            this.btn_isRet.Size = new System.Drawing.Size(58, 24);
            this.btn_isRet.TabIndex = 9;
            this.btn_isRet.Text = "查询";
            this.btn_isRet.UseVisualStyleBackColor = false;
            this.btn_isRet.Click += new System.EventHandler(this.btn_isRet_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Refresh.Location = new System.Drawing.Point(485, 595);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(59, 28);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "刷新表";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Frm_BorRetMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 651);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_isRet);
            this.Controls.Add(this.txt_isRet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_BookBorrow);
            this.Controls.Add(this.txt_ToRet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BookRet);
            this.Controls.Add(this.btn_ToRet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_BorRetMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借还系统";
            this.Load += new System.EventHandler(this.Frm_BorRetMess_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ToRet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_IsRet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ToRet;
        private System.Windows.Forms.Button btn_BookRet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ToRet;
        private System.Windows.Forms.Button btn_BookBorrow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_isRet;
        private System.Windows.Forms.Button btn_isRet;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_ToRet;
        private System.Windows.Forms.DataGridView dgv_IsRet;
    }
}