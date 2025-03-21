namespace Hemotica
{
    partial class RegisterHP1
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			lblUsername = new Label();
			lblEmail = new Label();
			lblPassword = new Label();
			lblCPassword = new Label();
			lblPage = new Label();
			cbxSPassword = new ReaLTaiizor.Controls.HopeCheckBox();
			btnNext = new ReaLTaiizor.Controls.FoxButton();
			tbxEmailAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxUsername = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxConfirmPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			SuspendLayout();
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblUsername.ForeColor = Color.FromArgb(216, 85, 101);
			lblUsername.Location = new Point(3, 70);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(80, 22);
			lblUsername.TabIndex = 18;
			lblUsername.Text = "Username";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblEmail.ForeColor = Color.FromArgb(216, 85, 101);
			lblEmail.Location = new Point(3, 4);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(111, 22);
			lblEmail.TabIndex = 20;
			lblEmail.Text = "Email Address";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblPassword.Location = new Point(3, 136);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(79, 22);
			lblPassword.TabIndex = 28;
			lblPassword.Text = "Password";
			// 
			// lblCPassword
			// 
			lblCPassword.AutoSize = true;
			lblCPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblCPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblCPassword.Location = new Point(3, 202);
			lblCPassword.Name = "lblCPassword";
			lblCPassword.Size = new Size(140, 22);
			lblCPassword.TabIndex = 30;
			lblCPassword.Text = "Confirm Password";
			// 
			// lblPage
			// 
			lblPage.AutoSize = true;
			lblPage.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblPage.ForeColor = Color.FromArgb(236, 124, 132);
			lblPage.Location = new Point(178, 297);
			lblPage.Name = "lblPage";
			lblPage.Size = new Size(38, 22);
			lblPage.TabIndex = 32;
			lblPage.Text = "1 / 2";
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
			cbxSPassword.Location = new Point(245, 268);
			cbxSPassword.Name = "cbxSPassword";
			cbxSPassword.Size = new Size(147, 20);
			cbxSPassword.TabIndex = 48;
			cbxSPassword.Text = "Show Password";
			cbxSPassword.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			btnNext.BackColor = Color.Transparent;
			btnNext.BaseColor = Color.FromArgb(216, 85, 101);
			btnNext.BorderColor = Color.FromArgb(216, 85, 101);
			btnNext.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnNext.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnNext.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnNext.DownColor = Color.FromArgb(236, 124, 132);
			btnNext.EnabledCalc = true;
			btnNext.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnNext.ForeColor = Color.FromArgb(241, 241, 241);
			btnNext.Location = new Point(137, 334);
			btnNext.Name = "btnNext";
			btnNext.OverColor = Color.FromArgb(216, 85, 101);
			btnNext.Size = new Size(120, 40);
			btnNext.TabIndex = 49;
			btnNext.Text = "NEXT";
			btnNext.Click += btnNext_Click;
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
			tbxEmailAddress.Location = new Point(3, 29);
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
			tbxEmailAddress.TabIndex = 50;
			tbxEmailAddress.TabStop = false;
			tbxEmailAddress.TextAlign = HorizontalAlignment.Left;
			tbxEmailAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxEmailAddress.TrailingIcon = null;
			tbxEmailAddress.UseSystemPasswordChar = false;
			tbxEmailAddress.UseTallSize = false;
			tbxEmailAddress.ValidatingType = null;
			// 
			// tbxUsername
			// 
			tbxUsername.AllowPromptAsInput = true;
			tbxUsername.AnimateReadOnly = false;
			tbxUsername.AsciiOnly = false;
			tbxUsername.BackgroundImageLayout = ImageLayout.None;
			tbxUsername.BeepOnError = false;
			tbxUsername.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxUsername.Depth = 0;
			tbxUsername.Font = new Font("Arial Narrow", 13F);
			tbxUsername.HidePromptOnLeave = false;
			tbxUsername.HideSelection = true;
			tbxUsername.InsertKeyMode = InsertKeyMode.Default;
			tbxUsername.LeadingIcon = null;
			tbxUsername.Location = new Point(3, 95);
			tbxUsername.Mask = "";
			tbxUsername.MaxLength = 32767;
			tbxUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxUsername.Name = "tbxUsername";
			tbxUsername.PasswordChar = '\0';
			tbxUsername.PrefixSuffixText = null;
			tbxUsername.PromptChar = '_';
			tbxUsername.ReadOnly = false;
			tbxUsername.RejectInputOnFirstFailure = false;
			tbxUsername.ResetOnPrompt = true;
			tbxUsername.ResetOnSpace = true;
			tbxUsername.RightToLeft = RightToLeft.No;
			tbxUsername.SelectedText = "";
			tbxUsername.SelectionLength = 0;
			tbxUsername.SelectionStart = 0;
			tbxUsername.ShortcutsEnabled = true;
			tbxUsername.Size = new Size(389, 36);
			tbxUsername.SkipLiterals = true;
			tbxUsername.TabIndex = 51;
			tbxUsername.TabStop = false;
			tbxUsername.TextAlign = HorizontalAlignment.Left;
			tbxUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxUsername.TrailingIcon = null;
			tbxUsername.UseSystemPasswordChar = false;
			tbxUsername.UseTallSize = false;
			tbxUsername.ValidatingType = null;
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
			tbxPassword.Location = new Point(3, 161);
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
			tbxPassword.TabIndex = 52;
			tbxPassword.TabStop = false;
			tbxPassword.TextAlign = HorizontalAlignment.Left;
			tbxPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxPassword.TrailingIcon = null;
			tbxPassword.UseSystemPasswordChar = false;
			tbxPassword.UseTallSize = false;
			tbxPassword.ValidatingType = null;
			// 
			// tbxConfirmPassword
			// 
			tbxConfirmPassword.AllowPromptAsInput = true;
			tbxConfirmPassword.AnimateReadOnly = false;
			tbxConfirmPassword.AsciiOnly = false;
			tbxConfirmPassword.BackgroundImageLayout = ImageLayout.None;
			tbxConfirmPassword.BeepOnError = false;
			tbxConfirmPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxConfirmPassword.Depth = 0;
			tbxConfirmPassword.Font = new Font("Arial Narrow", 13F);
			tbxConfirmPassword.HidePromptOnLeave = false;
			tbxConfirmPassword.HideSelection = true;
			tbxConfirmPassword.InsertKeyMode = InsertKeyMode.Default;
			tbxConfirmPassword.LeadingIcon = null;
			tbxConfirmPassword.Location = new Point(3, 227);
			tbxConfirmPassword.Mask = "";
			tbxConfirmPassword.MaxLength = 32767;
			tbxConfirmPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxConfirmPassword.Name = "tbxConfirmPassword";
			tbxConfirmPassword.PasswordChar = '\0';
			tbxConfirmPassword.PrefixSuffixText = null;
			tbxConfirmPassword.PromptChar = '_';
			tbxConfirmPassword.ReadOnly = false;
			tbxConfirmPassword.RejectInputOnFirstFailure = false;
			tbxConfirmPassword.ResetOnPrompt = true;
			tbxConfirmPassword.ResetOnSpace = true;
			tbxConfirmPassword.RightToLeft = RightToLeft.No;
			tbxConfirmPassword.SelectedText = "";
			tbxConfirmPassword.SelectionLength = 0;
			tbxConfirmPassword.SelectionStart = 0;
			tbxConfirmPassword.ShortcutsEnabled = true;
			tbxConfirmPassword.Size = new Size(389, 36);
			tbxConfirmPassword.SkipLiterals = true;
			tbxConfirmPassword.TabIndex = 53;
			tbxConfirmPassword.TabStop = false;
			tbxConfirmPassword.TextAlign = HorizontalAlignment.Left;
			tbxConfirmPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxConfirmPassword.TrailingIcon = null;
			tbxConfirmPassword.UseSystemPasswordChar = false;
			tbxConfirmPassword.UseTallSize = false;
			tbxConfirmPassword.ValidatingType = null;
			// 
			// RegisterHP1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(cbxSPassword);
			Controls.Add(lblPage);
			Controls.Add(lblCPassword);
			Controls.Add(lblPassword);
			Controls.Add(lblEmail);
			Controls.Add(lblUsername);
			Controls.Add(btnNext);
			Controls.Add(tbxEmailAddress);
			Controls.Add(tbxUsername);
			Controls.Add(tbxPassword);
			Controls.Add(tbxConfirmPassword);
			Name = "RegisterHP1";
			Size = new Size(396, 382);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblUsername;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblCPassword;
        private Label lblPage;
        private ReaLTaiizor.Controls.HopeCheckBox cbxSPassword;
        private ReaLTaiizor.Controls.FoxButton btnNext;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxEmailAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxUsername;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxConfirmPassword;
    }
}
