namespace Hemotica
{
    partial class RegisterDP3
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
			lblPage = new Label();
			btnNext = new ReaLTaiizor.Controls.FoxButton();
			lblProvince = new Label();
			lblBirthdate = new Label();
			btnBack = new ReaLTaiizor.Controls.FoxButton();
			tbxBirthdate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			lblCity = new Label();
			tbxProvince = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
			cmbxCity = new ReaLTaiizor.Controls.DungeonComboBox();
			lblBarangay = new Label();
			cmbxBarangay = new ReaLTaiizor.Controls.DungeonComboBox();
			SuspendLayout();
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
			lblPage.Text = "3 / 4";
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
			// lblProvince
			// 
			lblProvince.AutoSize = true;
			lblProvince.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblProvince.ForeColor = Color.FromArgb(216, 85, 101);
			lblProvince.Location = new Point(3, 70);
			lblProvince.Name = "lblProvince";
			lblProvince.Size = new Size(71, 22);
			lblProvince.TabIndex = 70;
			lblProvince.Text = "Province";
			// 
			// lblBirthdate
			// 
			lblBirthdate.AutoSize = true;
			lblBirthdate.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblBirthdate.ForeColor = Color.FromArgb(216, 85, 101);
			lblBirthdate.Location = new Point(3, 4);
			lblBirthdate.Name = "lblBirthdate";
			lblBirthdate.Size = new Size(185, 22);
			lblBirthdate.TabIndex = 75;
			lblBirthdate.Text = "Birthdate (MM/DD/YYYY)";
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
			btnBack.TabIndex = 79;
			btnBack.Text = "BACK";
			btnBack.Click += btnBack_Click;
			// 
			// tbxBirthdate
			// 
			tbxBirthdate.AllowPromptAsInput = true;
			tbxBirthdate.AnimateReadOnly = false;
			tbxBirthdate.AsciiOnly = false;
			tbxBirthdate.BackgroundImageLayout = ImageLayout.None;
			tbxBirthdate.BeepOnError = false;
			tbxBirthdate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxBirthdate.Depth = 0;
			tbxBirthdate.Font = new Font("Arial Narrow", 13F);
			tbxBirthdate.HidePromptOnLeave = false;
			tbxBirthdate.HideSelection = true;
			tbxBirthdate.InsertKeyMode = InsertKeyMode.Default;
			tbxBirthdate.LeadingIcon = null;
			tbxBirthdate.Location = new Point(3, 29);
			tbxBirthdate.Mask = "";
			tbxBirthdate.MaxLength = 32767;
			tbxBirthdate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxBirthdate.Name = "tbxBirthdate";
			tbxBirthdate.PasswordChar = '\0';
			tbxBirthdate.PrefixSuffixText = null;
			tbxBirthdate.PromptChar = '_';
			tbxBirthdate.ReadOnly = false;
			tbxBirthdate.RejectInputOnFirstFailure = false;
			tbxBirthdate.ResetOnPrompt = true;
			tbxBirthdate.ResetOnSpace = true;
			tbxBirthdate.RightToLeft = RightToLeft.No;
			tbxBirthdate.SelectedText = "";
			tbxBirthdate.SelectionLength = 0;
			tbxBirthdate.SelectionStart = 0;
			tbxBirthdate.ShortcutsEnabled = true;
			tbxBirthdate.Size = new Size(389, 36);
			tbxBirthdate.SkipLiterals = true;
			tbxBirthdate.TabIndex = 83;
			tbxBirthdate.TabStop = false;
			tbxBirthdate.TextAlign = HorizontalAlignment.Left;
			tbxBirthdate.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxBirthdate.TrailingIcon = null;
			tbxBirthdate.UseSystemPasswordChar = false;
			tbxBirthdate.UseTallSize = false;
			tbxBirthdate.ValidatingType = null;
			// 
			// lblCity
			// 
			lblCity.AutoSize = true;
			lblCity.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblCity.ForeColor = Color.FromArgb(216, 85, 101);
			lblCity.Location = new Point(3, 136);
			lblCity.Name = "lblCity";
			lblCity.Size = new Size(135, 22);
			lblCity.TabIndex = 73;
			lblCity.Text = "City / Municipality";
			// 
			// tbxProvince
			// 
			tbxProvince.AllowPromptAsInput = true;
			tbxProvince.AnimateReadOnly = false;
			tbxProvince.AsciiOnly = false;
			tbxProvince.BackgroundImageLayout = ImageLayout.None;
			tbxProvince.BeepOnError = false;
			tbxProvince.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
			tbxProvince.Depth = 0;
			tbxProvince.Enabled = false;
			tbxProvince.Font = new Font("Arial Narrow", 13F);
			tbxProvince.HidePromptOnLeave = false;
			tbxProvince.HideSelection = true;
			tbxProvince.InsertKeyMode = InsertKeyMode.Default;
			tbxProvince.LeadingIcon = null;
			tbxProvince.Location = new Point(3, 95);
			tbxProvince.Mask = "";
			tbxProvince.MaxLength = 32767;
			tbxProvince.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
			tbxProvince.Name = "tbxProvince";
			tbxProvince.PasswordChar = '\0';
			tbxProvince.PrefixSuffixText = null;
			tbxProvince.PromptChar = '_';
			tbxProvince.ReadOnly = true;
			tbxProvince.RejectInputOnFirstFailure = false;
			tbxProvince.ResetOnPrompt = true;
			tbxProvince.ResetOnSpace = true;
			tbxProvince.RightToLeft = RightToLeft.No;
			tbxProvince.SelectedText = "";
			tbxProvince.SelectionLength = 0;
			tbxProvince.SelectionStart = 0;
			tbxProvince.ShortcutsEnabled = true;
			tbxProvince.Size = new Size(389, 36);
			tbxProvince.SkipLiterals = true;
			tbxProvince.TabIndex = 86;
			tbxProvince.TabStop = false;
			tbxProvince.Text = "Cebu";
			tbxProvince.TextAlign = HorizontalAlignment.Left;
			tbxProvince.TextMaskFormat = MaskFormat.IncludeLiterals;
			tbxProvince.TrailingIcon = null;
			tbxProvince.UseSystemPasswordChar = false;
			tbxProvince.UseTallSize = false;
			tbxProvince.ValidatingType = null;
			// 
			// cmbxCity
			// 
			cmbxCity.BackColor = Color.FromArgb(241, 241, 241);
			cmbxCity.ColorA = Color.FromArgb(236, 124, 132);
			cmbxCity.ColorB = Color.FromArgb(236, 124, 132);
			cmbxCity.ColorC = Color.FromArgb(242, 241, 240);
			cmbxCity.ColorD = Color.FromArgb(253, 252, 252);
			cmbxCity.ColorE = Color.FromArgb(239, 237, 236);
			cmbxCity.ColorF = Color.FromArgb(216, 85, 101);
			cmbxCity.ColorG = Color.FromArgb(216, 85, 101);
			cmbxCity.ColorH = Color.FromArgb(244, 180, 180);
			cmbxCity.ColorI = Color.FromArgb(250, 249, 249);
			cmbxCity.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxCity.DropDownHeight = 100;
			cmbxCity.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxCity.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxCity.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxCity.FormattingEnabled = true;
			cmbxCity.HoverSelectionColor = Color.Empty;
			cmbxCity.IntegralHeight = false;
			cmbxCity.ItemHeight = 25;
			cmbxCity.Items.AddRange(new object[] { "Alcantara", "Alcoy", "Alegria", "Aloguinsan", "Argao", "Asturias", "Badian", "Balamban", "Bantayan", "Barili", "Bogo City", "Boljoon", "Borbon", "Carcar City", "Carmen", "Catmon", "Cebu City", "Compostela", "Consolacion", "Cordova", "Daanbantayan", "Dalaguete", "Danao City", "Dumanjug", "Ginatilan", "Lapu-Lapu City", "Liloan", "Madridejos", "Malabuyoc", "Mandaue City", "Medellin", "Minglanilla", "Moalboal", "Naga City", "Oslob", "Pilar", "Pinamungahan", "Poro", "Ronda", "Samboan", "San Fernando", "San Francisco", "San Remigio", "Santa Fe", "Santander", "Sibonga", "Sogod", "Tabogon", "Tabuelan", "Talisay City", "Toledo City", "Tuburan", "Tudela" });
			cmbxCity.Location = new Point(3, 161);
			cmbxCity.Name = "cmbxCity";
			cmbxCity.Size = new Size(389, 31);
			cmbxCity.StartIndex = 0;
			cmbxCity.TabIndex = 87;
			cmbxCity.SelectedIndexChanged += cmbxCity_SelectedIndexChanged;
			// 
			// lblBarangay
			// 
			lblBarangay.AutoSize = true;
			lblBarangay.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			lblBarangay.ForeColor = Color.FromArgb(216, 85, 101);
			lblBarangay.Location = new Point(3, 199);
			lblBarangay.Name = "lblBarangay";
			lblBarangay.Size = new Size(77, 22);
			lblBarangay.TabIndex = 77;
			lblBarangay.Text = "Barangay";
			// 
			// cmbxBarangay
			// 
			cmbxBarangay.BackColor = Color.FromArgb(241, 241, 241);
			cmbxBarangay.ColorA = Color.FromArgb(236, 124, 132);
			cmbxBarangay.ColorB = Color.FromArgb(236, 124, 132);
			cmbxBarangay.ColorC = Color.FromArgb(242, 241, 240);
			cmbxBarangay.ColorD = Color.FromArgb(253, 252, 252);
			cmbxBarangay.ColorE = Color.FromArgb(239, 237, 236);
			cmbxBarangay.ColorF = Color.FromArgb(216, 85, 101);
			cmbxBarangay.ColorG = Color.FromArgb(216, 85, 101);
			cmbxBarangay.ColorH = Color.FromArgb(244, 180, 180);
			cmbxBarangay.ColorI = Color.FromArgb(250, 249, 249);
			cmbxBarangay.DrawMode = DrawMode.OwnerDrawFixed;
			cmbxBarangay.DropDownHeight = 100;
			cmbxBarangay.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbxBarangay.Font = new Font("Arial Narrow", 13F, FontStyle.Bold);
			cmbxBarangay.ForeColor = Color.FromArgb(216, 85, 101);
			cmbxBarangay.FormattingEnabled = true;
			cmbxBarangay.HoverSelectionColor = Color.Empty;
			cmbxBarangay.IntegralHeight = false;
			cmbxBarangay.ItemHeight = 25;
			cmbxBarangay.Location = new Point(3, 224);
			cmbxBarangay.Name = "cmbxBarangay";
			cmbxBarangay.Size = new Size(389, 31);
			cmbxBarangay.StartIndex = 0;
			cmbxBarangay.TabIndex = 88;
			// 
			// RegisterDP3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(253, 211, 211);
			Controls.Add(cmbxCity);
			Controls.Add(tbxBirthdate);
			Controls.Add(btnBack);
			Controls.Add(lblBirthdate);
			Controls.Add(lblCity);
			Controls.Add(lblPage);
			Controls.Add(btnNext);
			Controls.Add(lblBarangay);
			Controls.Add(lblProvince);
			Controls.Add(tbxProvince);
			Controls.Add(cmbxBarangay);
			Name = "RegisterDP3";
			Size = new Size(396, 382);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label lblPage;
        private Label lblProvince;
        private Label lblBirthdate;
        private ReaLTaiizor.Controls.FoxButton btnNext;
        private ReaLTaiizor.Controls.FoxButton btnBack;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxBirthdate;
		private Label lblCity;
		private ReaLTaiizor.Controls.MaterialMaskedTextBox tbxProvince;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxCity;
		private Label lblBarangay;
		private ReaLTaiizor.Controls.DungeonComboBox cmbxBarangay;
	}
}
