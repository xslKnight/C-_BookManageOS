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
    public partial class Frm_BookBorrow : Form
    {

        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        string cmdStr = "";
        public Frm_BookBorrow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 已借图书显示
        /// </summary>
        private void showBorrow()
        {
            cmdStr = "select BookName AS 书名,Author as 作者,Publisher as 出版社 from Books_borrow where isReturn=1 and BorrowPeopleID='"+Frm_Login.name+"'";
            da = new OleDbDataAdapter(cmdStr,con);
            da.Fill(ds,"Borrow");
            dgv_Borrow.DataSource = ds.Tables["Borrow"];
        }

        /// <summary>
        //  可借图书信息显示
        /// </summary>
        private void showBooks()
        {
            cmdStr = "select BookID as 图书ID,BookName AS 书名,Author as 作者,BookType as 类型,CateName as 书籍类型,Publisher as 出版社,PublishPlace as 出版地,PublishDate as 出版日期" +
                ",Keywords as 具体分类,TotalCount as 总量,LoanCount as 借出数量 from Books_tab";
            da = new OleDbDataAdapter(cmdStr,con);
            da.Fill(ds,"Books");
            dgv_BookList.DataSource = ds.Tables["Books"];
        }

        /// <summary>
        /// 图书借出处理
        /// </summary>
        private void bookCount(int LoanCount)
        {
            
            cmdStr = "update Books_tab set LoanCount=" + (LoanCount + 1) ;
            da = new OleDbDataAdapter(cmdStr,con);
            da.Update(ds, "Books");
        }
        private void Frm_BookBorrow_Load(object sender, EventArgs e)
        {
            new EqualRatioChange(this, Width, Height).equalRatioChange();//窗体等比变化(有不断闪烁效果bug)
            //不显示出dataGridView1的最后一行空白   
            dgv_Borrow.AllowUserToAddRows = false;
            dgv_BookList.AllowUserToAddRows = false;
            showBorrow();
            showBooks();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //获取图书信息
            int BookID=Convert.ToInt32(dgv_BookList.CurrentRow.Cells[0].Value);
            string BookName= dgv_BookList.CurrentRow.Cells[1].Value.ToString();
            string Author= dgv_BookList.CurrentRow.Cells[2].Value.ToString();
            string CateName= dgv_BookList.CurrentRow.Cells[4].Value.ToString();
            string Publisher= dgv_BookList.CurrentRow.Cells[5].Value.ToString();
            string PublishDate= dgv_BookList.CurrentRow.Cells[7].Value.ToString();
            string Keywords= dgv_BookList.CurrentRow.Cells[8].Value.ToString();

            //获取当前时间
            string borrowDate = DateTime.Now.ToShortDateString();

            //获取借书人ID
            string borrowPeopleID = Frm_Login.name;
            cmdStr = "insert into Books_borrow(BookID, BookName, Author,CateName,Publisher,PublishDate, Keywords, BorrowDate,ReturnDate,BorrowPeopleID,isReturn)" +
            " Values(" +BookID+",'"+BookName+"','"+Author+"','"+CateName
                +"','"+Publisher+"','"+PublishDate+"','"+Keywords+"','"+borrowDate+"',null,'"+borrowPeopleID+"',1)";
            OleDbCommand cmd = new OleDbCommand(cmdStr,con);
            try
            {
                con.Open();
            }catch(Exception ex)
            {
                MessageBox.Show("出错了：" + ex.ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
            int LoanCount = Convert.ToInt32(dgv_BookList.CurrentRow.Cells[10].Value);
            
            //bookCount(LoanCount);//借出数量操作
            //清除已有内容
            while (dgv_Borrow.Rows.Count != 0)
            {
                dgv_Borrow.Rows.RemoveAt(0);
            }
            showBorrow();
            //清除已有内容
            while (dgv_BookList.Rows.Count != 0)
            {
                dgv_BookList.Rows.RemoveAt(0);
            }
            showBooks();
        }

        private void btn_BorRetMess_Click(object sender, EventArgs e)
        {
            Frm_BorRetMess frm = new Frm_BorRetMess();
            frm.ShowDialog();
        }

        private void dgv_Borrow_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv_Borrow.RowCount; i++)
            {
                //设置dataGridView默认文字颜色
                dgv_Borrow.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dgv_BookList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgv_BookList.RowCount; i++)
            {
                //设置dataGridView默认文字颜色
                dgv_BookList.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
