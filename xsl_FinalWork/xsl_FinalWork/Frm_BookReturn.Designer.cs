namespace xsl_FinalWork
{
    partial class Frm_BookReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BookReturn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_BookRet = new System.Windows.Forms.DataGridView();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookRet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgv_BookRet);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 376);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "未还图书";
            // 
            // dgv_BookRet
            // 
            this.dgv_BookRet.AllowUserToAddRows = false;
            this.dgv_BookRet.AllowUserToDeleteRows = false;
            this.dgv_BookRet.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_BookRet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BookRet.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_BookRet.Location = new System.Drawing.Point(3, 17);
            this.dgv_BookRet.Name = "dgv_BookRet";
            this.dgv_BookRet.ReadOnly = true;
            this.dgv_BookRet.RowTemplate.Height = 23;
            this.dgv_BookRet.Size = new System.Drawing.Size(770, 356);
            this.dgv_BookRet.TabIndex = 0;
            this.dgv_BookRet.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_BookRet_CellFormatting);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Submit.Location = new System.Drawing.Point(667, 399);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(118, 39);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "确认归还选中";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Frm_BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_BookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图书借还系统";
            this.Load += new System.EventHandler(this.Frm_BookReturn_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookRet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_BookRet;
        private System.Windows.Forms.Button btn_Submit;
    }
}