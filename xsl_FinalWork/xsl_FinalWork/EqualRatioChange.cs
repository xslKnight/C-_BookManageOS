using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xsl_FinalWork
{
    //控制窗体控件及字体等比改变
    class EqualRatioChange
    {
        private Form frm;
        private float Width,High;//传入窗体加载时宽和高
        /// <summary>
        /// 
        /// </summary>
        /// <param name="frm"> 传入窗体</param>
        /// <param name="Width">加载时的宽度</param>
        /// <param name="High">加载时的高度</param>
        public EqualRatioChange(Form frm, float Width, float High)
        {
            this.frm = frm;
            this.Width = Width;
            this.High = High;
        }
        /// <summary>
        /// 将控件的宽，高，左边距，顶边距和字体大小暂存到tag属性中
        /// </summary>
        /// <param name="cons">递归控件中的控件</param>
        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }

        //根据窗体大小调整控件大小
        private void setControls(float newWidth, float newHigh, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });//获取控件的Tag属性值，并分割后存储字符串数组
                float a = Convert.ToSingle(mytag[0]) * newWidth;//根据窗体缩放比例确定控件的值，宽度
                con.Width = (int)a;//宽度
                a = Convert.ToSingle(mytag[1]) * newHigh;//高度
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newWidth;//左边距离
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newHigh;//上边缘距离
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newWidth, newHigh);//字体大小
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newWidth, newHigh, con);
                }
            }

        }

        private void Frm_Resize(object sender, EventArgs e)
        {
            float newWidth = (frm.Width) / Width;
            float newHigh = (frm.Height) / High;
            setControls(newWidth, newHigh, frm);
        }

        public void equalRatioChange() {
            frm.Resize += new EventHandler(Frm_Resize);//设置窗体控件等比变化比例
            setTag(frm);//设置变化
        }
    }
}
