namespace Hemotica
{
    partial class DashboardD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardD));
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            flpSideBar = new FlowLayoutPanel();
            pMenu = new Panel();
            btnMenu = new Button();
            pBlank = new Panel();
            pDashboard = new Panel();
            btnDashboard = new Button();
            pDonate = new Panel();
            btnDonate = new Button();
            pNotification = new Panel();
            btnNotification = new Button();
            pProfile = new Panel();
            btnProfile = new Button();
            pLogout = new Panel();
            btnLogout = new Button();
            flpDashboard = new FlowLayoutPanel();
            lblWelcome = new Label();
            tSidebar = new System.Windows.Forms.Timer(components);
            flpSideBar.SuspendLayout();
            pMenu.SuspendLayout();
            pDashboard.SuspendLayout();
            pDonate.SuspendLayout();
            pNotification.SuspendLayout();
            pProfile.SuspendLayout();
            pLogout.SuspendLayout();
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
            flpSideBar.Controls.Add(pDonate);
            flpSideBar.Controls.Add(pNotification);
            flpSideBar.Controls.Add(pProfile);
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
            // 
            // pDonate
            // 
            pDonate.Controls.Add(btnDonate);
            pDonate.Location = new Point(3, 229);
            pDonate.Name = "pDonate";
            pDonate.Size = new Size(219, 60);
            pDonate.TabIndex = 2;
            // 
            // btnDonate
            // 
            btnDonate.FlatAppearance.BorderSize = 0;
            btnDonate.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnDonate.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnDonate.FlatStyle = FlatStyle.Flat;
            btnDonate.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnDonate.ForeColor = Color.FromArgb(253, 211, 211);
            btnDonate.Image = (Image)resources.GetObject("btnDonate.Image");
            btnDonate.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonate.Location = new Point(-16, -13);
            btnDonate.Name = "btnDonate";
            btnDonate.Padding = new Padding(20, 5, 5, 5);
            btnDonate.Size = new Size(248, 86);
            btnDonate.TabIndex = 9;
            btnDonate.Text = "            DONATE";
            btnDonate.TextAlign = ContentAlignment.MiddleLeft;
            btnDonate.UseVisualStyleBackColor = true;
            // 
            // pNotification
            // 
            pNotification.Controls.Add(btnNotification);
            pNotification.Location = new Point(3, 295);
            pNotification.Name = "pNotification";
            pNotification.Size = new Size(219, 60);
            pNotification.TabIndex = 3;
            // 
            // btnNotification
            // 
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnNotification.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnNotification.ForeColor = Color.FromArgb(253, 211, 211);
            btnNotification.Image = (Image)resources.GetObject("btnNotification.Image");
            btnNotification.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotification.Location = new Point(-16, -13);
            btnNotification.Name = "btnNotification";
            btnNotification.Padding = new Padding(20, 5, 5, 5);
            btnNotification.Size = new Size(248, 86);
            btnNotification.TabIndex = 10;
            btnNotification.Text = "            NOTIFICATION";
            btnNotification.TextAlign = ContentAlignment.MiddleLeft;
            btnNotification.UseVisualStyleBackColor = true;
            // 
            // pProfile
            // 
            pProfile.Controls.Add(btnProfile);
            pProfile.Location = new Point(3, 361);
            pProfile.Name = "pProfile";
            pProfile.Size = new Size(219, 60);
            pProfile.TabIndex = 5;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnProfile.ForeColor = Color.FromArgb(253, 211, 211);
            btnProfile.Image = (Image)resources.GetObject("btnProfile.Image");
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(-16, -13);
            btnProfile.Name = "btnProfile";
            btnProfile.Padding = new Padding(20, 5, 5, 5);
            btnProfile.Size = new Size(248, 86);
            btnProfile.TabIndex = 12;
            btnProfile.Text = "            PROFILE";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // pLogout
            // 
            pLogout.Controls.Add(btnLogout);
            pLogout.Location = new Point(3, 427);
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
            // flpDashboard
            // 
            flpDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpDashboard.BackColor = Color.FromArgb(253, 211, 211);
            flpDashboard.Location = new Point(231, 91);
            flpDashboard.Name = "flpDashboard";
            flpDashboard.Size = new Size(1020, 700);
            flpDashboard.TabIndex = 6;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(244, 148, 156);
            lblWelcome.Location = new Point(231, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(362, 48);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome, <donor> !";
            // 
            // tSidebar
            // 
            tSidebar.Interval = 1;
            tSidebar.Tick += tSidebar_Tick;
            // 
            // DashboardD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(1263, 803);
            ControlBox = false;
            Controls.Add(lblWelcome);
            Controls.Add(flpDashboard);
            Controls.Add(flpSideBar);
            Controls.Add(btnMinimize);
            Controls.Add(btnMaximize);
            Controls.Add(btnClose);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardD";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DashboardD_Load;
            Resize += DashboardD_Resize;
            flpSideBar.ResumeLayout(false);
            pMenu.ResumeLayout(false);
            pDashboard.ResumeLayout(false);
            pDonate.ResumeLayout(false);
            pNotification.ResumeLayout(false);
            pProfile.ResumeLayout(false);
            pLogout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private FlowLayoutPanel flpSideBar;
        private FlowLayoutPanel flpDashboard;
        private Label lblWelcome;
        private Panel pMenu;
        private Panel pDashboard;
        private Panel pDonate;
        private Panel pNotification;
        private Panel pProfile;
        private Button btnDashboard;
        private Button btnDonate;
        private Button btnNotification;
        private Button btnProfile;
        private Panel pLogout;
        private Button btnLogout;
        private Button btnMenu;
        private System.Windows.Forms.Timer tSidebar;
        private Panel pBlank;
    }
}
