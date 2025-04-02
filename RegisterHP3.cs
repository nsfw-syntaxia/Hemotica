using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterHP3 : UserControl
    {
        private Register register;
		private Hospital hospital;
		private Database db = new Database();

		public RegisterHP3(Register parent, Hospital hospital)
        {
            InitializeComponent();
            this.register = parent;
			this.hospital = hospital;

			cmbxStart.SelectedIndex = -1;
			cmbxEnd.SelectedIndex = -1;
		}

        private void btnRegister_Click(object sender, EventArgs e)
        {
			hospital.WeekendStart = cmbxStart.SelectedItem?.ToString();
			hospital.WeekendEnd = cmbxEnd.SelectedItem?.ToString();
            hospital.Address = tbxHospitalAddress.Text.Trim();
			hospital.ContactNumber = tbxContactNumber.Text.Trim();

			if (string.IsNullOrWhiteSpace(hospital.WeekendStart) || string.IsNullOrWhiteSpace(hospital.WeekendEnd) || 
				string.IsNullOrWhiteSpace(hospital.Address) || string.IsNullOrWhiteSpace(hospital.ContactNumber))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ExceptionHandling.validContactNumber(hospital.ContactNumber))
			{
				MessageBox.Show("Invalid contact number.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string hashedPassword = db.hashPassword(hospital.Password);

			string query = @"INSERT INTO Hospitals ([Email Address], [Username], [Password], [Hospital Name], [License Number], [Classification], 
							[Operating Hours (Weekdays) Start], [Operating Hours (Weekdays) End], [Operating Hours (Weekend) Start], [Operating Hours (Weekend) End], 
							[Address], [Contact Number]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", hospital.Email),
				new OleDbParameter("?", hospital.Username),
				new OleDbParameter("?", hashedPassword),
				new OleDbParameter("?", hospital.HospitalName),
				new OleDbParameter("?", hospital.LicenseNumber),
				new OleDbParameter("?", hospital.Classification),
				new OleDbParameter("?", hospital.WeekdayStart),
				new OleDbParameter("?", hospital.WeekdayEnd),
				new OleDbParameter("?", hospital.WeekendStart),
				new OleDbParameter("?", hospital.WeekendEnd),
				new OleDbParameter("?", hospital.Address),
				new OleDbParameter("?", hospital.ContactNumber)
			};

			if (db.executeNonQuery(query, parameters))
			{
				MessageBox.Show("Registration successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				register.Opacity = 0;

				if (register.Owner is Home home)
				{
					home.showLogin();
				}

				register.Close();
			}
			else
			{
				MessageBox.Show("Registration failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			register.showHP2();
		}
	}
}
