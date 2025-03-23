namespace Hemotica
{
	partial class ChangePassword
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
			cbxSPassword = new ReaLTaiizor.Controls.HopeCheckBox();
			lblNewPassword = new Label();
			lblPassword = new Label();
			tbxPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxNewPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			btnResetPassword = new ReaLTaiizor.Controls.FoxButton();
			lblL1Instruction = new Label();
			SuspendLayout();
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
			cbxSPassword.Location = new Point(245, 176);
			cbxSPassword.Name = "cbxSPassword";
			cbxSPassword.Size = new Size(147, 20);
			cbxSPassword.TabIndex = 74;
			cbxSPassword.Text = "Show Password";
			cbxSPassword.UseVisualStyleBackColor = true;
			// 
			// lblNewPassword
			// 
			lblNewPassword.AutoSize = true;
			lblNewPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblNewPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblNewPassword.Location = new Point(3, 110);
			lblNewPassword.Name = "lblNewPassword";
			lblNewPassword.Size = new Size(174, 22);
			lblNewPassword.TabIndex = 73;
			lblNewPassword.Text = "Confirm New Password";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblPassword.ForeColor = Color.FromArgb(216, 85, 101);
			lblPassword.Location = new Point(3, 45);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(113, 22);
			lblPassword.TabIndex = 72;
			lblPassword.Text = "New Password";
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
			tbxPassword.Location = new Point(3, 70);
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
			tbxPassword.TabIndex = 75;
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
			tbxNewPassword.Location = new Point(3, 135);
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
			tbxNewPassword.TabIndex = 76;
			tbxNewPassword.TabStop = false;
			tbxNewPassword.TextAlign = HorizontalAlignment.Left;
			tbxNewPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxNewPassword.TrailingIcon = null;
			tbxNewPassword.UseSystemPasswordChar = false;
			tbxNewPassword.UseTallSize = false;
			tbxNewPassword.ValidatingType = null;
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
			btnResetPassword.Location = new Point(105, 218);
			btnResetPassword.Name = "btnResetPassword";
			btnResetPassword.OverColor = Color.FromArgb(216, 85, 101);
			btnResetPassword.Size = new Size(186, 40);
			btnResetPassword.TabIndex = 77;
			btnResetPassword.Text = "RESET PASSWORD";
			btnResetPassword.Click += btnResetPassword_Click;
			// 
			// lblL1Instruction
			// 
			lblL1Instruction.AutoSize = true;
			lblL1Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL1Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL1Instruction.Location = new Point(63, 4);
			lblL1Instruction.Name = "lblL1Instruction";
			lblL1Instruction.Size = new Size(270, 22);
			lblL1Instruction.TabIndex = 84;
			lblL1Instruction.Text = "You may now change your password.";
			// 
			// ChangePassword
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblL1Instruction);
			Controls.Add(btnResetPassword);
			Controls.Add(cbxSPassword);
			Controls.Add(lblNewPassword);
			Controls.Add(lblPassword);
			Controls.Add(tbxPassword);
			Controls.Add(tbxNewPassword);
			Name = "ChangePassword";
			Size = new Size(396, 266);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ReaLTaiizor.Controls.HopeCheckBox cbxSPassword;
		private Label lblNewPassword;
		private Label lblPassword;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxPassword;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxNewPassword;
		private ReaLTaiizor.Controls.FoxButton btnResetPassword;
		private Label lblL1Instruction;
	}
}
