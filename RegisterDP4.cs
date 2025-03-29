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

        public RegisterDP4(Register parent)
        {
            InitializeComponent();
            this.register = parent;
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			register.showDP3();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
			string contactNumber = tbxContactNumber.Text.Trim();
			string bloodType = cmbxBType.SelectedItem?.ToString();

			if (string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(bloodType))
			{
				MessageBox.Show("Please fill the required fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			register.ContactNumber = contactNumber;
			register.BloodType = bloodType;

			Database db = new Database();
			string hashedPassword = db.hashPassword(register.Password);

			string query = @"INSERT INTO Donors ([Email Address], [Username], [Password], [First Name], [Middle Name], [Last Name], 
                            [Gender], [Age], [Barangay], [City], [Province], [Contact Number], [Blood Type]) VALUES (@Email, @Username, @Password, @FirstName, @MiddleName, @LastName, 
                            @Gender, @Age, @Barangay, @City, @Province, @ContactNumber, @BloodType)";

			OleDbParameter[] parameters = {
				new OleDbParameter("@Email", register.EmailAddress),
				new OleDbParameter("@Username", register.Username),
				new OleDbParameter("@Password", hashedPassword),
				new OleDbParameter("@FirstName", register.FirstName),
				new OleDbParameter("@MiddleName", register.MiddleName),
				new OleDbParameter("@LastName", register.LastName),
				new OleDbParameter("@Gender", register.Gender),
				new OleDbParameter("@Age", register.Age),
				new OleDbParameter("@Barangay", register.Barangay),
				new OleDbParameter("@City", register.City),
				new OleDbParameter("@Province", register.Province),
				new OleDbParameter("@ContactNumber", register.ContactNumber),
				new OleDbParameter("@BloodType", register.BloodType)
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
    }
}
