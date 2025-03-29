using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterHP3 : UserControl
    {
        private Register register;
		private Database db = new Database();

		public RegisterHP3(Register parent)
        {
            InitializeComponent();
            this.register = parent;

			cmbxStart.SelectedIndex = -1;
			cmbxEnd.SelectedIndex = -1;
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
            register.showHP2();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
			string weekendStart = cmbxStart.SelectedItem?.ToString();
			string weekendEnd = cmbxEnd.SelectedItem?.ToString();
            string address = tbxHospitalAddress.Text.Trim();
			string contactNumber = tbxContactNumber.Text.Trim();

			if (string.IsNullOrWhiteSpace(weekendStart) || string.IsNullOrWhiteSpace(weekendEnd) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(contactNumber))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!validPhoneNumber(contactNumber))
			{
				MessageBox.Show("Invalid contact number.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.WeekendStart = weekendStart;
			register.WeekendEnd = weekendEnd;
			register.HospitalAddress = address;
			register.ContactNumber = contactNumber;

			string hashedPassword = db.hashPassword(register.Password);

			string query = @"INSERT INTO Hospitals ([Email Address], [Username], [Password], [Hospital Name], [License Number], [Classification], 
							[Operating Hours (Weekdays) Start], [Operating Hours (Weekdays) End], [Operating Hours (Weekend) Start], [Operating Hours (Weekend) End], 
							[Address], [Contact Number]) VALUES (@Email, @Username, @Password, @HospitalName, @LicenseNumber, @Classification, 
                            @WeekdayStart, @WeekdayEnd, @WeekendStart, @WeekendEnd, @Address, @ContactNumber)";

			OleDbParameter[] parameters = {
				new OleDbParameter("@Email", register.EmailAddress),
				new OleDbParameter("@Username", register.Username),
				new OleDbParameter("@Password", hashedPassword),
				new OleDbParameter("@HospitalName", register.HospitalName),
				new OleDbParameter("@LicenseNumber", register.LicenseID),
				new OleDbParameter("@Classification", register.Classification),
				new OleDbParameter("@WeekdayStart", register.WeekdaysStart),
				new OleDbParameter("@WeekdayEnd", register.WeekdaysEnd),
				new OleDbParameter("@WeekendStart", register.WeekendStart),
				new OleDbParameter("@WeekendEnd", register.WeekendEnd),
				new OleDbParameter("@Address", register.HospitalAddress),
				new OleDbParameter("@ContactNumber", register.ContactNumber)
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
				MessageBox.Show("Registration failed!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool validPhoneNumber(string number)
		{
			return Regex.IsMatch(number, @"^(\(\d{3}\) \d{3}-\d{4}|\d{10,15})$");
		}
	}
}
