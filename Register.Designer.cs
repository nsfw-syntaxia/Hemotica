namespace Hemotica
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            tEffect = new System.Windows.Forms.Timer(components);
            pbxLogo = new PictureBox();
            pbxRegister = new PictureBox();
            btnClose = new Button();
            lSelectUser = new Label();
            cmbxRUser = new ReaLTaiizor.Controls.ComboBoxEdit();
            flpUserRegister = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegister).BeginInit();
            SuspendLayout();
            // 
            // tEffect
            // 
            tEffect.Enabled = true;
            tEffect.Interval = 1;
            tEffect.Tick += tEffect_Tick;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = (Image)resources.GetObject("pbxLogo.Image");
            pbxLogo.Location = new Point(147, 17);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(125, 125);
            pbxLogo.TabIndex = 2;
            pbxLogo.TabStop = false;
            // 
            // pbxRegister
            // 
            pbxRegister.Image = (Image)resources.GetObject("pbxRegister.Image");
            pbxRegister.Location = new Point(97, 141);
            pbxRegister.Name = "pbxRegister";
            pbxRegister.Size = new Size(225, 55);
            pbxRegister.TabIndex = 3;
            pbxRegister.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(383, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.TabIndex = 4;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lSelectUser
            // 
            lSelectUser.AutoSize = true;
            lSelectUser.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lSelectUser.ForeColor = Color.FromArgb(216, 85, 101);
            lSelectUser.Location = new Point(12, 218);
            lSelectUser.Name = "lSelectUser";
            lSelectUser.Size = new Size(122, 22);
            lSelectUser.TabIndex = 11;
            lSelectUser.Text = "Select user type";
            // 
            // cmbxRUser
            // 
            cmbxRUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbxRUser.BackColor = Color.FromArgb(253, 211, 211);
            cmbxRUser.DrawMode = DrawMode.OwnerDrawFixed;
            cmbxRUser.DropDownHeight = 100;
            cmbxRUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxRUser.Font = new Font("Arial Narrow", 13F);
            cmbxRUser.ForeColor = Color.FromArgb(216, 85, 101);
            cmbxRUser.FormattingEnabled = true;
            cmbxRUser.HoverSelectionColor = Color.FromArgb(241, 241, 241);
            cmbxRUser.IntegralHeight = false;
            cmbxRUser.ItemHeight = 25;
            cmbxRUser.Items.AddRange(new object[] { "Donor", "Hospital" });
            cmbxRUser.Location = new Point(12, 246);
            cmbxRUser.Name = "cmbxRUser";
            cmbxRUser.Size = new Size(396, 31);
            cmbxRUser.StartIndex = 0;
            cmbxRUser.TabIndex = 12;
            // 
            // flpUserRegister
            // 
            flpUserRegister.Location = new Point(12, 283);
            flpUserRegister.Name = "flpUserRegister";
            flpUserRegister.Size = new Size(396, 290);
            flpUserRegister.TabIndex = 13;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(420, 615);
            ControlBox = false;
            Controls.Add(flpUserRegister);
            Controls.Add(cmbxRUser);
            Controls.Add(lSelectUser);
            Controls.Add(btnClose);
            Controls.Add(pbxRegister);
            Controls.Add(pbxLogo);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxRegister).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tEffect;
        private PictureBox pbxLogo;
        private PictureBox pbxRegister;
        private Button btnClose;
        private Label lSelectUser;
        private ReaLTaiizor.Controls.ComboBoxEdit cmbxRUser;
        private FlowLayoutPanel flpUserRegister;
    }
}