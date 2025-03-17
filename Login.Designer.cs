namespace Hemotica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tEffect = new System.Windows.Forms.Timer(components);
            pbxLogo = new PictureBox();
            pbxRegister = new PictureBox();
            btnClose = new Button();
            lblSIGNUP = new Label();
            lblAHAA = new Label();
            lblEU = new Label();
            cbxSPassword = new ReaLTaiizor.Controls.HopeCheckBox();
            lblPassword = new Label();
            lblForgetPassword = new Label();
            btnLogin = new ReaLTaiizor.Controls.FoxButton();
            tbxUnEA = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
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
            // lblSIGNUP
            // 
            lblSIGNUP.AutoSize = true;
            lblSIGNUP.Cursor = Cursors.Hand;
            lblSIGNUP.Font = new Font("Arial Narrow", 13F, FontStyle.Bold | FontStyle.Underline);
            lblSIGNUP.ForeColor = Color.FromArgb(216, 85, 101);
            lblSIGNUP.Location = new Point(175, 523);
            lblSIGNUP.Name = "lblSIGNUP";
            lblSIGNUP.Size = new Size(71, 22);
            lblSIGNUP.TabIndex = 53;
            lblSIGNUP.Text = "SIGN UP";
            lblSIGNUP.Click += lblSIGNUP_Click;
            // 
            // lblAHAA
            // 
            lblAHAA.AutoSize = true;
            lblAHAA.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblAHAA.ForeColor = Color.FromArgb(236, 124, 132);
            lblAHAA.Location = new Point(123, 496);
            lblAHAA.Name = "lblAHAA";
            lblAHAA.Size = new Size(174, 22);
            lblAHAA.TabIndex = 52;
            lblAHAA.Text = "Don't have an account?";
            // 
            // lblEU
            // 
            lblEU.AutoSize = true;
            lblEU.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblEU.ForeColor = Color.FromArgb(216, 85, 101);
            lblEU.Location = new Point(16, 212);
            lblEU.Name = "lblEU";
            lblEU.Size = new Size(193, 22);
            lblEU.TabIndex = 54;
            lblEU.Text = "Username / Email Address";
            // 
            // cbxSPassword
            // 
            cbxSPassword.AutoSize = true;
            cbxSPassword.CheckedColor = Color.FromArgb(236, 124, 132);
            cbxSPassword.DisabledColor = Color.FromArgb(241, 241, 241);
            cbxSPassword.DisabledStringColor = Color.FromArgb(241, 241, 241);
            cbxSPassword.Enable = true;
            cbxSPassword.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
            cbxSPassword.EnabledStringColor = Color.FromArgb(216, 85, 101);
            cbxSPassword.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
            cbxSPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            cbxSPassword.ForeColor = Color.FromArgb(236, 124, 132);
            cbxSPassword.Location = new Point(258, 344);
            cbxSPassword.Name = "cbxSPassword";
            cbxSPassword.Size = new Size(147, 20);
            cbxSPassword.TabIndex = 57;
            cbxSPassword.Text = "Show Password";
            cbxSPassword.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
            lblPassword.Location = new Point(16, 278);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 22);
            lblPassword.TabIndex = 56;
            lblPassword.Text = "Password";
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.Cursor = Cursors.Hand;
            lblForgetPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblForgetPassword.ForeColor = Color.FromArgb(216, 85, 101);
            lblForgetPassword.Location = new Point(141, 454);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(139, 22);
            lblForgetPassword.TabIndex = 59;
            lblForgetPassword.Text = "Forgot Password?";
            lblForgetPassword.Click += lblForgetPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BaseColor = Color.FromArgb(216, 85, 101);
            btnLogin.BorderColor = Color.FromArgb(216, 85, 101);
            btnLogin.DisabledBaseColor = Color.FromArgb(244, 148, 156);
            btnLogin.DisabledBorderColor = Color.FromArgb(244, 148, 156);
            btnLogin.DisabledTextColor = Color.FromArgb(244, 148, 156);
            btnLogin.DownColor = Color.FromArgb(236, 124, 132);
            btnLogin.EnabledCalc = true;
            btnLogin.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(241, 241, 241);
            btnLogin.Location = new Point(150, 394);
            btnLogin.Name = "btnLogin";
            btnLogin.OverColor = Color.FromArgb(216, 85, 101);
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 60;
            btnLogin.Text = "LOGIN";
            // 
            // tbxUnEA
            // 
            tbxUnEA.AllowPromptAsInput = true;
            tbxUnEA.AnimateReadOnly = false;
            tbxUnEA.AsciiOnly = false;
            tbxUnEA.BackgroundImageLayout = ImageLayout.None;
            tbxUnEA.BeepOnError = false;
            tbxUnEA.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxUnEA.Depth = 0;
            tbxUnEA.Font = new Font("Arial Narrow", 13F);
            tbxUnEA.HidePromptOnLeave = false;
            tbxUnEA.HideSelection = true;
            tbxUnEA.InsertKeyMode = InsertKeyMode.Default;
            tbxUnEA.LeadingIcon = null;
            tbxUnEA.Location = new Point(16, 237);
            tbxUnEA.Mask = "";
            tbxUnEA.MaxLength = 32767;
            tbxUnEA.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxUnEA.Name = "tbxUnEA";
            tbxUnEA.PasswordChar = '\0';
            tbxUnEA.PrefixSuffixText = null;
            tbxUnEA.PromptChar = '_';
            tbxUnEA.ReadOnly = false;
            tbxUnEA.RejectInputOnFirstFailure = false;
            tbxUnEA.ResetOnPrompt = true;
            tbxUnEA.ResetOnSpace = true;
            tbxUnEA.RightToLeft = RightToLeft.No;
            tbxUnEA.SelectedText = "";
            tbxUnEA.SelectionLength = 0;
            tbxUnEA.SelectionStart = 0;
            tbxUnEA.ShortcutsEnabled = true;
            tbxUnEA.Size = new Size(389, 36);
            tbxUnEA.SkipLiterals = true;
            tbxUnEA.TabIndex = 61;
            tbxUnEA.TabStop = false;
            tbxUnEA.TextAlign = HorizontalAlignment.Left;
            tbxUnEA.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxUnEA.TrailingIcon = null;
            tbxUnEA.UseSystemPasswordChar = false;
            tbxUnEA.UseTallSize = false;
            tbxUnEA.ValidatingType = null;
            // 
            // tbxPassword
            // 
            tbxPassword.AllowPromptAsInput = true;
            tbxPassword.AnimateReadOnly = false;
            tbxPassword.AsciiOnly = false;
            tbxPassword.BackgroundImageLayout = ImageLayout.None;
            tbxPassword.BeepOnError = false;
            tbxPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxPassword.Depth = 0;
            tbxPassword.Font = new Font("Arial Narrow", 13F);
            tbxPassword.HidePromptOnLeave = false;
            tbxPassword.HideSelection = true;
            tbxPassword.InsertKeyMode = InsertKeyMode.Default;
            tbxPassword.LeadingIcon = null;
            tbxPassword.Location = new Point(16, 303);
            tbxPassword.Mask = "";
            tbxPassword.MaxLength = 32767;
            tbxPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '\0';
            tbxPassword.PrefixSuffixText = null;
            tbxPassword.PromptChar = '_';
            tbxPassword.ReadOnly = false;
            tbxPassword.RejectInputOnFirstFailure = false;
            tbxPassword.ResetOnPrompt = true;
            tbxPassword.ResetOnSpace = true;
            tbxPassword.RightToLeft = RightToLeft.No;
            tbxPassword.SelectedText = "";
            tbxPassword.SelectionLength = 0;
            tbxPassword.SelectionStart = 0;
            tbxPassword.ShortcutsEnabled = true;
            tbxPassword.Size = new Size(389, 36);
            tbxPassword.SkipLiterals = true;
            tbxPassword.TabIndex = 62;
            tbxPassword.TabStop = false;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxPassword.TrailingIcon = null;
            tbxPassword.UseSystemPasswordChar = false;
            tbxPassword.UseTallSize = false;
            tbxPassword.ValidatingType = null;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(420, 568);
            ControlBox = false;
            Controls.Add(btnLogin);
            Controls.Add(lblForgetPassword);
            Controls.Add(cbxSPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEU);
            Controls.Add(lblSIGNUP);
            Controls.Add(lblAHAA);
            Controls.Add(btnClose);
            Controls.Add(pbxRegister);
            Controls.Add(pbxLogo);
            Controls.Add(tbxUnEA);
            Controls.Add(tbxPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += Login_Load;
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
        private Label lblSIGNUP;
        private Label lblAHAA;
        private Label lblEU;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxEU;
        private ReaLTaiizor.Controls.HopeCheckBox cbxSPassword;
        private Label lblPassword;
        private Label lblForgetPassword;
        private ReaLTaiizor.Controls.FoxButton btnLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxUnEA;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxPassword;
    }
}