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
    public partial class Frm_Regist : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbCommand cmd;
        string cmdStr="";
        public Frm_Regist()
        {
            InitializeComponent();
        }

        private Boolean checkPwd()
        {
            cmdStr = "select * from logInfo where num='"+txt_Name.Text.Trim()+"'";
            cmd = new OleDbCommand(cmdStr,con);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("出错了："+ex.ToString());
            }
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                MessageBox.Show("账号已存在，请重新输入！");
                txt_Name.Text = "";
                txt_Pwd.Text = "";
                txt_RePwd.Text = "";
                txt_Name.Focus();
                con.Close();
                return false;
            }
            if (txt_Pwd.Text.Trim().Length < 6)
            {
                MessageBox.Show("密码长度不能少于6位数！");
                txt_Pwd.Text = "";
                txt_RePwd.Text = "";
                txt_Pwd.Focus();
                con.Close();
                return false;
            }
            else if (txt_Pwd.Text.Trim() != txt_RePwd.Text.Trim())
            {
                MessageBox.Show("两次密码不一致，请重新输入！");
                txt_Pwd.Text = "";
                txt_RePwd.Text = "";
                txt_Pwd.Focus();
                con.Close();
                return false;
            }
            con.Close();
            read.Close();
            return true;
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //调用checkPwd方法
            Boolean login= checkPwd();
            if (login)
            {
                
                String cmdStr1 = "insert into logInfo values('" + txt_Name.Text.Trim() + "','" + txt_Pwd.Text.Trim() + "','" + cmbBox_Role.Text + "')";
                
                OleDbCommand cmd1 = new OleDbCommand(cmdStr1, con);
                OleDbCommand cmd2;
                if (cmbBox_Role.Text.Equals(""))
                {
                    MessageBox.Show("请选择用户身份！");
                }
                else
                {
                    if (cmbBox_Role.Text.Trim().Equals("教师"))
                    {
                        String cmdStr2 = "insert into teaInfo(gh) values('" + txt_Name.Text.Trim() + "')";
                        cmd2 = new OleDbCommand(cmdStr2, con);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    else
                    {
                        String cmdStr2 = "insert into stuInfo(xh) values('" + txt_Name.Text.Trim() + "')";
                        cmd2 = new OleDbCommand(cmdStr2, con);
                        con.Open();
                        cmd2.ExecuteNonQuery();
                        con.Close();
                    }
                    try
                    {
                        con.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("出错了：" + ex.ToString());
                    }
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("注册成功！");
                    this.Hide();
                    Frm_Login.supFrm.Show();
                }
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_Pwd.Text = "";
            txt_RePwd.Text = "";
            txt_Name.Focus();
        }

        private void Frm_Regist_FormClosing(object sender, FormClosingEventArgs e)
        {
           if(MessageBox.Show("是否退出注册界面？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Frm_Login.supFrm.Show();
            }else
            {
                e.Cancel = true;
            }
        }
    }
}
