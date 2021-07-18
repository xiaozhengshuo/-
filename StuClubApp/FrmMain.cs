using System;
using System.Windows.Forms;

namespace 社团成员管理器
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public  FrmMain(string uname,string role)
        {
            InitializeComponent();
            this.lblUserName.Text = uname;
            this.lblRole.Text = role;
        }                                                   //构造函数法传递参数
       
        
        /*private string role;

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        private string uname;

        public string Uname
        {
            get { return uname; }
            set { uname = value; }                     //属性传参
        }
        */
        private void 成员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void toolStripBtnMember_Click(object sender, EventArgs e)
        {
            成员管理ToolStripMenuItem_Click(sender, e);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           // lblRole.Text = this.Role;                 //属性法传递参数
           // lblUserName.Text = this.Uname;   

            //lblUserName.Text = FrmLogin.uname;          // 静态变量方法传递参数
            //lblRole.Text = FrmLogin.role;

        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您真的要退出系统吗？","系统提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripBtnExit_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataTime.Text = "系统当前时间：" + System.DateTime.Now.ToString("yyyy-mm-dd  hh:mm:ss");
        }
    }
}
