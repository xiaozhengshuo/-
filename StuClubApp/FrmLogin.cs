using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;
using StuClubApp;
using 社团成员管理器;

namespace StuClubApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region 登陆按钮
        public static string role;
        public static string username;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserManage userbll = new UserManage();
            if (string.IsNullOrEmpty(txtUserName.Text.Trim())|| string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("用户名或密码不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string username = txtUserName.Text.Trim();
                string password = txtPassword.Text.Trim();
                User user = userbll.GetMemberByNameAndPwd(username, password);
                if (user!=null&&user.Role.Trim()==cmbRole.SelectedItem.ToString().Trim())
                {
                    MessageBox.Show("登陆成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    role = user.Role;
                    username = user.Username;
                    FrmMain frmmain = new FrmMain();
                    frmmain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新登陆！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Focus();
                }
            }
        }
        #endregion
        #region 重置按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            lblMessage.Text = "";
            txtUserName.Focus();           
        }
        #endregion
    }
}
