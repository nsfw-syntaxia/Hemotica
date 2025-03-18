namespace Hemotica
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            tEffect = new System.Windows.Forms.Timer(components);
            pbxLogo = new PictureBox();
            btnClose = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            lblNewPassword = new Label();
            cbxSPassword = new ReaLTaiizor.Controls.HopeCheckBox();
            btnResetPassword = new ReaLTaiizor.Controls.FoxButton();
            tbxEmailAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tbxNewPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
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
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
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
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(216, 85, 101);
            lblEmail.Location = new Point(16, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(111, 22);
            lblEmail.TabIndex = 51;
            lblEmail.Text = "Email Address";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
            lblPassword.Location = new Point(16, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 22);
            lblPassword.TabIndex = 63;
            lblPassword.Text = "New Password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            lblNewPassword.ForeColor = Color.FromArgb(216, 85, 101);
            lblNewPassword.Location = new Point(16, 288);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(174, 22);
            lblNewPassword.TabIndex = 65;
            lblNewPassword.Text = "Confirm New Password";
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
            cbxSPassword.Location = new Point(258, 354);
            cbxSPassword.Name = "cbxSPassword";
            cbxSPassword.Size = new Size(147, 20);
            cbxSPassword.TabIndex = 67;
            cbxSPassword.Text = "Show Password";
            cbxSPassword.UseVisualStyleBackColor = true;
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.Transparent;
            btnResetPassword.BaseColor = Color.FromArgb(216, 85, 101);
            btnResetPassword.BorderColor = Color.FromArgb(216, 85, 101);
            btnResetPassword.DisabledBaseColor = Color.FromArgb(244, 148, 156);
            btnResetPassword.DisabledBorderColor = Color.FromArgb(244, 148, 156);
            btnResetPassword.DisabledTextColor = Color.FromArgb(244, 148, 156);
            btnResetPassword.DownColor = Color.FromArgb(236, 124, 132);
            btnResetPassword.EnabledCalc = true;
            btnResetPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
            btnResetPassword.ForeColor = Color.FromArgb(241, 241, 241);
            btnResetPassword.Location = new Point(117, 404);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.OverColor = Color.FromArgb(216, 85, 101);
            btnResetPassword.Size = new Size(186, 40);
            btnResetPassword.TabIndex = 68;
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // tbxEmailAddress
            // 
            tbxEmailAddress.AllowPromptAsInput = true;
            tbxEmailAddress.AnimateReadOnly = false;
            tbxEmailAddress.AsciiOnly = false;
            tbxEmailAddress.BackgroundImageLayout = ImageLayout.None;
            tbxEmailAddress.BeepOnError = false;
            tbxEmailAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxEmailAddress.Depth = 0;
            tbxEmailAddress.Font = new Font("Arial Narrow", 13F);
            tbxEmailAddress.HidePromptOnLeave = false;
            tbxEmailAddress.HideSelection = true;
            tbxEmailAddress.InsertKeyMode = InsertKeyMode.Default;
            tbxEmailAddress.LeadingIcon = null;
            tbxEmailAddress.Location = new Point(16, 183);
            tbxEmailAddress.Mask = "";
            tbxEmailAddress.MaxLength = 32767;
            tbxEmailAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxEmailAddress.Name = "tbxEmailAddress";
            tbxEmailAddress.PasswordChar = '\0';
            tbxEmailAddress.PrefixSuffixText = null;
            tbxEmailAddress.PromptChar = '_';
            tbxEmailAddress.ReadOnly = false;
            tbxEmailAddress.RejectInputOnFirstFailure = false;
            tbxEmailAddress.ResetOnPrompt = true;
            tbxEmailAddress.ResetOnSpace = true;
            tbxEmailAddress.RightToLeft = RightToLeft.No;
            tbxEmailAddress.SelectedText = "";
            tbxEmailAddress.SelectionLength = 0;
            tbxEmailAddress.SelectionStart = 0;
            tbxEmailAddress.ShortcutsEnabled = true;
            tbxEmailAddress.Size = new Size(389, 36);
            tbxEmailAddress.SkipLiterals = true;
            tbxEmailAddress.TabIndex = 69;
            tbxEmailAddress.TabStop = false;
            tbxEmailAddress.TextAlign = HorizontalAlignment.Left;
            tbxEmailAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxEmailAddress.TrailingIcon = null;
            tbxEmailAddress.UseSystemPasswordChar = false;
            tbxEmailAddress.UseTallSize = false;
            tbxEmailAddress.ValidatingType = null;
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
            tbxPassword.Location = new Point(16, 248);
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
            tbxPassword.TabIndex = 70;
            tbxPassword.TabStop = false;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxPassword.TrailingIcon = null;
            tbxPassword.UseSystemPasswordChar = false;
            tbxPassword.UseTallSize = false;
            tbxPassword.ValidatingType = null;
            // 
            // tbxNewPassword
            // 
            tbxNewPassword.AllowPromptAsInput = true;
            tbxNewPassword.AnimateReadOnly = false;
            tbxNewPassword.AsciiOnly = false;
            tbxNewPassword.BackgroundImageLayout = ImageLayout.None;
            tbxNewPassword.BeepOnError = false;
            tbxNewPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            tbxNewPassword.Depth = 0;
            tbxNewPassword.Font = new Font("Arial Narrow", 13F);
            tbxNewPassword.HidePromptOnLeave = false;
            tbxNewPassword.HideSelection = true;
            tbxNewPassword.InsertKeyMode = InsertKeyMode.Default;
            tbxNewPassword.LeadingIcon = null;
            tbxNewPassword.Location = new Point(16, 313);
            tbxNewPassword.Mask = "";
            tbxNewPassword.MaxLength = 32767;
            tbxNewPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxNewPassword.Name = "tbxNewPassword";
            tbxNewPassword.PasswordChar = '\0';
            tbxNewPassword.PrefixSuffixText = null;
            tbxNewPassword.PromptChar = '_';
            tbxNewPassword.ReadOnly = false;
            tbxNewPassword.RejectInputOnFirstFailure = false;
            tbxNewPassword.ResetOnPrompt = true;
            tbxNewPassword.ResetOnSpace = true;
            tbxNewPassword.RightToLeft = RightToLeft.No;
            tbxNewPassword.SelectedText = "";
            tbxNewPassword.SelectionLength = 0;
            tbxNewPassword.SelectionStart = 0;
            tbxNewPassword.ShortcutsEnabled = true;
            tbxNewPassword.Size = new Size(389, 36);
            tbxNewPassword.SkipLiterals = true;
            tbxNewPassword.TabIndex = 71;
            tbxNewPassword.TabStop = false;
            tbxNewPassword.TextAlign = HorizontalAlignment.Left;
            tbxNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            tbxNewPassword.TrailingIcon = null;
            tbxNewPassword.UseSystemPasswordChar = false;
            tbxNewPassword.UseTallSize = false;
            tbxNewPassword.ValidatingType = null;
            // 
            // ForgetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 211, 211);
            ClientSize = new Size(420, 467);
            ControlBox = false;
            Controls.Add(btnResetPassword);
            Controls.Add(cbxSPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnClose);
            Controls.Add(pbxLogo);
            Controls.Add(tbxEmailAddress);
            Controls.Add(tbxPassword);
            Controls.Add(tbxNewPassword);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgetPassword";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += ForgetPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tEffect;
        private PictureBox pbxLogo;
        private Button btnClose;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblNewPassword;
        private ReaLTaiizor.Controls.HopeCheckBox cbxSPassword;
        private ReaLTaiizor.Controls.FoxButton btnResetPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxEmailAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxNewPassword;
    }
}