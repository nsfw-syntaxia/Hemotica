namespace Hemotica
{
    partial class DashboardA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardA));
			btnClose = new Button();
			btnMaximize = new Button();
			btnMinimize = new Button();
			flpSideBar = new FlowLayoutPanel();
			pMenu = new Panel();
			btnMenu = new Button();
			pBlank = new Panel();
			pDashboard = new Panel();
			btnDashboard = new Button();
			pUserLogs = new Panel();
			btnLogs = new Button();
			pSettings = new Panel();
			btnSetting = new Button();
			pLogout = new Panel();
			btnLogout = new Button();
			tSidebar = new System.Windows.Forms.Timer(components);
			pHeader = new Panel();
			lblUsername = new Label();
			lblHeader = new Label();
			lblUserID = new Label();
			flpDashboard = new FlowLayoutPanel();
			flpSideBar.SuspendLayout();
			pMenu.SuspendLayout();
			pDashboard.SuspendLayout();
			pUserLogs.SuspendLayout();
			pSettings.SuspendLayout();
			pLogout.SuspendLayout();
			pHeader.SuspendLayout();
			SuspendLayout();
			// 
			// btnClose
			// 
			btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClose.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnClose.FlatAppearance.BorderSize = 0;
			btnClose.FlatStyle = FlatStyle.Flat;
			btnClose.Image = (Image)resources.GetObject("btnClose.Image");
			btnClose.Location = new Point(1226, 12);
			btnClose.Name = "btnClose";
			btnClose.Size = new Size(25, 25);
			btnClose.TabIndex = 2;
			btnClose.TabStop = false;
			btnClose.UseVisualStyleBackColor = true;
			btnClose.Click += btnClose_Click;
			// 
			// btnMaximize
			// 
			btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMaximize.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnMaximize.FlatAppearance.BorderSize = 0;
			btnMaximize.FlatStyle = FlatStyle.Flat;
			btnMaximize.Image = (Image)resources.GetObject("btnMaximize.Image");
			btnMaximize.Location = new Point(1195, 12);
			btnMaximize.Name = "btnMaximize";
			btnMaximize.Size = new Size(25, 25);
			btnMaximize.TabIndex = 3;
			btnMaximize.TabStop = false;
			btnMaximize.UseVisualStyleBackColor = true;
			btnMaximize.Click += btnMaximize_Click;
			// 
			// btnMinimize
			// 
			btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnMinimize.FlatAppearance.BorderColor = Color.FromArgb(253, 211, 211);
			btnMinimize.FlatAppearance.BorderSize = 0;
			btnMinimize.FlatStyle = FlatStyle.Flat;
			btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
			btnMinimize.ImageAlign = ContentAlignment.TopCenter;
			btnMinimize.Location = new Point(1164, 12);
			btnMinimize.Name = "btnMinimize";
			btnMinimize.Size = new Size(25, 25);
			btnMinimize.TabIndex = 4;
			btnMinimize.TabStop = false;
			btnMinimize.UseVisualStyleBackColor = true;
			btnMinimize.Click += btnMinimize_Click;
			// 
			// flpSideBar
			// 
			flpSideBar.BackColor = Color.FromArgb(236, 124, 132);
			flpSideBar.Controls.Add(pMenu);
			flpSideBar.Controls.Add(pBlank);
			flpSideBar.Controls.Add(pDashboard);
			flpSideBar.Controls.Add(pUserLogs);
			flpSideBar.Controls.Add(pSettings);
			flpSideBar.Controls.Add(pLogout);
			flpSideBar.Dock = DockStyle.Left;
			flpSideBar.Location = new Point(0, 0);
			flpSideBar.MaximumSize = new Size(225, 803);
			flpSideBar.MinimumSize = new Size(70, 803);
			flpSideBar.Name = "flpSideBar";
			flpSideBar.Size = new Size(225, 803);
			flpSideBar.TabIndex = 5;
			// 
			// pMenu
			// 
			pMenu.Controls.Add(btnMenu);
			pMenu.Location = new Point(3, 3);
			pMenu.Name = "pMenu";
			pMenu.Size = new Size(219, 60);
			pMenu.TabIndex = 0;
			// 
			// btnMenu
			// 
			btnMenu.FlatAppearance.BorderSize = 0;
			btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
			btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
			btnMenu.FlatStyle = FlatStyle.Flat;
			btnMenu.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			btnMenu.ForeColor = Color.FromArgb(253, 211, 211);
			btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
			btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
			btnMenu.Location = new Point(-16, -13);
			btnMenu.Name = "btnMenu";
			btnMenu.Padding = new Padding(20, 5, 5, 5);
			btnMenu.Size = new Size(248, 86);
			btnMenu.TabIndex = 14;
			btnMenu.Text = "            MENU";
			btnMenu.TextAlign = ContentAlignment.MiddleLeft;
			btnMenu.UseVisualStyleBackColor = true;
			btnMenu.Click += btnMenu_Click;
			// 
			// pBlank
			// 
			pBlank.Location = new Point(3, 69);
			pBlank.Name = "pBlank";
			pBlank.Size = new Size(219, 88);
			pBlank.TabIndex = 2;
			// 
			// pDashboard
			// 
			pDashboard.Controls.Add(btnDashboard);
			pDashboard.Location = new Point(3, 163);
			pDashboard.Name = "pDashboard";
			pDashboard.Size = new Size(219, 60);
			pDashboard.TabIndex = 1;
			// 
			// btnDashboard
			// 
			btnDashboard.FlatAppearance.BorderSize = 0;
			btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
			btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
			btnDashboard.FlatStyle = FlatStyle.Flat;
			btnDashboard.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			btnDashboard.ForeColor = Color.FromArgb(253, 211, 211);
			btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
			btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
			btnDashboard.Location = new Point(-16, -13);
			btnDashboard.Name = "btnDashboard";
			btnDashboard.Padding = new Padding(20, 5, 5, 5);
			btnDashboard.Size = new Size(248, 86);
			btnDashboard.TabIndex = 8;
			btnDashboard.Text = "            DASHBOARD";
			btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
			btnDashboard.UseVisualStyleBackColor = true;
			btnDashboard.Click += btnDashboard_Click;
			// 
			// pUserLogs
			// 
			pUserLogs.Controls.Add(btnLogs);
			pUserLogs.Location = new Point(3, 229);
			pUserLogs.Name = "pUserLogs";
			pUserLogs.Size = new Size(219, 60);
			pUserLogs.TabIndex = 2;
			// 
			// btnLogs
			// 
			btnLogs.FlatAppearance.BorderSize = 0;
			btnLogs.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
			btnLogs.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
			btnLogs.FlatStyle = FlatStyle.Flat;
			btnLogs.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			btnLogs.ForeColor = Color.FromArgb(253, 211, 211);
			btnLogs.Image = (Image)resources.GetObject("btnLogs.Image");
			btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
			btnLogs.Location = new Point(-16, -13);
			btnLogs.Name = "btnLogs";
			btnLogs.Padding = new Padding(20, 5, 5, 5);
			btnLogs.Size = new Size(248, 86);
			btnLogs.TabIndex = 9;
			btnLogs.Text = "            USER LOGS";
			btnLogs.TextAlign = ContentAlignment.MiddleLeft;
			btnLogs.UseVisualStyleBackColor = true;
			btnLogs.Click += btnLogs_Click;
			// 
			// pSettings
			// 
			pSettings.Controls.Add(btnSetting);
			pSettings.Location = new Point(3, 295);
			pSettings.Name = "pSettings";
			pSettings.Size = new Size(219, 60);
			pSettings.TabIndex = 5;
			// 
			// btnSetting
			// 
			btnSetting.FlatAppearance.BorderSize = 0;
			btnSetting.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
			btnSetting.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
			btnSetting.FlatStyle = FlatStyle.Flat;
			btnSetting.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			btnSetting.ForeColor = Color.FromArgb(253, 211, 211);
			btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
			btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
			btnSetting.Location = new Point(-16, -13);
			btnSetting.Name = "btnSetting";
			btnSetting.Padding = new Padding(20, 5, 5, 5);
			btnSetting.Size = new Size(248, 86);
			btnSetting.TabIndex = 12;
			btnSetting.Text = "            SETTINGS";
			btnSetting.TextAlign = ContentAlignment.MiddleLeft;
			btnSetting.UseVisualStyleBackColor = true;
			btnSetting.Click += btnSetting_Click;
			// 
			// pLogout
			// 
			pLogout.Controls.Add(btnLogout);
			pLogout.Location = new Point(3, 361);
			pLogout.Name = "pLogout";
			pLogout.Size = new Size(219, 60);
			pLogout.TabIndex = 6;
			// 
			// btnLogout
			// 
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
			btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
			btnLogout.ForeColor = Color.FromArgb(253, 211, 211);
			btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
			btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
			btnLogout.Location = new Point(-16, -13);
			btnLogout.Name = "btnLogout";
			btnLogout.Padding = new Padding(20, 5, 5, 5);
			btnLogout.Size = new Size(248, 86);
			btnLogout.TabIndex = 13;
			btnLogout.Text = "            LOGOUT";
			btnLogout.TextAlign = ContentAlignment.MiddleLeft;
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// tSidebar
			// 
			tSidebar.Interval = 1;
			tSidebar.Tick += tSidebar_Tick;
			// 
			// pHeader
			// 
			pHeader.BackColor = Color.FromArgb(216, 85, 101);
			pHeader.Controls.Add(lblUsername);
			pHeader.Controls.Add(lblHeader);
			pHeader.Controls.Add(lblUserID);
			pHeader.Location = new Point(231, 43);
			pHeader.Name = "pHeader";
			pHeader.Size = new Size(1020, 101);
			pHeader.TabIndex = 11;
			// 
			// lblUsername
			// 
			lblUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblUsername.ForeColor = Color.FromArgb(244, 180, 180);
			lblUsername.Location = new Point(119, 62);
			lblUsername.Name = "lblUsername";
			lblUsername.Padding = new Padding(5, 0, 0, 0);
			lblUsername.Size = new Size(164, 33);
			lblUsername.TabIndex = 10;
			lblUsername.Text = "<username>";
			// 
			// lblHeader
			// 
			lblHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Bahnschrift", 40F, FontStyle.Bold);
			lblHeader.ForeColor = Color.FromArgb(252, 196, 196);
			lblHeader.Location = new Point(3, 0);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(288, 65);
			lblHeader.TabIndex = 7;
			lblHeader.Text = "Dashboard";
			// 
			// lblUserID
			// 
			lblUserID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			lblUserID.AutoSize = true;
			lblUserID.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
			lblUserID.ForeColor = Color.FromArgb(244, 180, 180);
			lblUserID.Location = new Point(6, 62);
			lblUserID.Name = "lblUserID";
			lblUserID.Padding = new Padding(5, 0, 0, 0);
			lblUserID.Size = new Size(115, 33);
			lblUserID.TabIndex = 8;
			lblUserID.Text = "User ID:";
			// 
			// flpDashboard
			// 
			flpDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			flpDashboard.BackColor = Color.FromArgb(253, 211, 211);
			flpDashboard.Location = new Point(231, 150);
			flpDashboard.Name = "flpDashboard";
			flpDashboard.Size = new Size(1020, 641);
			flpDashboard.TabIndex = 10;
			// 
			// DashboardA
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			ClientSize = new Size(1263, 803);
			ControlBox = false;
			Controls.Add(pHeader);
			Controls.Add(flpDashboard);
			Controls.Add(flpSideBar);
			Controls.Add(btnMinimize);
			Controls.Add(btnMaximize);
			Controls.Add(btnClose);
			DoubleBuffered = true;
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "DashboardA";
			StartPosition = FormStartPosition.CenterScreen;
			Load += DashboardD_Load;
			Resize += DashboardD_Resize;
			flpSideBar.ResumeLayout(false);
			pMenu.ResumeLayout(false);
			pDashboard.ResumeLayout(false);
			pUserLogs.ResumeLayout(false);
			pSettings.ResumeLayout(false);
			pLogout.ResumeLayout(false);
			pHeader.ResumeLayout(false);
			pHeader.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private FlowLayoutPanel flpSideBar;
        private Panel pMenu;
        private Panel pDashboard;
        private Panel pUserLogs;
        private Panel pSettings;
        private Button btnDashboard;
        private Button btnLogs;
        private Button btnSetting;
        private Panel pLogout;
        private Button btnLogout;
        private Button btnMenu;
        private System.Windows.Forms.Timer tSidebar;
        private Panel pBlank;
        private Panel pHeader;
        private Label lblHeader;
        private FlowLayoutPanel flpDashboard;
        private Label lblUserID;
		private Label lblUsername;
	}
}
