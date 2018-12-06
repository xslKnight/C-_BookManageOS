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

    public partial class Frm_Login : Form
    {
        public static Frm_Login supFrm = null;
        public static String role = "";
        public static String name = "";
        public static String pwd = "";
        public Boolean login = false;//用于记录是否已经登录
        private int count = 0;
        private string cmdStr = "";
        OleDbCommand cmd;
        OleDbDataReader read;
        public Frm_Login()
        {
            supFrm = this;
            InitializeComponent();
        }

        private void initIdc()
        {
            Identify idc = new Identify();
            String str = idc.getRandom(4);
            txt_GetIdc.Text = str;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            initIdc();
        }


        private void llbl_Regit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Regist frm = new Frm_Regist();
            frm.Show();
            this.Hide();
        }

        private void llbl_Regit_MouseEnter(object sender, EventArgs e)
        {
            llbl_Regit.ForeColor = Color.Blue;
        }

        private void llbl_Regit_MouseLeave(object sender, EventArgs e)
        {
            llbl_Regit.ForeColor = Color.White;
        }


        private void checkLogin()
        {
            if (rbtn_1.Checked)
            {
                role = "管理员";
            }
            else if (rbtn_2.Checked)
            {
                role = "学生";
            }
            else
            {
                role = "教师";
            }
            //登录验证
            if (txt_Name.Text.Trim().Equals(""))
            {
                MessageBox.Show("账号不能为空！");
                txt_Name.Focus();
            }
            else if (txt_Pwd.Text.Trim().Equals(""))
            {
                MessageBox.Show("密码不能为空！");
                txt_Pwd.Focus();
            }
            else if (txt_Idc.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入验证码！");
                txt_Idc.Focus();
            }
            else
            {
                OleDbConnection con = new OleDbConnection(Message.conStr);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //String cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "' and role='" + role + "'";
                cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "'";
                cmd = new OleDbCommand(cmdStr, con);
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "'";
                    cmd = new OleDbCommand(cmdStr, con);
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "' and role='" + role + "'";
                        cmd = new OleDbCommand(cmdStr, con);
                        read = cmd.ExecuteReader();
                        if (read.HasRows)
                        {
                            if (txt_Idc.Text.Trim().ToUpper().Equals(txt_GetIdc.Text.Trim().ToUpper()))
                            {
                                name = txt_Name.Text.Trim();
                                pwd = txt_Pwd.Text.Trim();
                                if (login)
                                {
                                    Frm_Main.mainFrm.Reload();//重新加载main窗体
                                    this.Hide();
                                    login = false;
                                }
                                else
                                {
                                    Frm_Main frm = new Frm_Main();
                                    frm.Show();//打开一个main窗体
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("验证码错误，请重新输入！");
                                txt_Idc.Text = "";
                                txt_Idc.Focus();
                                initIdc();
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户身份错误，请重新选择！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请重新输入！");
                        txt_Pwd.Text = "";
                        txt_Idc.Text = "";
                        txt_Pwd.Focus();
                        initIdc();
                        count++;
                        if (count > 3) {
                            btn_Login.Enabled = false;
                            count = 0;
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在，请重新输入！");
                    txt_Name.Text = "";
                    txt_Pwd.Text = "";
                    txt_Idc.Text = "";
                    txt_Name.Focus();
                    initIdc();
                    con.Close();
                }
                con.Close();
            }
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
           // checkLogin();
            if (rbtn_1.Checked)
            {
                role = "管理员";
            }
            else if (rbtn_2.Checked)
            {
                role = "学生";
            }
            else
            {
                role = "教师";
            }
            //登录验证
            if (txt_Name.Text.Trim().Equals(""))
            {
                MessageBox.Show("账号不能为空！");
                txt_Name.Focus();
            }
            else if (txt_Pwd.Text.Trim().Equals(""))
            {
                MessageBox.Show("密码不能为空！");
                txt_Pwd.Focus();
            }
            else if (txt_Idc.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入验证码！");
                txt_Idc.Focus();
            }
            else
            {
                OleDbConnection con = new OleDbConnection(Message.conStr);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                //String cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "' and role='" + role + "'";
                cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "'";
                cmd = new OleDbCommand(cmdStr, con);
                read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "'";
                    cmd = new OleDbCommand(cmdStr, con);
                    read = cmd.ExecuteReader();
                    if (read.HasRows)
                    {
                        cmdStr = "select * from logInfo where num='" + txt_Name.Text.Trim() + "' and pwd='" + txt_Pwd.Text.Trim() + "' and role='" + role + "'";
                        cmd = new OleDbCommand(cmdStr, con);
                        read = cmd.ExecuteReader();
                        if (read.HasRows)
                        {
                            if (txt_Idc.Text.Trim().ToUpper().Equals(txt_GetIdc.Text.Trim().ToUpper()))
                            {
                                name = txt_Name.Text.Trim();
                                pwd = txt_Pwd.Text.Trim();
                                if (login)
                                {
                                    Frm_Main.mainFrm.Reload();//重新加载main窗体
                                    this.Hide();
                                    login = false;
                                }
                                else
                                {
                                    Frm_Main frm = new Frm_Main();
                                    frm.Show();//打开一个main窗体
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("验证码错误，请重新输入！");
                                txt_Idc.Text = "";
                                txt_Idc.Focus();
                                initIdc();
                                con.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("用户身份错误，请重新选择！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请重新输入！");
                        txt_Pwd.Text = "";
                        txt_Idc.Text = "";
                        txt_Pwd.Focus();
                        initIdc();
                        count++;
                        if (count > 3)
                        {
                            btn_Login.Enabled = false;
                            count = 0;
                        }
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("用户不存在，请重新输入！");
                    txt_Name.Text = "";
                    txt_Pwd.Text = "";
                    txt_Idc.Text = "";
                    txt_Name.Focus();
                    initIdc();
                    con.Close();
                }
                con.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit(); //不适用于重新登录按钮
            this.Close();
        }

       

        private void txt_GetIdc_Click(object sender, EventArgs e)
        {
            initIdc();
        }
    }
}
