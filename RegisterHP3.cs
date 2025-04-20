using System;
using System.Data;
using System.Data.OleDb;
using System.Net.Mail;
using System.Net;
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

				string subject = "WELCOME: Hemotica Registration";
				string htmlBody = emailHTML(hospital.Username);
				sendEmail(hospital.Email, subject, htmlBody);

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
				<p>We are excited to have you on board as one of our trusted hospital partners.</p>

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
