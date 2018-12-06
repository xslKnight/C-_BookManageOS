using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xsl_FinalWork
{
    public partial class Frm_BorRetMess : Form
    {

        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        string cmdStr = "";
        public static Frm_BorRetMess supFrm = null;
        public Frm_BorRetMess()
        {
            supFrm = this;
            InitializeComponent();
        }

        public void Reload()
        {
            this.Frm_BorRetMess_Load(null, null);
        }
        private void btn_BookRet_Click(object sender, EventArgs e)
        {
            Frm_BookReturn frm = new Frm_BookReturn();
            frm.ShowDialog(); 
        }

        private void btn_BookBorrow_Click(object sender, EventArgs e)
        {
            Frm_BookBorrow frm = new Frm_BookBorrow();
            frm.ShowDialog();
        }

        /// <summary>
        /// 显示未归还图书信息
        /// </summary>
        private void showToRet()
        {
            //清除已有内容
            while (dgv_ToRet.Rows.Count != 0)
            {
                dgv_ToRet.Rows.RemoveAt(0);
            }
            cmdStr = "select BookID as 书籍ID,BookName AS 书名,Author as 作者,CateName as 书籍类型,Publisher as 出版社" +
                ",PublishDate as 出版日期,BorrowDate as 借书时间 from Books_borrow where BorrowPeopleID='" +
                Frm_Login.name + "' and isReturn=1";
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "book1");
            dgv_ToRet.DataSource = ds.Tables["book1"];
        }

        /// <summary>
        /// 显示已归还图书信息
        /// </summary>
        private void showIsRet()
        {
            //清除已有内容
            while (dgv_IsRet.Rows.Count != 0)
            {
                dgv_IsRet.Rows.RemoveAt(0);
            }
            cmdStr = "select BookID as 书籍ID,BookName AS 书名,Author as 作者,CateName as 书籍类型,Publisher as 出版社" +
                ",PublishDate as 出版日期,ReturnDate as 还书时间 from Books_borrow where BorrowPeopleID='" +
                Frm_Login.name + "' and isReturn=0";
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "book2");
            dgv_IsRet.DataSource = ds.Tables["book2"];
        }

        private void Frm_BorRetMess_Load(object sender, EventArgs e)
        {
            new EqualRatioChange(this, Width, Height).equalRatioChange();//窗体等比变化(有不断闪烁效果bug)
            //不显示出dataGridView1的最后一行空白   
            dgv_ToRet.AllowUserToAddRows = false;
            dgv_IsRet.AllowUserToAddRows = false;
            showIsRet();
            showToRet();
        }

        private void btn_ToRet_Click(object sender, EventArgs e)
        {
            //计数，未归还图书总数
            txt_ToRet.Text = dgv_ToRet.Rows.Count.ToString();
        }

        private void btn_isRet_Click(object sender, EventArgs e)
        {
            //计数，归还图书总数
            txt_isRet.Text = dgv_IsRet.Rows.Count.ToString();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Reload();
        }
        private void dgv_ToRet_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i <dgv_ToRet.RowCount; i++)
            {
                //设置dataGridView默认文字颜色
                dgv_ToRet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgv_IsRet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv_IsRet.RowCount; i++)
            {
                //设置dataGridView默认文字颜色
                dgv_IsRet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
