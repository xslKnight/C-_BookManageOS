using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace xsl_FinalWork
{
    public partial class Frm_BookReturn : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        string cmdStr = "";

        public Frm_BookReturn()
        {
            InitializeComponent();
        }

        private void showBooks()
        {
            cmdStr = "select BookID as 书籍ID,BookName AS 书名,Author as 作者,CateName as 书籍类型,Publisher as 出版社" +
                ",PublishDate as 出版日期,BorrowDate as 借书时间 from Books_borrow where BorrowPeopleID='" +
                Frm_Login.name+"' and isReturn=1";
            da = new OleDbDataAdapter(cmdStr,con);
            da.Fill(ds, "books");
            dgv_BookRet.DataSource = ds.Tables["books"];
        }
        private void Frm_BookReturn_Load(object sender, EventArgs e)
        {
            //不显示出dataGridView1的最后一行空白   
            dgv_BookRet.AllowUserToAddRows = false;
            showBooks();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //获取图书ID
            int BookID = Convert.ToInt32(dgv_BookRet.CurrentRow.Cells[0].Value);
            //获取当前时间
            string returnDate = DateTime.Now.ToShortDateString();
            cmdStr = "update Books_borrow set isReturn=0,ReturnDate='"+returnDate+"' where BookID="+BookID;
            OleDbCommand cmd = new OleDbCommand(cmdStr, con);
            try
            {
                con.Open();
            }catch(Exception ex)
            {
                MessageBox.Show("出错了："+ex.ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
            //清除已有内容
            while (dgv_BookRet.Rows.Count != 0)
            {
                dgv_BookRet.Rows.RemoveAt(0);
            }
            showBooks();
        }

        private void dgv_BookRet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv_BookRet.RowCount; i++)
            {
                //设置dataGridView默认文字颜色
                dgv_BookRet.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
    }
}
