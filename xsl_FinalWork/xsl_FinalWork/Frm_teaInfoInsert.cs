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
    public partial class Frm_teaInfoInsert : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbCommand cmd;
        string cmdStr="";
        public Frm_teaInfoInsert supFrm = null;//用于其他窗体调用本船体方法与属性
        
        public Frm_teaInfoInsert()
        {
            supFrm = this;
            InitializeComponent();
        }

        private void Frm_teaInfoInsert_Load(object sender, EventArgs e)
        {
            string cmdStr = "select * from teaInfo where gh='" + txt_gh.Text.Trim() + "'";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "tea");
            DataTable dt = new DataTable();
            dt = ds.Tables["tea"];
            //获取内容，并且填充到初始输入框中
            if (dt.Rows.Count!=0)
            {
                txt_gh.Text = dt.Rows[0].ItemArray[0].ToString();
                txt_xm.Text = dt.Rows[0].ItemArray[1].ToString();
                cmb_xb.Text = dt.Rows[0].ItemArray[2].ToString();
                dtp_time.Text = dt.Rows[0].ItemArray[3].ToString();
                cmb_xy.Text = dt.Rows[0].ItemArray[4].ToString();
                cmb_zc.Text = dt.Rows[0].ItemArray[5].ToString();
                cmb_xl.Text = dt.Rows[0].ItemArray[6].ToString();
            }
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            //打开数据库连接
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误提示：" + ex.ToString());
            }
            cmdStr = "select * from teaInfo where gh='" +txt_gh.Text.Trim()+"'";
            cmd = new OleDbCommand(cmdStr,con);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                //数据中含有，则执行更新操作
                string time = ((DateTime)dtp_time.Value).ToString("yyyy-MM-dd");//TODO 格式转化为日期格式，update出错，功能不可用
                //cmdStr = "update teaInfo set xm='" + txt_xm.Text.Trim() + "',xb='" + cmb_xb.Text.Trim()
                //    +"',time=@time,xy='" + cmb_xy.Text.Trim()
                //    + "',zc='"+ cmb_zc.Text.Trim()+ "',xl='" + cmb_xl.Text.Trim() + "' where gh='"
                //    + txt_gh.Text.Trim() + "'";
                cmdStr = "update teaInfo set xm='" + txt_xm.Text.Trim() + "',xb='" + cmb_xb.Text.Trim()
                    + "',xy='" + cmb_xy.Text.Trim()
                    + "',zc='" + cmb_zc.Text.Trim() + "',xl='" + cmb_xl.Text.Trim()/*+"', time='"+ time*/
                    + "' where gh='"+ txt_gh.Text.Trim() + "'";
                cmd = new OleDbCommand(cmdStr, con);
                //cmd.Parameters.Add(new OleDbParameter("@time",dtp_time.Value));
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("信息更新成功！");
                //重新加载Main和ManageTea窗体内容
                Frm_Main.mainFrm.Reload();
                if (Frm_ManageTea.frmMain != null)
                {
                    Frm_ManageTea.frmMain.Reload();
                }

                this.Close();
            }
            else if (!txt_xm.Text.Equals(""))
            {
                //添加信息到teaInfo中
               cmdStr = "Insert into teaInfo values('" + txt_gh.Text.Trim() + "','" + txt_xm.Text.Trim() +
               "','" + cmb_xb.Text.Trim() + "','" + dtp_time.Text.Trim() + "','" + cmb_xy.Text.Trim() + "','" +
               cmb_zc.Text.Trim() + "','" + cmb_xl.Text.Trim() + "',null)";
                cmd = new OleDbCommand(cmdStr, con);
                cmd.ExecuteNonQuery();

                //添加到logInfo中,初始密码为123456
                string cmdStr2 = "Insert into logInfo values('" + txt_gh.Text.Trim() + "','123456','教师')";
                OleDbCommand cmd2 = new OleDbCommand(cmdStr2, con);
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
                MessageBox.Show("信息初始化成功！");
                //重新加载Main和ManageTea窗体内容
                Frm_Main.mainFrm.Reload();
                if (Frm_ManageTea.frmMain != null)
                {
                    Frm_ManageTea.frmMain.Reload();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("姓名不能为空！");
            }
           
        }
    }
}
