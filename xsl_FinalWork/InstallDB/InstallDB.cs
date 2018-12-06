using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace InstallDB
{
    [RunInstaller(true)]
    public partial class InstallDB : System.Configuration.Install.Installer
    {
        public InstallDB()
        {
            InitializeComponent();
        }
        //创建数据库  
        private void CreateDataBase(string strSql, string DataName, string strMdf, string strLdf, string path)
        {
            OleDbConnection myConn = new OleDbConnection(strSql);
            String str = null;
            try
            {
                str = @" EXEC TeachInfo.mdb @dbname='" + DataName + "',@filename1='" + strMdf + "',@filename2='" + strLdf + "'";
                OleDbCommand myCommand = new OleDbCommand(str, myConn);
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("数据库安装成功！点击确定继续");//需Using System.Windows.Forms  
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库安装失败！" + e.Message + "\n\n" + "您可以手动附加数据");
                System.Diagnostics.Process.Start(path);//打开安装目录  
            }
            finally
            {
                myConn.Close();
            }
        }
        //权限管理  
        private static void SetFullControl(string path)
        {
            FileInfo info = new FileInfo(path);
            FileSecurity fs = info.GetAccessControl();
            fs.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            info.SetAccessControl(fs);
        }
        //重载的Install函数  
        public override void Install(System.Collections.IDictionary stateSaver)
        {
            string server = this.Context.Parameters["server"];//服务器名称  
            string uid = this.Context.Parameters["user"];//SQlServer用户名  
            string pwd = this.Context.Parameters["pwd"];//密码  
            string path = this.Context.Parameters["targetdir"];//安装目录  
            string ch = path.Substring(path.Length - 1, 1);
            if (ch == @"\")   //对路径进行处理，判断末尾是否有'\'  
                path = path.Substring(0, path.Length - 1);//有则删掉  

            string strSql = "server=" + server + ";uid=" + uid + ";pwd=" + pwd + ";database=master";//连接数据库字符串  
            string DataName = @"TeachInfo";//数据库名  
            string strMdf = path + @"XSJSGLXT.mdf";//MDF文件路径，这里需注意文件名要与刚添加的数据库文件名一样！  
            SetFullControl(strMdf);    //设置权限为EveryOne  
            string strLdf = path + @"XSJSGLXT_log.ldf";//LDF文件路径  
            SetFullControl(strLdf);    //设置权限为EveryOne  
            base.Install(stateSaver);
            this.CreateDataBase(strSql, DataName, strMdf, strLdf, path);//开始创建数据库  
        }
    }
}
