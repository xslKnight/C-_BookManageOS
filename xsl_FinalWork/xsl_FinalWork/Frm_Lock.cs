using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xsl_FinalWork
{
    public partial class Frm_Lock : Form
    {
        public Frm_Lock()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (txt_Pwd.Text.Trim().Equals(Frm_Login.pwd.Trim()))
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("密码错误！");
                txt_Pwd.Text = "";
                txt_Pwd.Focus();
            }
        }

        private void Frm_Lock_Load(object sender, EventArgs e)
        {

        }
    }
}
