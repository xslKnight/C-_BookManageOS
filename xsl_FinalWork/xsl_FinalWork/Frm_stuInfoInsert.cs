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
   
    public partial class Frm_stuInfoInsert : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbCommand cmd;
        string cmdStr = "";
        public Frm_stuInfoInsert supFrm = null;
        public Frm_stuInfoInsert()
        {
            supFrm = this;
            InitializeComponent();
        }

        private void Frm_stuInfoInsert_Load(object sender, EventArgs e)
        {
            string cmdStr = "select * from stuInfo where xh='"+txt_xh.Text.Trim()+"'";
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(cmdStr,con);
            da.Fill(ds,"stu");
            DataTable dt = new DataTable();
            dt = ds.Tables["stu"];
            //获取内容，并且填充到初始输入框中
            if (dt.Rows.Count != 0)
            {
                txt_xh.Text = dt.Rows[0].ItemArray[0].ToString();
                txt_xm.Text = dt.Rows[0].ItemArray[1].ToString();
                cmb_xb.Text = dt.Rows[0].ItemArray[2].ToString();
                dtp_time.Text = dt.Rows[0].ItemArray[3].ToString();
                cmb_xy.Text = dt.Rows[0].ItemArray[4].ToString();
                cmb_zy.Text = dt.Rows[0].ItemArray[5].ToString();
                cmb_nj.Text = dt.Rows[0].ItemArray[6].ToString();
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
            cmdStr = "select * from stuInfo where xh='" + txt_xh.Text.Trim() + "'";
            cmd = new OleDbCommand(cmdStr, con);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                //数据中含有，则执行更新操作
                cmdStr = "update stuInfo set xm='" + txt_xm.Text.Trim() + "',xb='" + cmb_xb.Text.Trim()
                    + "',xy='" + cmb_xy.Text.Trim()
                    + "',zy='" + cmb_zy.Text.Trim() + "',nj='" + cmb_nj.Text.Trim()+/*",time='"+ dtp_time.Text.Trim() + */"' where xh='"
                    + txt_xh.Text.Trim() + "'";
                cmd = new OleDbCommand(cmdStr,con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("信息更新成功！");
                Frm_Main.mainFrm.Reload();
                if (Frm_ManageStu.frmMain != null)
                {
                    Frm_ManageStu.frmMain.Reload();
                }
                this.Close();
            }
            else if (!txt_xm.Text.Equals(""))
            {
                //添加到stuInfo表中
                cmdStr = "Insert into stuInfo values('" + txt_xh.Text.Trim() + "','" + txt_xm.Text.Trim() +
               "','" + cmb_xb.Text.Trim() + "','" + dtp_time.Text.Trim() + "','" + cmb_xy.Text.Trim() + "','" +
               cmb_zy.Text.Trim() + "'," + cmb_nj.Text.Trim() + ",0)";
                cmd = new OleDbCommand(cmdStr, con);
                cmd.ExecuteNonQuery();

                //添加到logInfo中,初始密码为123456
                string cmdStr2 = "Insert into logInfo values('" + txt_xh.Text.Trim() + "','123456','学生')";
                OleDbCommand cmd2 = new OleDbCommand(cmdStr2, con);
                try
                {
                    cmd2.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("出错了："+ex.ToString());
                }
                
                con.Close();
                MessageBox.Show("信息初始化成功！");
                Frm_Main.mainFrm.Reload();
                //重新加载ManageStu中的数据
                if (Frm_ManageStu.frmMain != null)
                {
                    Frm_ManageStu.frmMain.Reload();
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
