namespace Hemotica
{
	partial class ConfirmEmail
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
			lblL2Instruction = new Label();
			lblEmail = new Label();
			lblL1Instruction = new Label();
			lblHeader = new Label();
			btnSendCode = new ReaLTaiizor.Controls.FoxButton();
			tbxEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			SuspendLayout();
			// 
			// lblL2Instruction
			// 
			lblL2Instruction.AutoSize = true;
			lblL2Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL2Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL2Instruction.Location = new Point(50, 80);
			lblL2Instruction.Name = "lblL2Instruction";
			lblL2Instruction.Size = new Size(296, 22);
			lblL2Instruction.TabIndex = 86;
			lblL2Instruction.Text = "please enter your email address to verify.\r\n";
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblEmail.ForeColor = Color.FromArgb(216, 85, 101);
			lblEmail.Location = new Point(3, 131);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(111, 22);
			lblEmail.TabIndex = 84;
			lblEmail.Text = "Email Address";
			// 
			// lblL1Instruction
			// 
			lblL1Instruction.AutoSize = true;
			lblL1Instruction.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblL1Instruction.ForeColor = Color.FromArgb(236, 124, 132);
			lblL1Instruction.Location = new Point(56, 53);
			lblL1Instruction.Name = "lblL1Instruction";
			lblL1Instruction.Size = new Size(284, 22);
			lblL1Instruction.TabIndex = 83;
			lblL1Instruction.Text = "Before you can change your password,\r\n";
			// 
			// lblHeader
			// 
			lblHeader.AutoSize = true;
			lblHeader.Font = new Font("Arial Narrow", 15F, FontStyle.Bold);
			lblHeader.ForeColor = Color.FromArgb(216, 85, 101);
			lblHeader.Location = new Point(54, 4);
			lblHeader.Name = "lblHeader";
			lblHeader.Size = new Size(289, 24);
			lblHeader.TabIndex = 82;
			lblHeader.Text = "FIND YOUR HEMOTICA ACCOUNT !";
			// 
			// btnSendCode
			// 
			btnSendCode.BackColor = Color.Transparent;
			btnSendCode.BaseColor = Color.FromArgb(216, 85, 101);
			btnSendCode.BorderColor = Color.FromArgb(216, 85, 101);
			btnSendCode.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnSendCode.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnSendCode.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnSendCode.DownColor = Color.FromArgb(236, 124, 132);
			btnSendCode.EnabledCalc = true;
			btnSendCode.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnSendCode.ForeColor = Color.FromArgb(241, 241, 241);
			btnSendCode.Location = new Point(105, 218);
			btnSendCode.Name = "btnSendCode";
			btnSendCode.OverColor = Color.FromArgb(216, 85, 101);
			btnSendCode.Size = new Size(186, 40);
			btnSendCode.TabIndex = 87;
			btnSendCode.Text = "SEND ME A CODE";
			btnSendCode.Click += btnSendCode_Click;
			// 
			// tbxEmail
			// 
			tbxEmail.AllowPromptAsInput = true;
			tbxEmail.AnimateReadOnly = false;
			tbxEmail.AsciiOnly = false;
			tbxEmail.BackgroundImageLayout = ImageLayout.None;
			tbxEmail.BeepOnError = false;
			tbxEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxEmail.Depth = 0;
			tbxEmail.Font = new Font("Arial Narrow", 13F);
			tbxEmail.HidePromptOnLeave = false;
			tbxEmail.HideSelection = true;
			tbxEmail.InsertKeyMode = InsertKeyMode.Default;
			tbxEmail.LeadingIcon = null;
			tbxEmail.Location = new Point(3, 154);
			tbxEmail.Mask = "";
			tbxEmail.MaxLength = 32767;
			tbxEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxEmail.Name = "tbxEmail";
			tbxEmail.PasswordChar = '\0';
			tbxEmail.PrefixSuffixText = null;
			tbxEmail.PromptChar = '_';
			tbxEmail.ReadOnly = false;
			tbxEmail.RejectInputOnFirstFailure = false;
			tbxEmail.ResetOnPrompt = true;
			tbxEmail.ResetOnSpace = true;
			tbxEmail.RightToLeft = RightToLeft.No;
			tbxEmail.SelectedText = "";
			tbxEmail.SelectionLength = 0;
			tbxEmail.SelectionStart = 0;
			tbxEmail.ShortcutsEnabled = true;
			tbxEmail.Size = new Size(389, 36);
			tbxEmail.SkipLiterals = true;
			tbxEmail.TabIndex = 88;
			tbxEmail.TabStop = false;
			tbxEmail.TextAlign = HorizontalAlignment.Left;
			tbxEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxEmail.TrailingIcon = null;
			tbxEmail.UseSystemPasswordChar = false;
			tbxEmail.UseTallSize = false;
			tbxEmail.ValidatingType = null;
			// 
			// ConfirmationEmail
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(btnSendCode);
			Controls.Add(lblL2Instruction);
			Controls.Add(lblEmail);
			Controls.Add(lblL1Instruction);
			Controls.Add(lblHeader);
			Controls.Add(tbxEmail);
			Name = "ConfirmationEmail";
			Size = new Size(396, 266);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblL2Instruction;
		private Label lblEmail;
		private Label lblL1Instruction;
		private Label lblHeader;
		private ReaLTaiizor.Controls.FoxButton btnSendCode;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxEmail;
	}
}
