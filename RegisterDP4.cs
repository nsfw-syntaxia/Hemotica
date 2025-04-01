using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class RegisterDP4 : UserControl
    {
        private Register register;
		private Donor donor;
		private Database db = new Database();

		public RegisterDP4(Register parent, Donor donor)
        {
            InitializeComponent();
            this.register = parent;
			this.donor = donor;

			cmbxBType.SelectedIndex = -1;
		}

        private void btnRegister_Click(object sender, EventArgs e)
        {
			donor.ContactNumber = tbxContactNumber.Text.Trim();
			donor.BloodType = cmbxBType.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(donor.ContactNumber) || string.IsNullOrWhiteSpace(donor.BloodType))
			{
				MessageBox.Show("Please fill all required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!ExceptionHandling.validContactNumber(donor.ContactNumber))
			{
				MessageBox.Show("Invalid contact number.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string hashedPassword = db.hashPassword(donor.Password);

			string query = @"INSERT INTO Donors ([Email Address], [Username], [Password], [First Name], [Middle Name], [Last Name], 
                            [Gender], [Age], [Barangay], [City], [Province], [Contact Number], [Blood Type]) VALUES (@Email, @Username, @Password, @FirstName, @MiddleName, @LastName, 
                            @Gender, @Age, @Barangay, @City, @Province, @ContactNumber, @BloodType)";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("@Email", donor.Email),
				new OleDbParameter("@Username", donor.Username),
				new OleDbParameter("@Password", hashedPassword),
				new OleDbParameter("@FirstName", donor.FirstName),
				new OleDbParameter("@MiddleName", donor.MiddleName),
				new OleDbParameter("@LastName", donor.LastName),
				new OleDbParameter("@Gender", donor.Gender),
				new OleDbParameter("@Age", donor.Age),
				new OleDbParameter("@Barangay", donor.Barangay),
				new OleDbParameter("@City", donor.City),
				new OleDbParameter("@Province", donor.Province),
				new OleDbParameter("@ContactNumber", donor.ContactNumber),
				new OleDbParameter("@BloodType", donor.BloodType)
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
			register.showDP3();
		}
	}
}
