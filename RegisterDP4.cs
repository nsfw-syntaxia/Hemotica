using System;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using ZXing.QrCode.Internal;

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
			string hospitalAccess = "All";

			string query = @"INSERT INTO Donors ([Email Address], [Username], [Password], [First Name], [Middle Name], [Last Name], [Gender], [Birthdate], [Age], 
							 [Barangay], [City], [Province], [Contact Number], [Blood Type], [Hospital]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", donor.Email),
				new OleDbParameter("?", donor.Username),
				new OleDbParameter("?", hashedPassword),
				new OleDbParameter("?", donor.FirstName),
				new OleDbParameter("?", donor.MiddleName),
				new OleDbParameter("?", donor.LastName),
				new OleDbParameter("?", donor.Gender),
				new OleDbParameter("?", donor.Birthdate),
				new OleDbParameter("?", donor.Age),
				new OleDbParameter("?", donor.Barangay),
				new OleDbParameter("?", donor.City),
				new OleDbParameter("?", donor.Province),
				new OleDbParameter("?", donor.ContactNumber),
				new OleDbParameter("?", donor.BloodType),
				new OleDbParameter("?", hospitalAccess)
			};

			if (db.executeNonQuery(query, parameters))
			{
				MessageBox.Show("Registration successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

				string subject = "WELCOME: Hemotica Registration";
				string htmlBody = emailHTML(donor.Username);
				sendEmail(donor.Email, subject, htmlBody);

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

		private async Task sendEmail(string recipientEmail, string subject, string htmlBody)
		{
			try
			{
				using (MailMessage mail = new MailMessage())
				{
					mail.From = new MailAddress("hemotica.io@gmail.com");
					mail.To.Add(recipientEmail);
					mail.Subject = subject;
					mail.Body = htmlBody;
					mail.IsBodyHtml = true;

					using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
					{
						smtp.Credentials = new NetworkCredential("hemotica.io@gmail.com", "edus zeye hhcn fuoz");
						smtp.EnableSsl = true;
						await smtp.SendMailAsync(mail);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string emailHTML(string username)
		{
			string body = $@"
			<html>
			<head>
				<style>
					body {{
						font-family: Bahnschrift;
					}}
					h2 {{
						color: #D85565;
						font-size: 28px;
						margin-bottom: 10px;
					}}
					p {{
						font-size: 18px;
						margin-bottom: 5px;
					}}
					.footer {{
						display: flex;
						align-items: center;
						justify-content: center;
						margin-top: 30px;
					}}
					.footer-text {{
						margin-left: 50px;
						text-align: left;
					}}
					.footer-title {{
						color: #D85565;
						font-weight: bold;
						font-size: 22px;
					}}
					.footer-email {{
						font-size: 18px;
					}}
					.spacer {{
						margin-bottom: 5px;
					}}	
				</style>
			</head>
			<body>
				<h2>Welcome to Hemotica, {username}!</h2>

				<div class='spacer'></div>
				<p>Your Hemotica account registration was successful. You can now log in and access Hemotica.</p>
				<div class='spacer'></div>
				<p>We are excited to have you on board as a valued donor.</p>

				<div class='footer'>
					<div class='footer-text'>
						<div class='footer-title'>Hemotica</div>
						<div class='footer-email'>hemotica.io@gmail.com</div>
					</div>
				</div>
			</body>
			</html>";

			return body;
		}
	}
}
