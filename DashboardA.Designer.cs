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
            panel1 = new Panel();
            flpDashboard = new FlowLayoutPanel();
            lblWelcome = new Label();
            flpSideBar.SuspendLayout();
            pMenu.SuspendLayout();
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
            flpSideBar.Controls.Add(panel1);
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
            pMenu.Size = new Size(219, 50);
            pMenu.TabIndex = 8;
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Bahnschrift", 15F, FontStyle.Bold);
            btnMenu.ForeColor = Color.FromArgb(170, 225, 255);
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(-16, -18);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(20, 5, 5, 5);
            btnMenu.Size = new Size(248, 86);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "            MENU";
            btnMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 50);
            panel1.TabIndex = 9;
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
        private Panel panel1;
        private Button btnMenu;
    }
}
