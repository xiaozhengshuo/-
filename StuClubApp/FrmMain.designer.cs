namespace 社团成员管理器
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社团管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.负责人管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活动管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.社团管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.成员管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.社团活动查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnMemberQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnActivity = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAttendance = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDataTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem,
            this.查询ToolStripMenuItem,
            this.考勤ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.社团管理ToolStripMenuItem,
            this.负责人管理ToolStripMenuItem,
            this.成员管理ToolStripMenuItem,
            this.活动管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.管理ToolStripMenuItem.Text = "管理（M）";
            // 
            // 社团管理ToolStripMenuItem
            // 
            this.社团管理ToolStripMenuItem.Name = "社团管理ToolStripMenuItem";
            this.社团管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.社团管理ToolStripMenuItem.Text = "社团管理";
            // 
            // 负责人管理ToolStripMenuItem
            // 
            this.负责人管理ToolStripMenuItem.Name = "负责人管理ToolStripMenuItem";
            this.负责人管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.负责人管理ToolStripMenuItem.Text = "负责人管理";
            // 
            // 成员管理ToolStripMenuItem
            // 
            this.成员管理ToolStripMenuItem.Name = "成员管理ToolStripMenuItem";
            this.成员管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.成员管理ToolStripMenuItem.Text = "成员管理";
            this.成员管理ToolStripMenuItem.Click += new System.EventHandler(this.成员管理ToolStripMenuItem_Click);
            // 
            // 活动管理ToolStripMenuItem
            // 
            this.活动管理ToolStripMenuItem.Name = "活动管理ToolStripMenuItem";
            this.活动管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.活动管理ToolStripMenuItem.Text = "活动管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.社团管理ToolStripMenuItem1,
            this.成员管理ToolStripMenuItem1,
            this.社团活动查询ToolStripMenuItem});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.查询ToolStripMenuItem.Text = "查询（Q）";
            // 
            // 社团管理ToolStripMenuItem1
            // 
            this.社团管理ToolStripMenuItem1.Name = "社团管理ToolStripMenuItem1";
            this.社团管理ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.社团管理ToolStripMenuItem1.Text = "社团管理";
            // 
            // 成员管理ToolStripMenuItem1
            // 
            this.成员管理ToolStripMenuItem1.Name = "成员管理ToolStripMenuItem1";
            this.成员管理ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.成员管理ToolStripMenuItem1.Text = "成员管理";
            // 
            // 社团活动查询ToolStripMenuItem
            // 
            this.社团活动查询ToolStripMenuItem.Name = "社团活动查询ToolStripMenuItem";
            this.社团活动查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.社团活动查询ToolStripMenuItem.Text = "社团活动查询";
            // 
            // 考勤ToolStripMenuItem
            // 
            this.考勤ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.考勤管理ToolStripMenuItem,
            this.考勤统计ToolStripMenuItem});
            this.考勤ToolStripMenuItem.Name = "考勤ToolStripMenuItem";
            this.考勤ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.考勤ToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.考勤ToolStripMenuItem.Text = "考勤（A）";
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 考勤统计ToolStripMenuItem
            // 
            this.考勤统计ToolStripMenuItem.Name = "考勤统计ToolStripMenuItem";
            this.考勤统计ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.考勤统计ToolStripMenuItem.Text = "考勤统计";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助ToolStripMenuItem.Text = "帮助（H）";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.退出ToolStripMenuItem.Text = "退出（E）";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnMember,
            this.toolStripBtnMemberQuery,
            this.toolStripBtnActivity,
            this.toolStripBtnAttendance,
            this.toolStripBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 88);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnMember
            // 
            this.toolStripBtnMember.AutoSize = false;
            this.toolStripBtnMember.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMember.Image")));
            this.toolStripBtnMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMember.Name = "toolStripBtnMember";
            this.toolStripBtnMember.Size = new System.Drawing.Size(68, 85);
            this.toolStripBtnMember.Text = "成员管理";
            this.toolStripBtnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnMember.Click += new System.EventHandler(this.toolStripBtnMember_Click);
            // 
            // toolStripBtnMemberQuery
            // 
            this.toolStripBtnMemberQuery.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnMemberQuery.Image")));
            this.toolStripBtnMemberQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnMemberQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnMemberQuery.Name = "toolStripBtnMemberQuery";
            this.toolStripBtnMemberQuery.Size = new System.Drawing.Size(68, 85);
            this.toolStripBtnMemberQuery.Text = "成员查询";
            this.toolStripBtnMemberQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnActivity
            // 
            this.toolStripBtnActivity.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnActivity.Image")));
            this.toolStripBtnActivity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnActivity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnActivity.Name = "toolStripBtnActivity";
            this.toolStripBtnActivity.Size = new System.Drawing.Size(68, 85);
            this.toolStripBtnActivity.Text = "活动管理";
            this.toolStripBtnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnAttendance
            // 
            this.toolStripBtnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnAttendance.Image")));
            this.toolStripBtnAttendance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnAttendance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAttendance.Name = "toolStripBtnAttendance";
            this.toolStripBtnAttendance.Size = new System.Drawing.Size(68, 85);
            this.toolStripBtnAttendance.Text = "活动考勤";
            this.toolStripBtnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(68, 85);
            this.toolStripBtnExit.Text = "退出系统";
            this.toolStripBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUserName,
            this.toolStripStatusLabel2,
            this.lblRole,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lblDataTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 840);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1584, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "当前用户:";
            // 
            // lblUserName
            // 
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 17);
            this.lblUserName.Text = "lblUserName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel2.Text = "用户权限:";
            // 
            // lblRole
            // 
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 17);
            this.lblRole.Text = "lblRole";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(850, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel4.Text = "湖北工业职院信智系";
            // 
            // lblDataTime
            // 
            this.lblDataTime.AutoSize = false;
            this.lblDataTime.Name = "lblDataTime";
            this.lblDataTime.Size = new System.Drawing.Size(300, 17);
            this.lblDataTime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1584, 862);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生社团管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社团管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 负责人管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活动管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 社团管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 成员管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 社团活动查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnMember;
        private System.Windows.Forms.ToolStripButton toolStripBtnMemberQuery;
        private System.Windows.Forms.ToolStripButton toolStripBtnActivity;
        private System.Windows.Forms.ToolStripButton toolStripBtnAttendance;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblRole;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lblDataTime;
        private System.Windows.Forms.Timer timer1;
    }
}