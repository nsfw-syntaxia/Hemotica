using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class ConfirmEmail : UserControl
	{
		private ForgetPassword forgetPassword;
		private Database db = new Database();

		public ConfirmEmail(ForgetPassword parent)
		{
			InitializeComponent();
			this.forgetPassword = parent;

			if (!string.IsNullOrEmpty(forgetPassword.email))
				tbxEmail.Text = forgetPassword.email;
		}

		private void btnSendCode_Click(object sender, EventArgs e)
		{
			string email = tbxEmail.Text.Trim();

			if (string.IsNullOrWhiteSpace(email))
			{
				MessageBox.Show("Please enter an email address.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			if (!db.emailExists(email))
			{
				MessageBox.Show("No account found with that email address.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string code = new Random().Next(100000, 999999).ToString();

			string subject = "REQUEST: Reset Password Code";
			string htmlBody = emailHTML(code);
			sendEmail(email, subject, htmlBody);

			forgetPassword.email = email;
			forgetPassword.code = code;
			forgetPassword.showFP2();
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

		private string emailHTML(string code)
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
					.code {{
						font-size: 20px;
						font-weight: bold;
						color: #D85565;
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
				<h2>Password Reset Request</h2>

				<div class='spacer'></div>
				<p>We received a request to reset the password associated with this email.</p>
				<p>If you initiated this request, please use the verification code <span class='code'>{code}</span> to continue.</p>
				<p>Otherwise, please ignore this email. Your account will remain secure.</p>

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