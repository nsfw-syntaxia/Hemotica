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
            pRecords = new Panel();
            btnRecords = new Button();
            pRequests = new Panel();
            btnRequests = new Button();
            pStock = new Panel();
            btnStock = new Button();
            pNotification = new Panel();
            btnNotification = new Button();
            pLogout = new Panel();
            btnLogout = new Button();
            flpDashboard = new FlowLayoutPanel();
            lblWelcome = new Label();
            pSettings = new Panel();
            btnSettingsA = new Button();
            flpSideBar.SuspendLayout();
            pMenu.SuspendLayout();
            pDashboard.SuspendLayout();
            pRecords.SuspendLayout();
            pRequests.SuspendLayout();
            pStock.SuspendLayout();
            pNotification.SuspendLayout();
            pLogout.SuspendLayout();
            pSettings.SuspendLayout();
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
            flpSideBar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flpSideBar.BackColor = Color.FromArgb(64, 165, 220);
            flpSideBar.Controls.Add(pMenu);
            flpSideBar.Controls.Add(pBlank);
            flpSideBar.Controls.Add(pDashboard);
            flpSideBar.Controls.Add(pRecords);
            flpSideBar.Controls.Add(pRequests);
            flpSideBar.Controls.Add(pStock);
            flpSideBar.Controls.Add(pNotification);
            flpSideBar.Controls.Add(pSettings);
            flpSideBar.Controls.Add(pLogout);
            flpSideBar.Location = new Point(0, 0);
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
            pMenu.TabIndex = 17;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnMenu.ForeColor = Color.FromArgb(170, 225, 255);
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
            // 
            // pBlank
            // 
            pBlank.Location = new Point(3, 69);
            pBlank.Name = "pBlank";
            pBlank.Size = new Size(219, 88);
            pBlank.TabIndex = 19;
            // 
            // pDashboard
            // 
            pDashboard.Controls.Add(btnDashboard);
            pDashboard.Location = new Point(3, 163);
            pDashboard.Name = "pDashboard";
            pDashboard.Size = new Size(219, 60);
            pDashboard.TabIndex = 18;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.FromArgb(170, 225, 255);
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
            pRecords.TabIndex = 20;
            // 
            // btnRecords
            // 
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnRecords.ForeColor = Color.FromArgb(170, 225, 255);
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
            // pRequests
            // 
            pRequests.Controls.Add(btnRequests);
            pRequests.Location = new Point(3, 295);
            pRequests.Name = "pRequests";
            pRequests.Size = new Size(219, 60);
            pRequests.TabIndex = 21;
            // 
            // btnRequests
            // 
            btnRequests.FlatAppearance.BorderSize = 0;
            btnRequests.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnRequests.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnRequests.FlatStyle = FlatStyle.Flat;
            btnRequests.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnRequests.ForeColor = Color.FromArgb(170, 225, 255);
            btnRequests.Image = (Image)resources.GetObject("btnRequests.Image");
            btnRequests.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequests.Location = new Point(-16, -13);
            btnRequests.Name = "btnRequests";
            btnRequests.Padding = new Padding(20, 5, 5, 5);
            btnRequests.Size = new Size(248, 86);
            btnRequests.TabIndex = 10;
            btnRequests.Text = "            REQUESTS";
            btnRequests.TextAlign = ContentAlignment.MiddleLeft;
            btnRequests.UseVisualStyleBackColor = true;
            // 
            // pStock
            // 
            pStock.Controls.Add(btnStock);
            pStock.Location = new Point(3, 361);
            pStock.Name = "pStock";
            pStock.Size = new Size(219, 60);
            pStock.TabIndex = 22;
            // 
            // btnStock
            // 
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnStock.ForeColor = Color.FromArgb(170, 225, 255);
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
            // pNotification
            // 
            pNotification.Controls.Add(btnNotification);
            pNotification.Location = new Point(3, 427);
            pNotification.Name = "pNotification";
            pNotification.Size = new Size(219, 60);
            pNotification.TabIndex = 24;
            // 
            // btnNotification
            // 
            btnNotification.FlatAppearance.BorderSize = 0;
            btnNotification.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnNotification.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnNotification.FlatStyle = FlatStyle.Flat;
            btnNotification.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnNotification.ForeColor = Color.FromArgb(170, 225, 255);
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
            // pLogout
            // 
            pLogout.Controls.Add(btnLogout);
            pLogout.Location = new Point(3, 559);
            pLogout.Name = "pLogout";
            pLogout.Size = new Size(219, 60);
            pLogout.TabIndex = 26;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(170, 225, 255);
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
            lblWelcome.ForeColor = Color.FromArgb(95, 179, 224);
            lblWelcome.Location = new Point(231, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(366, 48);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome, <admin> !";
            // 
            // pSettings
            // 
            pSettings.Controls.Add(btnSettingsA);
            pSettings.Location = new Point(3, 493);
            pSettings.Name = "pSettings";
            pSettings.Size = new Size(219, 60);
            pSettings.TabIndex = 25;
            // 
            // btnSettingsA
            // 
            btnSettingsA.FlatAppearance.BorderSize = 0;
            btnSettingsA.FlatAppearance.MouseDownBackColor = Color.FromArgb(14, 73, 104);
            btnSettingsA.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 94, 133);
            btnSettingsA.FlatStyle = FlatStyle.Flat;
            btnSettingsA.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnSettingsA.ForeColor = Color.FromArgb(170, 225, 255);
            btnSettingsA.Image = (Image)resources.GetObject("btnSettingsA.Image");
            btnSettingsA.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettingsA.Location = new Point(-16, -13);
            btnSettingsA.Name = "btnSettingsA";
            btnSettingsA.Padding = new Padding(20, 5, 5, 5);
            btnSettingsA.Size = new Size(248, 86);
            btnSettingsA.TabIndex = 17;
            btnSettingsA.Text = "            SETTINGS";
            btnSettingsA.TextAlign = ContentAlignment.MiddleLeft;
            btnSettingsA.UseVisualStyleBackColor = true;
            // 
            // DashboardA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(170, 225, 255);
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
            Name = "DashboardA";
            StartPosition = FormStartPosition.CenterScreen;
            Load += DashboardA_Load;
            flpSideBar.ResumeLayout(false);
            pMenu.ResumeLayout(false);
            pDashboard.ResumeLayout(false);
            pRecords.ResumeLayout(false);
            pRequests.ResumeLayout(false);
            pStock.ResumeLayout(false);
            pNotification.ResumeLayout(false);
            pLogout.ResumeLayout(false);
            pSettings.ResumeLayout(false);
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
        private Panel pRequests;
        private Button btnRequests;
        private Panel pStock;
        private Button btnStock;
        private Panel pNotification;
        private Button btnNotification;
        private Panel pLogout;
        private Button btnLogout;
        private Panel pSettings;
        private Button btnSettingsA;
    }
}
