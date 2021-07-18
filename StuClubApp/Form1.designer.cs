namespace 社团成员管理器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMemberList = new System.Windows.Forms.Panel();
            this.gvMember = new System.Windows.Forms.DataGridView();
            this.lstMemberLilt = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.cmbPic = new System.Windows.Forms.ComboBox();
            this.lbl16 = new System.Windows.Forms.Label();
            this.picMomber = new System.Windows.Forms.PictureBox();
            this.pnsSex = new System.Windows.Forms.Panel();
            this.rdoBoy = new System.Windows.Forms.RadioButton();
            this.rdoGirl = new System.Windows.Forms.RadioButton();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkOthers = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.chkDrawing = new System.Windows.Forms.CheckBox();
            this.chkLiterature = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.cmbClub = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtJoinDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProfession = new System.Windows.Forms.ComboBox();
            this.cmbPolitical = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbBornMonth = new System.Windows.Forms.ComboBox();
            this.cmbBornYear = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlOperate = new System.Windows.Forms.Panel();
            this.columMemberid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMemberList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).BeginInit();
            this.grpOutput.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMomber)).BeginInit();
            this.pnsSex.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlOperate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMemberList
            // 
            this.pnlMemberList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlMemberList.Controls.Add(this.gvMember);
            this.pnlMemberList.Controls.Add(this.lstMemberLilt);
            this.pnlMemberList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMemberList.Location = new System.Drawing.Point(0, 0);
            this.pnlMemberList.Name = "pnlMemberList";
            this.pnlMemberList.Size = new System.Drawing.Size(197, 577);
            this.pnlMemberList.TabIndex = 0;
            // 
            // gvMember
            // 
            this.gvMember.AllowUserToAddRows = false;
            this.gvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columMemberid,
            this.columName});
            this.gvMember.Location = new System.Drawing.Point(12, 172);
            this.gvMember.Name = "gvMember";
            this.gvMember.RowTemplate.Height = 23;
            this.gvMember.Size = new System.Drawing.Size(179, 393);
            this.gvMember.TabIndex = 1;
            // 
            // lstMemberLilt
            // 
            this.lstMemberLilt.FormattingEnabled = true;
            this.lstMemberLilt.ItemHeight = 12;
            this.lstMemberLilt.Location = new System.Drawing.Point(12, 41);
            this.lstMemberLilt.Name = "lstMemberLilt";
            this.lstMemberLilt.Size = new System.Drawing.Size(179, 532);
            this.lstMemberLilt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "成员列表";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblMessage);
            this.grpOutput.Location = new System.Drawing.Point(886, 25);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(200, 477);
            this.grpOutput.TabIndex = 3;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "新成员简况";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(7, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 12);
            this.lblMessage.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(23, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "添加";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(135, 11);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 38);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(247, 11);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 38);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "删除";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(359, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.cmbPic);
            this.grpInput.Controls.Add(this.lbl16);
            this.grpInput.Controls.Add(this.picMomber);
            this.grpInput.Controls.Add(this.pnsSex);
            this.grpInput.Controls.Add(this.txtMemo);
            this.grpInput.Controls.Add(this.groupBox2);
            this.grpInput.Controls.Add(this.txtMobilePhone);
            this.grpInput.Controls.Add(this.txtQQ);
            this.grpInput.Controls.Add(this.cmbClub);
            this.grpInput.Controls.Add(this.label17);
            this.grpInput.Controls.Add(this.label16);
            this.grpInput.Controls.Add(this.label15);
            this.grpInput.Controls.Add(this.dtJoinDate);
            this.grpInput.Controls.Add(this.cmbProfession);
            this.grpInput.Controls.Add(this.cmbPolitical);
            this.grpInput.Controls.Add(this.label14);
            this.grpInput.Controls.Add(this.label13);
            this.grpInput.Controls.Add(this.cmbBornMonth);
            this.grpInput.Controls.Add(this.cmbBornYear);
            this.grpInput.Controls.Add(this.cmbDepartment);
            this.grpInput.Controls.Add(this.cmbGrade);
            this.grpInput.Controls.Add(this.txtMemberName);
            this.grpInput.Controls.Add(this.txtMemberID);
            this.grpInput.Controls.Add(this.label12);
            this.grpInput.Controls.Add(this.label11);
            this.grpInput.Controls.Add(this.label10);
            this.grpInput.Controls.Add(this.label9);
            this.grpInput.Controls.Add(this.label8);
            this.grpInput.Controls.Add(this.label7);
            this.grpInput.Controls.Add(this.label6);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpInput.Location = new System.Drawing.Point(0, 0);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(633, 485);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "成员基本信息";
            // 
            // cmbPic
            // 
            this.cmbPic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPic.FormattingEnabled = true;
            this.cmbPic.Items.AddRange(new object[] {
            "暂无照片",
            "浏览照片..."});
            this.cmbPic.Location = new System.Drawing.Point(336, 179);
            this.cmbPic.Name = "cmbPic";
            this.cmbPic.Size = new System.Drawing.Size(137, 20);
            this.cmbPic.TabIndex = 35;
            this.cmbPic.SelectedIndexChanged += new System.EventHandler(this.cmbPic_SelectedIndexChanged);
            // 
            // lbl16
            // 
            this.lbl16.AutoSize = true;
            this.lbl16.Location = new System.Drawing.Point(265, 184);
            this.lbl16.Name = "lbl16";
            this.lbl16.Size = new System.Drawing.Size(65, 12);
            this.lbl16.TabIndex = 34;
            this.lbl16.Text = "成员照片：";
            // 
            // picMomber
            // 
            this.picMomber.Image = ((System.Drawing.Image)(resources.GetObject("picMomber.Image")));
            this.picMomber.Location = new System.Drawing.Point(327, 40);
            this.picMomber.Name = "picMomber";
            this.picMomber.Size = new System.Drawing.Size(146, 112);
            this.picMomber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMomber.TabIndex = 33;
            this.picMomber.TabStop = false;
            // 
            // pnsSex
            // 
            this.pnsSex.Controls.Add(this.rdoBoy);
            this.pnsSex.Controls.Add(this.rdoGirl);
            this.pnsSex.Location = new System.Drawing.Point(97, 92);
            this.pnsSex.Name = "pnsSex";
            this.pnsSex.Size = new System.Drawing.Size(140, 30);
            this.pnsSex.TabIndex = 32;
            // 
            // rdoBoy
            // 
            this.rdoBoy.AutoSize = true;
            this.rdoBoy.Location = new System.Drawing.Point(8, 7);
            this.rdoBoy.Name = "rdoBoy";
            this.rdoBoy.Size = new System.Drawing.Size(35, 16);
            this.rdoBoy.TabIndex = 13;
            this.rdoBoy.TabStop = true;
            this.rdoBoy.Text = "男";
            this.rdoBoy.UseVisualStyleBackColor = true;
            // 
            // rdoGirl
            // 
            this.rdoGirl.AutoSize = true;
            this.rdoGirl.Location = new System.Drawing.Point(66, 7);
            this.rdoGirl.Name = "rdoGirl";
            this.rdoGirl.Size = new System.Drawing.Size(35, 16);
            this.rdoGirl.TabIndex = 14;
            this.rdoGirl.TabStop = true;
            this.rdoGirl.Text = "女";
            this.rdoGirl.UseVisualStyleBackColor = true;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(105, 339);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(368, 98);
            this.txtMemo.TabIndex = 31;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkOthers);
            this.groupBox2.Controls.Add(this.chkTravel);
            this.groupBox2.Controls.Add(this.chkDrawing);
            this.groupBox2.Controls.Add(this.chkLiterature);
            this.groupBox2.Controls.Add(this.chkSports);
            this.groupBox2.Location = new System.Drawing.Point(98, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 31);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // chkOthers
            // 
            this.chkOthers.AutoSize = true;
            this.chkOthers.Location = new System.Drawing.Point(327, 9);
            this.chkOthers.Name = "chkOthers";
            this.chkOthers.Size = new System.Drawing.Size(48, 16);
            this.chkOthers.TabIndex = 4;
            this.chkOthers.Text = "其他";
            this.chkOthers.UseVisualStyleBackColor = true;
            // 
            // chkTravel
            // 
            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(247, 9);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(48, 16);
            this.chkTravel.TabIndex = 3;
            this.chkTravel.Text = "旅游";
            this.chkTravel.UseVisualStyleBackColor = true;
            // 
            // chkDrawing
            // 
            this.chkDrawing.AutoSize = true;
            this.chkDrawing.Location = new System.Drawing.Point(167, 9);
            this.chkDrawing.Name = "chkDrawing";
            this.chkDrawing.Size = new System.Drawing.Size(48, 16);
            this.chkDrawing.TabIndex = 2;
            this.chkDrawing.Text = "书画";
            this.chkDrawing.UseVisualStyleBackColor = true;
            // 
            // chkLiterature
            // 
            this.chkLiterature.AutoSize = true;
            this.chkLiterature.Location = new System.Drawing.Point(87, 9);
            this.chkLiterature.Name = "chkLiterature";
            this.chkLiterature.Size = new System.Drawing.Size(48, 16);
            this.chkLiterature.TabIndex = 1;
            this.chkLiterature.Text = "文艺";
            this.chkLiterature.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(7, 9);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(48, 16);
            this.chkSports.TabIndex = 0;
            this.chkSports.Text = "体育";
            this.chkSports.UseVisualStyleBackColor = true;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(336, 262);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(137, 21);
            this.txtMobilePhone.TabIndex = 29;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(336, 233);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(137, 21);
            this.txtQQ.TabIndex = 28;
            // 
            // cmbClub
            // 
            this.cmbClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClub.FormattingEnabled = true;
            this.cmbClub.Location = new System.Drawing.Point(336, 205);
            this.cmbClub.Name = "cmbClub";
            this.cmbClub.Size = new System.Drawing.Size(137, 20);
            this.cmbClub.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(265, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 26;
            this.label17.Text = "手机号码：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(277, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 25;
            this.label16.Text = "QQ号码：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 24;
            this.label15.Text = "所属社团：";
            // 
            // dtJoinDate
            // 
            this.dtJoinDate.Location = new System.Drawing.Point(97, 262);
            this.dtJoinDate.Name = "dtJoinDate";
            this.dtJoinDate.Size = new System.Drawing.Size(140, 21);
            this.dtJoinDate.TabIndex = 23;
            // 
            // cmbProfession
            // 
            this.cmbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfession.FormattingEnabled = true;
            this.cmbProfession.Items.AddRange(new object[] {
            "嵌入式技术与应用",
            "移动互联应用技术",
            "物联网技术",
            "计算机应用技术",
            "计算机网络技术",
            "数字媒体应用技术"});
            this.cmbProfession.Location = new System.Drawing.Point(97, 233);
            this.cmbProfession.Name = "cmbProfession";
            this.cmbProfession.Size = new System.Drawing.Size(140, 20);
            this.cmbProfession.TabIndex = 22;
            // 
            // cmbPolitical
            // 
            this.cmbPolitical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPolitical.FormattingEnabled = true;
            this.cmbPolitical.Items.AddRange(new object[] {
            "团员",
            "党员",
            "其他"});
            this.cmbPolitical.Location = new System.Drawing.Point(98, 205);
            this.cmbPolitical.Name = "cmbPolitical";
            this.cmbPolitical.Size = new System.Drawing.Size(140, 20);
            this.cmbPolitical.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 20;
            this.label14.Text = "月";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 19;
            this.label13.Text = "年";
            // 
            // cmbBornMonth
            // 
            this.cmbBornMonth.FormattingEnabled = true;
            this.cmbBornMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbBornMonth.Location = new System.Drawing.Point(163, 180);
            this.cmbBornMonth.Name = "cmbBornMonth";
            this.cmbBornMonth.Size = new System.Drawing.Size(36, 20);
            this.cmbBornMonth.TabIndex = 18;
            // 
            // cmbBornYear
            // 
            this.cmbBornYear.FormattingEnabled = true;
            this.cmbBornYear.Items.AddRange(new object[] {
            "1997",
            "1998",
            "1999"});
            this.cmbBornYear.Location = new System.Drawing.Point(97, 180);
            this.cmbBornYear.Name = "cmbBornYear";
            this.cmbBornYear.Size = new System.Drawing.Size(36, 20);
            this.cmbBornYear.TabIndex = 17;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "信息与智能工程系",
            "汽车工程系",
            "环境工程系",
            "旅游与涉外事务系",
            "机电工程系",
            "艺术设计系",
            "经济贸易系",
            "电子工程系",
            "建筑工程系"});
            this.cmbDepartment.Location = new System.Drawing.Point(97, 147);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(141, 20);
            this.cmbDepartment.TabIndex = 16;
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Items.AddRange(new object[] {
            "2015级",
            "2016级",
            "2017级"});
            this.cmbGrade.Location = new System.Drawing.Point(97, 121);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(140, 20);
            this.cmbGrade.TabIndex = 15;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(96, 65);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(141, 21);
            this.txtMemberName.TabIndex = 12;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(97, 36);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(141, 21);
            this.txtMemberID.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 10;
            this.label12.Text = "备注：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 300);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "兴趣特长：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "加入日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "所学专业：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "政治面貌：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "出生年月：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "系部：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "年级：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "成员姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "成员编号：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grpInput);
            this.panel2.Location = new System.Drawing.Point(229, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 485);
            this.panel2.TabIndex = 2;
            // 
            // pnlOperate
            // 
            this.pnlOperate.Controls.Add(this.btnExit);
            this.pnlOperate.Controls.Add(this.btnAdd);
            this.pnlOperate.Controls.Add(this.btnSave);
            this.pnlOperate.Controls.Add(this.btnUpdate);
            this.pnlOperate.Controls.Add(this.btnDel);
            this.pnlOperate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOperate.Location = new System.Drawing.Point(197, 516);
            this.pnlOperate.Name = "pnlOperate";
            this.pnlOperate.Size = new System.Drawing.Size(917, 61);
            this.pnlOperate.TabIndex = 9;
            // 
            // columMemberid
            // 
            this.columMemberid.HeaderText = "编号";
            this.columMemberid.Name = "columMemberid";
            this.columMemberid.ReadOnly = true;
            this.columMemberid.Width = 60;
            // 
            // columName
            // 
            this.columName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columName.FillWeight = 50F;
            this.columName.HeaderText = "姓名";
            this.columName.Name = "columName";
            this.columName.ReadOnly = true;
            this.columName.Width = 75;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 577);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.pnlOperate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMemberList);
            this.Name = "Form1";
            this.Text = "社团成员管理器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMemberList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMember)).EndInit();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMomber)).EndInit();
            this.pnsSex.ResumeLayout(false);
            this.pnsSex.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlOperate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMemberList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Panel pnsSex;
        private System.Windows.Forms.RadioButton rdoBoy;
        private System.Windows.Forms.RadioButton rdoGirl;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkOthers;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.CheckBox chkDrawing;
        private System.Windows.Forms.CheckBox chkLiterature;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.ComboBox cmbClub;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtJoinDate;
        private System.Windows.Forms.ComboBox cmbProfession;
        private System.Windows.Forms.ComboBox cmbPolitical;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbBornMonth;
        private System.Windows.Forms.ComboBox cmbBornYear;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlOperate;
        private System.Windows.Forms.ListBox lstMemberLilt;
        private System.Windows.Forms.ComboBox cmbPic;
        private System.Windows.Forms.Label lbl16;
        private System.Windows.Forms.PictureBox picMomber;
        private System.Windows.Forms.DataGridView gvMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn columMemberid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columName;
    }
}

