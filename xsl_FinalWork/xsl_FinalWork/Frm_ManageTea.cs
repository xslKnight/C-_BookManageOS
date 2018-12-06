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
    public partial class Frm_ManageTea : Form
    {
        OleDbConnection con = new OleDbConnection(Message.conStr);
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        public static Frm_ManageTea frmMain = null;
        string cmdStr = "";
         public Frm_ManageTea()
        {
            frmMain = this;
            InitializeComponent();
        }

        public void Reload()
        {
            this.Frm_ManageTea_Load(null,null);
        }

        private void Frm_ManageTea_Load(object sender, EventArgs e)
        {
            new EqualRatioChange(this, Width, Height).equalRatioChange();//窗体等比变化(有不断闪烁效果bug)
            //不显示出dataGridView1的最后一行空白   
            dgv_Tea.AllowUserToAddRows = false;
            showAll();
        }

        private void showAll()
        {
            //清除已有内容
            while (dgv_Tea.Rows.Count != 0)
            {
                dgv_Tea.Rows.RemoveAt(0);
            }
            //选取为根目录或主目录时
            cmdStr = "select gh as 工号, xm as 姓名 ,xb as 性别,time as 入职时间,xy as 二级学院 ,zc as 职称 , xl as 学历,classNum as 课程代码 from teaInfo";
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "teaInfo");
            dgv_Tea.DataSource = ds.Tables["teaInfo"];
        }
        private void trView_List_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            if (trView_List.SelectedNode!=null)//获取点击的节点
            {
                if (trView_List.SelectedNode.Text.Trim() == "全部信息"|| trView_List.SelectedNode.Text.Trim() == "二级学院" || trView_List.SelectedNode.Text.Trim() == "职称"|| trView_List.SelectedNode.Text.Trim() == "学历")
                {
                    showAll();
                }else
                {
                    //清除已有内容
                    while (dgv_Tea.Rows.Count != 0)
                    {
                        dgv_Tea.Rows.RemoveAt(0);
                    }
                    //选取三级子节点时
                    String index = trView_List.SelectedNode.Text;
                    cmdStr = "select gh as 工号, xm as 姓名 ,xb as 性别,time as 入职时间,xy as 二级学院 ,zc as 职称 , xl as 学历,classNum as 课程代码 from teaInfo"
                        +" where xy='" + index + "' or zc='"+index+"' or xl='"+index+"'";
                    da = new OleDbDataAdapter(cmdStr, con);
                    da.Fill(ds, "teaInfo");
                    dgv_Tea.DataSource = ds.Tables["teaInfo"];
                }
            }
        }

        
        private void btn_RunSearch_Click(object sender, EventArgs e)
        {
            string cols = "";
            switch (cmb_Cols.Text.Trim())
            {
                case "二级学院":cols = "xy"; break;
                case "职称": cols = "zc"; break;
                case "学历": cols = "xl";break;
                default:break;
            }
            //清除已有内容
            while (dgv_Tea.Rows.Count != 0)
            {
                dgv_Tea.Rows.RemoveAt(0);
            }
            
            cmdStr = "select gh as 工号, xm as 姓名 ,xb as 性别,time as 入职时间,xy as 二级学院 ,zc as 职称 , xl as 学历,classNum as 课程代码 from teaInfo"+
                " where " +cols+" like '%"+txt_Search.Text.Trim()+"%'";
            da = new OleDbDataAdapter(cmdStr, con);
            da.Fill(ds, "teaInfo");
            dgv_Tea.DataSource = ds.Tables["teaInfo"];
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Frm_teaInfoInsert frm = new Frm_teaInfoInsert();
            frm.supFrm.txt_gh.Enabled = true;
            frm.supFrm.txt_gh.Text = "";
            frm.ShowDialog();
        }

        private void btn_Updata_Click(object sender, EventArgs e)
        {
            Frm_teaInfoInsert frm = new Frm_teaInfoInsert();
            frm.supFrm.txt_gh.Text = dgv_Tea.CurrentRow.Cells[0].Value.ToString();
            frm.ShowDialog();
        }

        private void btn_Delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("删除后的数据不可恢复，是否确认删除？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                //获取主键，设置为删除索引
                string index = dgv_Tea.CurrentRow.Cells[0].Value.ToString();
                //删除学生表中的数据
                cmdStr = "delete * from teaInfo where gh='" + index + "'";
                OleDbCommand cmd = new OleDbCommand(cmdStr, con);
                //删除登录表中的内容
                string cmdStr2 = "delete * from logInfo where num='" + index + "'";
                OleDbCommand cmd2 = new OleDbCommand(cmdStr, con);
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出错了：" + ex.ToString());
                }
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("数据删除成功！");
                this.Reload();
            }
        }

        private void tsmi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
