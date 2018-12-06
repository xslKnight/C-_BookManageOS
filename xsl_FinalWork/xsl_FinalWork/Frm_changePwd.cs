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
    public partial class Frm_changePwd : Form
    {
        private int count = 0;
        public Frm_changePwd()
        {
            InitializeComponent();
        }

        private void Frm_changePwd_Load(object sender, EventArgs e)
        {
            txt_Name.Text = Frm_Login.name;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            if (!txt_Pwd.Text.Trim().Equals(Frm_Login.pwd))
            {
                MessageBox.Show("原密码错误！");
                txt_Pwd.Text = "";
                txt_NPwd.Text = "";
                txt_RPwd.Text = "";
                txt_Pwd.Focus();
                count++;
                if (count > 3)
                {
                    btn_Change.Enabled = false;
                    count = 0;
                }
            }else if (!txt_NPwd.Text.Trim().Equals(txt_RPwd.Text.Trim()))
            {
                
                MessageBox.Show("两次密码不相等！");
                txt_RPwd.Text = "";
                txt_NPwd.Text = "";
                txt_NPwd.Focus();
            }
            else
            {
                if (txt_NPwd.Text.Length < 6)
                {
                    MessageBox.Show("密码不能小于6位数！");
                    txt_NPwd.Text = "";
                    txt_RPwd.Text = "";
                    txt_NPwd.Focus();
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(Message.conStr);
                    String cmdStr = "update logInfo set pwd='" + txt_NPwd.Text.Trim() + "' where num='" + txt_Name.Text.Trim() + "'";
                    OleDbCommand cmd = new OleDbCommand(cmdStr, con);
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
                    MessageBox.Show("密码修改成功！");
                    this.Hide();
                }
            }
        }
    }
}
