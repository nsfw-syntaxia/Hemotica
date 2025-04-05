namespace Hemotica
{
    partial class RegisterHP2
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
			lblName = new Label();
			lblID = new Label();
			lblClassification = new Label();
			lblPage = new Label();
			lblOHours = new Label();
			btnNext = new ReaLTaiizor.Controls.FoxButton();
			btnBack = new ReaLTaiizor.Controls.FoxButton();
			tbxHospitalName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			tbxID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			rbtnPrivate = new ReaLTaiizor.Controls.HopeRadioButton();
			rbtnPublic = new ReaLTaiizor.Controls.HopeRadioButton();
			cmbxStart = new ReaLTaiizor.Controls.DungeonComboBox();
			cmbxEnd = new ReaLTaiizor.Controls.DungeonComboBox();
			lblStart = new Label();
			lblEnd = new Label();
			SuspendLayout();
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblName.ForeColor = Color.FromArgb(216, 85, 101);
			lblName.Location = new Point(3, 4);
			lblName.Name = "lblName";
			lblName.Size = new Size(111, 22);
			lblName.TabIndex = 22;
			lblName.Text = "Hospital Name";
			// 
			// lblID
			// 
			lblID.AutoSize = true;
			lblID.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblID.ForeColor = Color.FromArgb(216, 85, 101);
			lblID.Location = new Point(3, 70);
			lblID.Name = "lblID";
			lblID.Size = new Size(240, 22);
			lblID.TabIndex = 26;
			lblID.Text = "License Number / Registration ID";
			// 
			// lblClassification
			// 
			lblClassification.AutoSize = true;
			lblClassification.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblClassification.ForeColor = Color.FromArgb(216, 85, 101);
			lblClassification.Location = new Point(3, 136);
			lblClassification.Name = "lblClassification";
			lblClassification.Size = new Size(106, 22);
			lblClassification.TabIndex = 50;
			lblClassification.Text = "Classification";
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
			lblPage.Text = "2 / 3";
			// 
			// lblOHours
			// 
			lblOHours.AutoSize = true;
			lblOHours.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblOHours.ForeColor = Color.FromArgb(216, 85, 101);
			lblOHours.Location = new Point(3, 190);
			lblOHours.Name = "lblOHours";
			lblOHours.Size = new Size(246, 22);
			lblOHours.TabIndex = 52;
			lblOHours.Text = "Operating Hours (Monday-Friday)";
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
			btnNext.Location = new Point(203, 334);
			btnNext.Name = "btnNext";
			btnNext.OverColor = Color.FromArgb(216, 85, 101);
			btnNext.Size = new Size(120, 40);
			btnNext.TabIndex = 49;
			btnNext.Text = "NEXT";
			btnNext.Click += btnNext_Click;
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.Transparent;
			btnBack.BaseColor = Color.FromArgb(216, 85, 101);
			btnBack.BorderColor = Color.FromArgb(216, 85, 101);
			btnBack.DisabledBaseColor = Color.FromArgb(244, 148, 156);
			btnBack.DisabledBorderColor = Color.FromArgb(244, 148, 156);
			btnBack.DisabledTextColor = Color.FromArgb(244, 148, 156);
			btnBack.DownColor = Color.FromArgb(236, 124, 132);
			btnBack.EnabledCalc = true;
			btnBack.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			btnBack.ForeColor = Color.FromArgb(241, 241, 241);
			btnBack.Location = new Point(72, 334);
			btnBack.Name = "btnBack";
			btnBack.OverColor = Color.FromArgb(216, 85, 101);
			btnBack.Size = new Size(120, 40);
			btnBack.TabIndex = 71;
			btnBack.Text = "BACK";
			btnBack.Click += btnBack_Click;
			// 
			// tbxHospitalName
			// 
			tbxHospitalName.AllowPromptAsInput = true;
			tbxHospitalName.AnimateReadOnly = false;
			tbxHospitalName.AsciiOnly = false;
			tbxHospitalName.BackgroundImageLayout = ImageLayout.None;
			tbxHospitalName.BeepOnError = false;
			tbxHospitalName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxHospitalName.Depth = 0;
			tbxHospitalName.Font = new Font("Arial Narrow", 13F);
			tbxHospitalName.HidePromptOnLeave = false;
			tbxHospitalName.HideSelection = true;
			tbxHospitalName.InsertKeyMode = InsertKeyMode.Default;
			tbxHospitalName.LeadingIcon = null;
			tbxHospitalName.Location = new Point(3, 29);
			tbxHospitalName.Mask = "";
			tbxHospitalName.MaxLength = 32767;
			tbxHospitalName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxHospitalName.Name = "tbxHospitalName";
			tbxHospitalName.PasswordChar = '\0';
			tbxHospitalName.PrefixSuffixText = null;
			tbxHospitalName.PromptChar = '_';
			tbxHospitalName.ReadOnly = false;
			tbxHospitalName.RejectInputOnFirstFailure = false;
			tbxHospitalName.ResetOnPrompt = true;
			tbxHospitalName.ResetOnSpace = true;
			tbxHospitalName.RightToLeft = RightToLeft.No;
			tbxHospitalName.SelectedText = "";
			tbxHospitalName.SelectionLength = 0;
			tbxHospitalName.SelectionStart = 0;
			tbxHospitalName.ShortcutsEnabled = true;
			tbxHospitalName.Size = new Size(389, 36);
			tbxHospitalName.SkipLiterals = true;
			tbxHospitalName.TabIndex = 72;
			tbxHospitalName.TabStop = false;
			tbxHospitalName.TextAlign = HorizontalAlignment.Left;
			tbxHospitalName.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxHospitalName.TrailingIcon = null;
			tbxHospitalName.UseSystemPasswordChar = false;
			tbxHospitalName.UseTallSize = false;
			tbxHospitalName.ValidatingType = null;
			// 
			// tbxID
			// 
			tbxID.AllowPromptAsInput = true;
			tbxID.AnimateReadOnly = false;
			tbxID.AsciiOnly = false;
			tbxID.BackgroundImageLayout = ImageLayout.None;
			tbxID.BeepOnError = false;
			tbxID.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxID.Depth = 0;
			tbxID.Font = new Font("Arial Narrow", 13F);
			tbxID.HidePromptOnLeave = false;
			tbxID.HideSelection = true;
			tbxID.InsertKeyMode = InsertKeyMode.Default;
			tbxID.LeadingIcon = null;
			tbxID.Location = new Point(3, 95);
			tbxID.Mask = "";
			tbxID.MaxLength = 32767;
			tbxID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxID.Name = "tbxID";
			tbxID.PasswordChar = '\0';
			tbxID.PrefixSuffixText = null;
			tbxID.PromptChar = '_';
			tbxID.ReadOnly = false;
			tbxID.RejectInputOnFirstFailure = false;
			tbxID.ResetOnPrompt = true;
			tbxID.ResetOnSpace = true;
			tbxID.RightToLeft = RightToLeft.No;
			tbxID.SelectedText = "";
			tbxID.SelectionLength = 0;
			tbxID.SelectionStart = 0;
			tbxID.ShortcutsEnabled = true;
			tbxID.Size = new Size(389, 36);
			tbxID.SkipLiterals = true;
			tbxID.TabIndex = 73;
			tbxID.TabStop = false;
			tbxID.TextAlign = HorizontalAlignment.Left;
			tbxID.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxID.TrailingIcon = null;
			tbxID.UseSystemPasswordChar = false;
			tbxID.UseTallSize = false;
			tbxID.ValidatingType = null;
			// 
			// rbtnPrivate
			// 
			rbtnPrivate.AutoSize = true;
			rbtnPrivate.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnPrivate.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnPrivate.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnPrivate.Enable = true;
			rbtnPrivate.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnPrivate.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnPrivate.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnPrivate.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnPrivate.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnPrivate.Location = new Point(230, 162);
			rbtnPrivate.Name = "rbtnPrivate";
			rbtnPrivate.Size = new Size(83, 20);
			rbtnPrivate.TabIndex = 77;
			rbtnPrivate.TabStop = true;
			rbtnPrivate.Text = "Private";
			rbtnPrivate.UseVisualStyleBackColor = true;
			// 
			// rbtnPublic
			// 
			rbtnPublic.AutoSize = true;
			rbtnPublic.CheckedColor = Color.FromArgb(236, 124, 132);
			rbtnPublic.DisabledColor = Color.FromArgb(216, 85, 101);
			rbtnPublic.DisabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnPublic.Enable = true;
			rbtnPublic.EnabledCheckedColor = Color.FromArgb(216, 85, 101);
			rbtnPublic.EnabledStringColor = Color.FromArgb(216, 85, 101);
			rbtnPublic.EnabledUncheckedColor = Color.FromArgb(216, 85, 101);
			rbtnPublic.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			rbtnPublic.ForeColor = Color.FromArgb(236, 124, 132);
			rbtnPublic.Location = new Point(91, 162);
			rbtnPublic.Name = "rbtnPublic";
			rbtnPublic.Size = new Size(79, 20);
			rbtnPublic.TabIndex = 76;
			rbtnPublic.TabStop = true;
			rbtnPublic.Text = "Public";
			rbtnPublic.UseVisualStyleBackColor = true;
			// 
			// cmbxStart
			// 
			cmbxStart.BackColor = Color.FromArgb(241, 241, 241);
			cmbxStart.ColorA = Color.FromArgb(236, 124, 132);
			cmbxStart.ColorB = Color.FromArgb(236, 124, 132);
			cmbxStart.ColorC = Color.FromArgb(242, 241, 240);
			cmbxStart.ColorD = Color.FromArgb(253, 252, 252);
			cmbxStart.ColorE = Color.FromArgb(239, 237, 236);
			cmbxStart.ColorF = Color.FromArgb(216, 85, 101);
			cmbxStart.ColorG = Color.FromArgb(216, 85, 101);
			cmbxStart.ColorH = Color.FromArgb(244, 180, 180);
			cmbxStart.ColorI = Color.FromArgb(250, 249, 249);
			cmbxStart.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxStart.DropDownHeight = 100;
			cmbxStart.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxStart.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxStart.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxStart.FormattingEnabled = true;
			cmbxStart.HoverSelectionColor = Color.Empty;
			cmbxStart.IntegralHeight = false;
			cmbxStart.ItemHeight = 25;
			cmbxStart.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
			cmbxStart.Location = new Point(65, 215);
			cmbxStart.Name = "cmbxStart";
			cmbxStart.Size = new Size(327, 31);
			cmbxStart.StartIndex = 0;
			cmbxStart.TabIndex = 78;
			// 
			// cmbxEnd
			// 
			cmbxEnd.BackColor = Color.FromArgb(241, 241, 241);
			cmbxEnd.ColorA = Color.FromArgb(236, 124, 132);
			cmbxEnd.ColorB = Color.FromArgb(236, 124, 132);
			cmbxEnd.ColorC = Color.FromArgb(242, 241, 240);
			cmbxEnd.ColorD = Color.FromArgb(253, 252, 252);
			cmbxEnd.ColorE = Color.FromArgb(239, 237, 236);
			cmbxEnd.ColorF = Color.FromArgb(216, 85, 101);
			cmbxEnd.ColorG = Color.FromArgb(216, 85, 101);
			cmbxEnd.ColorH = Color.FromArgb(244, 180, 180);
			cmbxEnd.ColorI = Color.FromArgb(250, 249, 249);
			cmbxEnd.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxEnd.DropDownHeight = 100;
			cmbxEnd.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxEnd.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxEnd.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxEnd.FormattingEnabled = true;
			cmbxEnd.HoverSelectionColor = Color.Empty;
			cmbxEnd.IntegralHeight = false;
			cmbxEnd.ItemHeight = 25;
			cmbxEnd.Items.AddRange(new object[] { "00:00", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00", "03:30", "04:00", "04:30", "05:00", "05:30", "06:00", "06:30", "07:00", "07:30", "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30" });
			cmbxEnd.Location = new Point(65, 252);
			cmbxEnd.Name = "cmbxEnd";
			cmbxEnd.Size = new Size(327, 31);
			cmbxEnd.StartIndex = 0;
			cmbxEnd.TabIndex = 79;
			// 
			// lblStart
			// 
			lblStart.AutoSize = true;
			lblStart.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblStart.ForeColor = Color.FromArgb(216, 85, 101);
			lblStart.Location = new Point(15, 218);
			lblStart.Name = "lblStart";
			lblStart.Size = new Size(44, 22);
			lblStart.TabIndex = 80;
			lblStart.Text = "Start";
			// 
			// lblEnd
			// 
			lblEnd.AutoSize = true;
			lblEnd.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblEnd.ForeColor = Color.FromArgb(216, 85, 101);
			lblEnd.Location = new Point(15, 255);
			lblEnd.Name = "lblEnd";
			lblEnd.Size = new Size(38, 22);
			lblEnd.TabIndex = 81;
			lblEnd.Text = "End";
			// 
			// RegisterHP2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(lblEnd);
			Controls.Add(lblStart);
			Controls.Add(cmbxEnd);
			Controls.Add(cmbxStart);
			Controls.Add(rbtnPrivate);
			Controls.Add(rbtnPublic);
			Controls.Add(btnBack);
			Controls.Add(lblOHours);
			Controls.Add(lblClassification);
			Controls.Add(lblPage);
			Controls.Add(lblID);
			Controls.Add(lblName);
			Controls.Add(btnNext);
			Controls.Add(tbxHospitalName);
			Controls.Add(tbxID);
			Name = "RegisterHP2";
			Size = new Size(396, 382);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblName;
        private Label lblID;
        private Label lblClassification;
        private Label lblPage;
        private Label lblOHours;
        private ReaLTaiizor.Controls.FoxButton btnNext;
        private ReaLTaiizor.Controls.FoxButton btnBack;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxHospitalName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxID;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnPrivate;
		private ReaLTaiizor.Controls.HopeRadioButton rbtnPublic;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxStart;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxEnd;
		private Label lblStart;
		private Label lblEnd;
	}
}
