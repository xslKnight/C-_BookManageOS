using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace xsl_FinalWork
{
    public partial class Frm_ManageBook : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds = new DataSet();
        string cmdStr = "";
        public static Frm_ManageBook supFrm = null;
        public Frm_ManageBook()
        {
            supFrm = this;
            InitializeComponent();
        }

        public void Reload()
        {
            this.Frm_ManageBook_Load(null, null);
        }
        /// <summary>
        /// 显示图书信息
        /// </summary>
        private void showAll()
        {
            while (dgv_Books.Rows.Count != 0)
            {
                dgv_Books.Rows.RemoveAt(0);
            }
            cmdStr = "select * from Books_tab";
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "BookMess");
            dgv_Books.DataSource = ds.Tables["BookMess"];
        }
        private void Frm_ManageBook_Load(object sender, EventArgs e)
        {
            new EqualRatioChange(this, Width, Height).equalRatioChange();//窗体等比变化(有不断闪烁效果bug)
            //不显示出dataGridView1的最后一行空白   
            dgv_Books.AllowUserToAddRows = false;

            showAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除后的信息不可恢复，是否继续删除？", "系统警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                int bookID = Convert.ToInt32(dgv_Books.CurrentRow.Cells[0].Value);
                cmdStr = "delete * from Books_tab where BookID=" + bookID;
                OleDbCommand cmd = new OleDbCommand(cmdStr, con);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出错了：" + ex.ToString());
                }
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("信息删除成功！");
                showAll();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Frm_bookInfoInsert frm = new Frm_bookInfoInsert();
            Frm_bookInfoInsert.supFrm.btn_Save.Enabled = false;
            frm.ShowDialog();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Books.CurrentRow.Cells[0].Value.ToString().Equals(""))
            {
                MessageBox.Show("请选择要修改的内容！");
            }
            else
            {
                Frm_bookInfoInsert frm = new Frm_bookInfoInsert();
                Frm_bookInfoInsert.supFrm.lbl_BookID.Text = dgv_Books.CurrentRow.Cells[0].Value.ToString();
                Frm_bookInfoInsert.supFrm.txt_ID.Enabled = false;
                Frm_bookInfoInsert.supFrm.btn_Submit.Enabled = false;
                frm.ShowDialog();
            }

        }

        private void btn_Name_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Equals(""))
            {
                showAll();
            }
            else
            {
                //模糊查询
                cmdStr = "select * from Books_tab where BookName like '%" + txt_Name.Text.Trim() + "%'";
                da = new OleDbDataAdapter(cmdStr, con);
                da.Fill(ds, "byName");
                while (dgv_Books.Rows.Count != 0)
                {
                    dgv_Books.Rows.RemoveAt(0);
                }
                dgv_Books.DataSource = ds.Tables["byName"];
            }

        }

        private void btn_Author_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Equals(""))
            {
                showAll();
            }
            else
            {
                //模糊查询
                cmdStr = "select * from Books_tab where Author like '%" + txt_Author.Text.Trim() + "%'";
                da = new OleDbDataAdapter(cmdStr, con);
                da.Fill(ds, "byAuthor");
                while (dgv_Books.Rows.Count != 0)
                {
                    dgv_Books.Rows.RemoveAt(0);
                }
                dgv_Books.DataSource = ds.Tables["byAuthor"];
            }


        }

        private void btn_Keyword_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Equals(""))
            {
                showAll();
            }
            else
            {
                //模糊查询
                cmdStr = "select * from Books_tab where Keywords like '%" + txt_Keyword.Text.Trim() + "%'";
                da = new OleDbDataAdapter(cmdStr, con);
                da.Fill(ds, "byKeywords");
                while (dgv_Books.Rows.Count != 0)
                {
                    dgv_Books.Rows.RemoveAt(0);
                }
                dgv_Books.DataSource = ds.Tables["byKeywords"];
            }

        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
