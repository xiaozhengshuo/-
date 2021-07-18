using System;
using System.Drawing;
using System.Windows.Forms;
using BLL;
using Models;
using StuClubApp;

namespace 社团成员管理器
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            DisableControl();
        }
#region 禁用数据录入区编辑功能
        public void DisableControl()
        {
            txtMemberID.Enabled=false;
            txtMemberName.Enabled=false;
            cmbGrade.Enabled=false;
            cmbDepartment.Enabled=false;
            cmbBornYear.Enabled=false;
            cmbBornMonth.Enabled=false;
            cmbPolitical.Enabled=false;
            cmbClub.Enabled=false;
            cmbProfession.Enabled=false;
            txtQQ.Enabled=false;
            dtJoinDate.Enabled=false;
            txtMobilePhone.Enabled=false;
            groupBox2.Enabled=false;
            txtMemo.Enabled=false;
        }
#endregion
#region 启动数据录入编辑功能
        public void EnablControl()
        {
            txtMemberID.Enabled = true;
            txtMemberName.Enabled = true;
            cmbGrade.Enabled = true;
            cmbDepartment.Enabled = true;
            cmbBornYear.Enabled = true;
            cmbBornMonth.Enabled = true;
            cmbPolitical.Enabled = true;
            cmbClub.Enabled = true;
            cmbProfession.Enabled = true;
            txtQQ.Enabled = true;
            dtJoinDate.Enabled = true;
            txtMobilePhone.Enabled = true;
            groupBox2.Enabled = true;
            txtMemo.Enabled = true;
        }
#endregion    
#region 退出按钮
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
#endregion
#region 添加按钮
        private void btnAdd_Click(object sender, EventArgs e)
        {
            EnablControl();
        }
        #endregion
#region 保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = "";
            if(rdoBoy.Checked)
            {
                sex="男";
            }
            else
            {
                sex = "女";
            }
            string hobbies = "";
            if (chkSports.Checked)
            {
                hobbies += chkSports.Text.Trim() + ";";
            }
            if (chkTravel.Checked)
            {
                hobbies += chkTravel.Text + ";";
            }
            if (chkOthers.Checked)
            {
                hobbies += chkOthers.Text + ";";
            }
            if (chkLiterature.Checked)
            {
                hobbies += chkLiterature.Text + ";";
            }
            if (chkDrawing.Checked)
            {
                hobbies += chkDrawing.Text + ";\t";
            }
            lblMessage.Text += "成员编号：" + txtMemberID.Text + "\n";
            lblMessage.Text+="姓名："+txtMemberName.Text+"\n";
            lblMessage.Text += "性别：" + sex + "\n";
            lblMessage.Text += "年级：" + cmbGrade.Text + "\n";
            lblMessage.Text += "系部：" + cmbDepartment.Text + "\n";
            lblMessage.Text += "出生年月:" + cmbBornYear.Text + "年" + cmbBornMonth.Text + "月"+"\n";
            lblMessage.Text += "政治面貌：" + cmbPolitical.Text + "\n";
            lblMessage.Text += "所属社团：" + cmbClub.Text + "\n";
            lblMessage.Text += "所学专业：" + cmbProfession.Text + "\n";
            lblMessage.Text += "QQ号码:" + txtQQ.Text + "\n";
            lblMessage.Text += "加入日期：" + dtJoinDate.Text + "\n";
            lblMessage.Text += "手机号码：" + txtMobilePhone.Text + "\n";
            lblMessage.Text += "兴趣爱好：" + hobbies + "\n";
            lblMessage.Text += "备注：" + txtMemo.Text + "\n";
            
        }
        #endregion
#region 添加照片
        private void cmbPic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPic.SelectedIndex == 0)
            {
                picMomber.Image = Image.FromFile("nopic.jpg");
            }
            if (cmbPic.SelectedIndex == 1)
            {
                OpenFileDialog dlgOpenFile = new OpenFileDialog();
                dlgOpenFile.Title = "选择图片";
                dlgOpenFile.Filter = "位图文件(*.bm)|JPEG|(*.jpg;*jpeg)|*jpg;*jpeg|所有文件(*.*)|*.*";
                DialogResult result = dlgOpenFile.ShowDialog();
                if (result==DialogResult.OK)
                {
                    if (dlgOpenFile.FileName!=      "")
                    {
                        picMomber.Image = Image.FromFile(dlgOpenFile.FileName);
                    }
                }
            }
        }
#endregion
#region 加载数据库成员列表
        private void Form1_Load(object sender, EventArgs e)
        {
            //加载社团成员列表
            MemberManage memberbll = new MemberManage();
            if (FrmLogin.role.Trim()=="管理员")
            {
                gvMember.DataSource = memberbll.GetAllMembers();
            }
            columMemberid.DataPropertyName = "memberid";
            columName.DataPropertyName = "name";
        }
        #endregion
    }
}
