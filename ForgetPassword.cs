using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
    public partial class ForgetPassword : Form
    {
		private Database db = new Database();

		public string email { get; set; }
		public string code { get; set; }

		public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            btnSettings();

            int centerX = this.Owner.Location.X + (this.Owner.Width - this.Width) / 2;
            int centerY = this.Owner.Location.Y + (this.Owner.Height - this.Height) / 2;
            this.Location = new Point(centerX, centerY);

            tEffect.Start();
            showFP1();
		}

        private void btnEffects(System.Windows.Forms.Button button, Color highlightColor)
        {
            button.FlatAppearance.BorderSize = 0;

            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(50, highlightColor);
            button.MouseLeave += (s, e) => button.BackColor = Color.Transparent;
        }

        private void btnSettings()
        {
            btnEffects(btnClose, Color.Red);
        }

        private void tEffect_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.07;
            }
            else
            {
                tEffect.Stop();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

		public void showFP1()
		{
			flpForgetPassword.Controls.Clear();
            ConfirmEmail confirmEmail = new ConfirmEmail(this);
            flpForgetPassword.Controls.Add(confirmEmail);
		}

		public void showFP2()
		{
			flpForgetPassword.Controls.Clear();
			ConfirmCode confirmCode = new ConfirmCode(this);
			flpForgetPassword.Controls.Add(confirmCode);
		}

		public void showFP3()
		{
			flpForgetPassword.Controls.Clear();
			ChangePassword changePassword = new ChangePassword(this);
			flpForgetPassword.Controls.Add(changePassword);
		}

		public string getUserType(string email)
		{
			string query = @"SELECT UserType FROM (SELECT [Email Address] AS Email, 'Donor' AS UserType FROM Donors WHERE [Email Address] = ? UNION
							 SELECT [Email Address] AS Email, 'Hospital' AS UserType FROM Hospitals WHERE [Email Address] = ?) AS UserCheck WHERE Email = ?";

			using (OleDbConnection conn = db.getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("?", email);
				cmd.Parameters.AddWithValue("?", email);
				cmd.Parameters.AddWithValue("?", email);

				try
				{
					conn.Open();
					object result = cmd.ExecuteScalar();
					return result?.ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}

		public bool updatePassword(string email, string newPassword, string userType)
		{
			string hashedPassword = db.hashPassword(newPassword);

			string query = "";

			if (userType == "Donor")
				query = "UPDATE Donors SET [Password] = ? WHERE [Email Address] = ?";
			else if (userType == "Hospital")
				query = "UPDATE Hospitals SET [Password] = ? WHERE [Email Address] = ?";
			else
				return false;

			using (OleDbConnection conn = db.getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("?", hashedPassword);
				cmd.Parameters.AddWithValue("?", email);

				try
				{
					conn.Open();
					int rowsAffected = cmd.ExecuteNonQuery();
					return rowsAffected > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}
	}
}
