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
using System.Diagnostics;

namespace xsl_FinalWork
{
    public partial class Frm_Main : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        public static Frm_Main mainFrm = null;
        public Frm_Main()
        {
            mainFrm = this;
            InitializeComponent();
        }
        public void Reload()
        {
            this.Frm_Main_Load(null,null);
        }
        
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            new EqualRatioChange(this, Width, Height).equalRatioChange();//窗体等比变化(有不断闪烁效果bug)
            this.Text = "信息管理系统—Knight 1.0";
            DataSet ds = new DataSet();
            if (Frm_Login.role.Equals("管理员"))
            {
                //身份为管理员时，权限显示设置

                //身份信息显示
                String cmdStu = "select count (*) from stuInfo";
                String cmdTea = "select count(*) from teaInfo";
                OleDbCommand cmd = new OleDbCommand(cmdStu,con);
                OleDbCommand cmd2 = new OleDbCommand(cmdTea,con);
                try
                {
                    con.Open();
                }catch(Exception ex)
                {
                    MessageBox.Show("错误提示："+ex.ToString());
                }
                int stuNum = Convert.ToInt32(cmd.ExecuteScalar());
                int teaNum = Convert.ToInt32(cmd2.ExecuteScalar());
                con.Close();
                lbl_Name.Text = "当前用户：" + Frm_Login.role;
                lbl_Mess1.Text = "学生总数："+stuNum;
                lbl_Mess2.Text = "教师总数："+teaNum;
                llbl_Borrow.Text = "学生信息管理";
                llbl_Return.Text = "教师信息管理";
                llbl_Mess.Text = "图书信息管理";
                //其他功能设置
                tsm_121.Available = false;
                tsm_122.Available = false;
                tsm_123.Enabled = true;
                tsm_123.Available = true;
                tsm_124.Enabled = true;
                tsm_124.Available = true;
                tsm_125.Enabled = true;
                tsm_125.Available = true;
            }
            else if (Frm_Login.role.Equals("教师"))
            {
                //身份为老师时，权限显示设置

                //身份信息显示
                try
                {
                    con.Open();
                }catch(Exception ex)
                {
                    MessageBox.Show("错误信息："+ex.ToString());
                }
                string name = "暂无信息，请完善信息！";
                string zc = "暂无信息，请完善信息！";
                String cmdStr = "select * from teaInfo where gh='"+Frm_Login.name+"'";
                OleDbCommand cmd = new OleDbCommand(cmdStr,con);
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    string xmStr = "select * from teaInfo where gh='" + Frm_Login.name + "'";
                    OleDbDataAdapter da =new OleDbDataAdapter(xmStr,con);
                    da.Fill(ds,"teacher");
                    //使用Dataset获取数据库具体数据
                    name = ds.Tables["teacher"].Rows[0]["xm"].ToString();
                    zc = ds.Tables["teacher"].Rows[0]["zc"].ToString();
                    if (name.Equals(""))
                    {
                        name = "暂无信息，请完善信息！";
                    }
                    if (zc.Equals(""))
                    {
                        zc = "暂无信息，请完善信息！";
                    }
                    con.Close();
                    
                }
                lbl_Name.Text = "当前用户：" + Frm_Login.role;
                lbl_Mess1.Text = Frm_Login.role + "姓名：" + name;
                lbl_Mess2.Text = "职称："+zc;
                llbl_Borrow.Text = "图书租借";
                llbl_Return.Text = "图书归还";
                llbl_Mess.Text = "借还信息查询";
                //其他功能设置
                tsm_122.Enabled = false;//学生信息完善禁用
                tsm_121.Enabled = true;
                tsm_121.Available = true;
                tsm_122.Available = false;
                tsm_123.Available = false;
                tsm_124.Available = false;
                tsm_125.Available = false;
            }
            else
            {
                //身份为学生时，权限显示设置

                //身份信息显示
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误信息：" + ex.ToString());
                }
                string name = "暂无信息，请完善信息！";
                string zy = "暂无信息，请完善信息！";
                String cmdStr = "select * from stuInfo where xh='" + Frm_Login.name + "'";
                OleDbCommand cmd = new OleDbCommand(cmdStr, con);
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    string xmStr = "select * from stuInfo where xh='" + Frm_Login.name + "'";
                    OleDbDataAdapter da = new OleDbDataAdapter(xmStr, con);
                    da.Fill(ds, "student");
                    //使用Dataset获取数据库具体数据
                    name = ds.Tables["student"].Rows[0]["xm"].ToString();
                    zy = ds.Tables["student"].Rows[0]["zy"].ToString();
                    if (name.Equals(""))
                    {
                        name = "暂无信息，请完善信息！";
                    }
                    if (zy.Equals(""))
                    {
                        zy = "暂无信息，请完善信息！";
                    }
                    con.Close();

                }
                lbl_Name.Text = "当前用户：" + Frm_Login.role;
                lbl_Mess1.Text = Frm_Login.role + "姓名：" + name;
                lbl_Mess2.Text = "专业：" + zy;
                llbl_Borrow.Text = "图书租借";
                llbl_Return.Text = "图书归还";
                llbl_Mess.Text = "借还信息查询";
                //其他功能设置
                tsm_121.Enabled = false;//教师信息完善禁用
                tsm_121.Available = false;
                tsm_122.Enabled = true;
                tsm_122.Available = true;
                tsm_123.Available = false;
                tsm_124.Available = false;
                tsm_125.Available = false;
            }
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出系统？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void tsm_11_Click(object sender, EventArgs e)
        {
            //修改密码
            Frm_changePwd frm = new Frm_changePwd();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            lbl_Time.Text = "当前时间："+date;
        }

        private void tsm_121_Click(object sender, EventArgs e)
        {
            Frm_teaInfoInsert frm = new Frm_teaInfoInsert();
            frm.supFrm.txt_gh.Text= Frm_Login.name;
            frm.ShowDialog();
        }

        private void tsm_122_Click(object sender, EventArgs e)
        {
            Frm_stuInfoInsert frm = new Frm_stuInfoInsert();
            frm.supFrm.txt_xh.Text = Frm_Login.name;
            frm.ShowDialog();
        }

        private void tsm_25_Click(object sender, EventArgs e)
        {
            Frm_Lock frm = new Frm_Lock();
            frm.Show();
        }

        private void tsm_22_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }catch(Exception ex)
            {
                MessageBox.Show("出错了：" + ex.ToString());
            }
            
        }

        private void tsm_23_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("NotePad.exe");
            }
            catch(Exception ex)
            {
                MessageBox.Show("出错了：" + ex.ToString());
            }
           
        }

        private void tsm_123_Click(object sender, EventArgs e)
        {
            Frm_ManageTea frm = new Frm_ManageTea();
            frm.ShowDialog();
        }

        private void tsm_124_Click(object sender, EventArgs e)
        {
            Frm_ManageStu frm = new Frm_ManageStu();
            frm.ShowDialog();
        }

        private void tsm_13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出系统？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void tsm_34_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.ShowDialog();
        }

        private void btn_Relog_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.login = true;
            frm.ShowDialog();
        }

        private void btn_UpPwd_Click(object sender, EventArgs e)
        {
            //修改密码
            Frm_changePwd frm = new Frm_changePwd();
            frm.ShowDialog();
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            Frm_Lock frm = new Frm_Lock();
            frm.Show();
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guide_Click(object sender, EventArgs e)
        {
            Frm_Guide frm = new Frm_Guide();
            frm.ShowDialog();
        }

        private void btn_Manual_Click(object sender, EventArgs e)
        {

        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Frm_About frm = new Frm_About();
            frm.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退出系统？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void tsm_14_Click(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login();
            frm.login = true;
            frm.ShowDialog();
        }

        private void llbl_Borrow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Frm_Login.role.Equals("管理员"))
            {
                Frm_ManageStu frmStu = new Frm_ManageStu();
                frmStu.ShowDialog();
            }
            else
            {
                Frm_BookBorrow frm = new Frm_BookBorrow();
                frm.ShowDialog();
            }
            
        }

        private void llbl_Return_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Frm_Login.role.Equals("管理员"))
            {
                Frm_ManageTea frmTea = new Frm_ManageTea();
                frmTea.ShowDialog();
            }
            else
            {
                Frm_BookReturn frm = new Frm_BookReturn();
                frm.ShowDialog();
            }
            
        }

        private void llbl_Mess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Frm_Login.role.Equals("管理员"))
            {
                Frm_ManageBook frmBook = new Frm_ManageBook();
                frmBook.ShowDialog();
            }
            else
            {
                Frm_BorRetMess frm = new Frm_BorRetMess();
                frm.ShowDialog();
            }
            
        }

        private void tsm_125_Click(object sender, EventArgs e)
        {
            Frm_ManageBook frm = new Frm_ManageBook();
            frm.ShowDialog();
        }

        private void tsm_32_Click(object sender, EventArgs e)
        {
            Frm_Guide frm = new Frm_Guide();
            frm.ShowDialog();
        }

        private void tsm_31_Click(object sender, EventArgs e)
        {
           // System.Diagnostics.Process.Start("HELP.chm");
           Help.ShowHelp(this, "HELP.chm");
            //System.Diagnostics.Process.Start("help\\HELP.chm");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //  Help.ShowHelp(this, "help/HELP.chm");
            Help.ShowHelp(this, "Help.chm");
           // System.Diagnostics.Process.Start("help\\HELP.chm");
        }
    }
}
