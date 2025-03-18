namespace Hemotica
{
    partial class DashboardH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardH));
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            flpSideBar = new FlowLayoutPanel();
            pMenu = new Panel();
            btnMenu = new Button();
            pBlank = new Panel();
            pDashboard = new Panel();
            btnDashboard = new Button();
            pRecords = new Panel();
            btnRecords = new Button();
            pDonation = new Panel();
            btnDonation = new Button();
            pStock = new Panel();
            btnStock = new Button();
            pTransfer = new Panel();
            btnTransfer = new Button();
            pNotification = new Panel();
            btnNotification = new Button();
            pHospital = new Panel();
            btnProfile = new Button();
            pLogout = new Panel();
            btnLogout = new Button();
            flpDashboard = new FlowLayoutPanel();
            lblWelcome = new Label();
            tSidebar = new System.Windows.Forms.Timer(components);
            flpSideBar.SuspendLayout();
            pMenu.SuspendLayout();
            pDashboard.SuspendLayout();
            pRecords.SuspendLayout();
            pDonation.SuspendLayout();
            pStock.SuspendLayout();
            pTransfer.SuspendLayout();
            pNotification.SuspendLayout();
            pHospital.SuspendLayout();
            pLogout.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            flpSideBar.Controls.Add(pRecords);
            flpSideBar.Controls.Add(pDonation);
            flpSideBar.Controls.Add(pStock);
            flpSideBar.Controls.Add(pTransfer);
            flpSideBar.Controls.Add(pNotification);
            flpSideBar.Controls.Add(pHospital);
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
            pMenu.TabIndex = 7;
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
            pBlank.TabIndex = 9;
            // 
            // pDashboard
            // 
            pDashboard.Controls.Add(btnDashboard);
            pDashboard.Location = new Point(3, 163);
            pDashboard.Name = "pDashboard";
            pDashboard.Size = new Size(219, 60);
            pDashboard.TabIndex = 8;
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
            // pRecords
            // 
            pRecords.Controls.Add(btnRecords);
            pRecords.Location = new Point(3, 229);
            pRecords.Name = "pRecords";
            pRecords.Size = new Size(219, 60);
            pRecords.TabIndex = 10;
            // 
            // btnRecords
            // 
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnRecords.ForeColor = Color.FromArgb(253, 211, 211);
            btnRecords.Image = (Image)resources.GetObject("btnRecords.Image");
            btnRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecords.Location = new Point(-16, -13);
            btnRecords.Name = "btnRecords";
            btnRecords.Padding = new Padding(20, 5, 5, 5);
            btnRecords.Size = new Size(248, 86);
            btnRecords.TabIndex = 9;
            btnRecords.Text = "            RECORDS";
            btnRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnRecords.UseVisualStyleBackColor = true;
            // 
            // pDonation
            // 
            pDonation.Controls.Add(btnDonation);
            pDonation.Location = new Point(3, 295);
            pDonation.Name = "pDonation";
            pDonation.Size = new Size(219, 60);
            pDonation.TabIndex = 11;
            // 
            // btnDonation
            // 
            btnDonation.FlatAppearance.BorderSize = 0;
            btnDonation.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnDonation.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnDonation.FlatStyle = FlatStyle.Flat;
            btnDonation.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnDonation.ForeColor = Color.FromArgb(253, 211, 211);
            btnDonation.Image = (Image)resources.GetObject("btnDonation.Image");
            btnDonation.ImageAlign = ContentAlignment.MiddleLeft;
            btnDonation.Location = new Point(-16, -13);
            btnDonation.Name = "btnDonation";
            btnDonation.Padding = new Padding(20, 5, 5, 5);
            btnDonation.Size = new Size(248, 86);
            btnDonation.TabIndex = 10;
            btnDonation.Text = "            DONATION";
            btnDonation.TextAlign = ContentAlignment.MiddleLeft;
            btnDonation.UseVisualStyleBackColor = true;
            // 
            // pStock
            // 
            pStock.Controls.Add(btnStock);
            pStock.Location = new Point(3, 361);
            pStock.Name = "pStock";
            pStock.Size = new Size(219, 60);
            pStock.TabIndex = 12;
            // 
            // btnStock
            // 
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnStock.ForeColor = Color.FromArgb(253, 211, 211);
            btnStock.Image = (Image)resources.GetObject("btnStock.Image");
            btnStock.ImageAlign = ContentAlignment.MiddleLeft;
            btnStock.Location = new Point(-16, -13);
            btnStock.Name = "btnStock";
            btnStock.Padding = new Padding(20, 5, 5, 5);
            btnStock.Size = new Size(248, 86);
            btnStock.TabIndex = 12;
            btnStock.Text = "            BLOOD STOCK";
            btnStock.TextAlign = ContentAlignment.MiddleLeft;
            btnStock.UseVisualStyleBackColor = true;
            // 
            // pTransfer
            // 
            pTransfer.Controls.Add(btnTransfer);
            pTransfer.Location = new Point(3, 427);
            pTransfer.Name = "pTransfer";
            pTransfer.Size = new Size(219, 60);
            pTransfer.TabIndex = 13;
            // 
            // btnTransfer
            // 
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 50, 64);
            btnTransfer.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 64, 80);
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnTransfer.ForeColor = Color.FromArgb(253, 211, 211);
            btnTransfer.Image = (Image)resources.GetObject("btnTransfer.Image");
            btnTransfer.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransfer.Location = new Point(-16, -13);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Padding = new Padding(20, 5, 5, 5);
            btnTransfer.Size = new Size(248, 86);
            btnTransfer.TabIndex = 13;
            btnTransfer.Text = "            TRANSFUSION";
            btnTransfer.TextAlign = ContentAlignment.MiddleLeft;
            btnTransfer.UseVisualStyleBackColor = true;
            // 
            // pNotification
            // 
            pNotification.Controls.Add(btnNotification);
            pNotification.Location = new Point(3, 493);
            pNotification.Name = "pNotification";
            pNotification.Size = new Size(219, 60);
            pNotification.TabIndex = 14;
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
            btnNotification.TabIndex = 11;
            btnNotification.Text = "            NOTIFICATION";
            btnNotification.TextAlign = ContentAlignment.MiddleLeft;
            btnNotification.UseVisualStyleBackColor = true;
            // 
            // pHospital
            // 
            pHospital.Controls.Add(btnProfile);
            pHospital.Location = new Point(3, 559);
            pHospital.Name = "pHospital";
            pHospital.Size = new Size(219, 60);
            pHospital.TabIndex = 15;
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
            btnProfile.TabIndex = 17;
            btnProfile.Text = "            PROFILE";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // pLogout
            // 
            pLogout.Controls.Add(btnLogout);
            pLogout.Location = new Point(3, 625);
            pLogout.Name = "pLogout";
            pLogout.Size = new Size(219, 60);
            pLogout.TabIndex = 16;
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
            btnLogout.TabIndex = 14;
            btnLogout.Text = "            LOGOUT";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // flpDashboard
            // 
            flpDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpDashboard.Location = new Point(231, 91);
            flpDashboard.Name = "flpDashboard";
            flpDashboard.Size = new Size(1020, 700);
            flpDashboard.TabIndex = 6;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Bahnschrift", 30F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(244, 148, 156);
            lblWelcome.Location = new Point(231, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(400, 48);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome, <hospital> !";
            // 
            // tSidebar
            // 
            tSidebar.Interval = 1;
            tSidebar.Tick += tSidebar_Tick;
            // 
            // DashboardH
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashboardH";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DashboardD_Load;
            Resize += DashboardH_Resize;
            flpSideBar.ResumeLayout(false);
            pMenu.ResumeLayout(false);
            pDashboard.ResumeLayout(false);
            pRecords.ResumeLayout(false);
            pDonation.ResumeLayout(false);
            pStock.ResumeLayout(false);
            pTransfer.ResumeLayout(false);
            pNotification.ResumeLayout(false);
            pHospital.ResumeLayout(false);
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
        private Button btnMenu;
        private Panel pBlank;
        private Panel pDashboard;
        private Button btnDashboard;
        private Panel pRecords;
        private Button btnRecords;
        private Panel pDonation;
        private Button btnDonation;
        private Panel pStock;
        private Button btnStock;
        private Panel pTransfer;
        private Button btnTransfer;
        private Panel pNotification;
        private Button btnNotification;
        private Panel pHospital;
        private Panel pLogout;
        private Button btnProfile;
        private Button btnLogout;
        private System.Windows.Forms.Timer tSidebar;
    }
}
