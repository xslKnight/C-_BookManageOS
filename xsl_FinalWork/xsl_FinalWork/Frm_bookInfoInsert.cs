using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace xsl_FinalWork
{
    public partial class Frm_bookInfoInsert : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        string cmdStr = "";
        public static Frm_bookInfoInsert supFrm = null;
        public Frm_bookInfoInsert()
        {
            supFrm = this;
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //获取增加或修改的信息
            string code = txt_ID.Text.Trim();
            string name = txt_Name.Text.Trim();
            string author = txt_Author.Text.Trim();
            string type = cmb_Type.Text.Trim();
            string cate = txt_CateName.Text.Trim();
            string publisher = txt_Publisher.Text.Trim();
            string addr = txt_Addr.Text.Trim();
            string time = txt_Time.Text.Trim();
            string keyword = txt_Keywords.Text.Trim();
            string info = txt_Info.Text.Trim();
            //获取当前日期
            string date = DateTime.Now.ToShortDateString();

            if (code.Equals("") || name.Equals(""))
            {
                MessageBox.Show("书籍编码不能为空，请重新输入！");
                txt_ID.Focus();
            }
            else if (name.Equals(""))
            {
                MessageBox.Show("书籍名称不能为空，请重新输入！");
                txt_Name.Focus();
            }
            else
            {
                cmdStr = "insert into Books_tab(ISBNISSN,BookName,Author,BookType,CateName,Publisher,PublishPlace,PublishDate,Keywords,ContentIntro,TotalCount,LoanCount,RegDate,Operator)" +
                " values('" + code + "','" + name + "','" + author + "','" + type + "','" + cate + "','" + publisher + "','" + addr + "','" + time
                + "','" + keyword + "','" + info + "',5,0,'" + date + "','Admin')";
                cmd = new OleDbCommand(cmdStr, con);
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
                MessageBox.Show("信息添加成功！");
                this.Close();
                Frm_ManageBook.supFrm.Reload();
            }
        }

        private void Frm_bookInfoInsert_Load(object sender, EventArgs e)
        {
            cmdStr = "select * from Books_tab where BookID=" + Convert.ToInt64(lbl_BookID.Text.Trim());
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "addInfo");
            DataTable dt = ds.Tables["addInfo"];
            //获取内容，并且填充到初始输入框中
            if (dt.Rows.Count != 0)
            {
                txt_ID.Text = dt.Rows[0].ItemArray[1].ToString();
                txt_Name.Text = dt.Rows[0].ItemArray[2].ToString();
                txt_Author.Text = dt.Rows[0].ItemArray[3].ToString();
                cmb_Type.Text = dt.Rows[0].ItemArray[4].ToString();
                txt_CateName.Text = dt.Rows[0].ItemArray[5].ToString();
                txt_Publisher.Text = dt.Rows[0].ItemArray[6].ToString();
                txt_Addr.Text = dt.Rows[0].ItemArray[7].ToString();
                txt_Time.Text = dt.Rows[0].ItemArray[8].ToString();
                txt_Keywords.Text = dt.Rows[0].ItemArray[9].ToString();
                txt_Info.Text = dt.Rows[0].ItemArray[10].ToString();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            cmdStr="update Books_tab set BookName='"+txt_Name.Text.Trim()+"',Author='"+txt_Author.Text.Trim()
                +"',BookType='"+cmb_Type.Text.Trim()+"',CateName='"+txt_CateName.Text.Trim()+"',Publisher='"
                +txt_Publisher.Text.Trim()+"',PublishPlace='"+txt_Addr.Text.Trim()+"',PublishDate='"+txt_Time.Text.Trim()
                +"',Keywords='"+txt_Keywords.Text.Trim()+"',ContentIntro='"+txt_Info.Text.Trim()+"' where BookID="+ Convert.ToInt64(lbl_BookID.Text.Trim());
            cmd = new OleDbCommand(cmdStr,con);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();
            Frm_ManageBook.supFrm.Reload();
            MessageBox.Show("信息更新成功！");
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
