using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class Login : Form
    {
		private Database db = new Database();

		int i;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnSettings();

            int centerX = Home.parentX + (this.Owner.Width - this.Width) / 2;
            int startY = Home.parentY - this.Height;
            int targetY = Home.parentY + (this.Owner.Height - this.Height) / 2;

            this.Location = new Point(centerX, startY);

            i = targetY;
            tEffect.Start();
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
            if (Opacity < 1)
            {
                Opacity += 0.07;
            }

            int currentY = this.Location.Y + 30;
            if (currentY >= i)
            {
                currentY = i;
                tEffect.Stop();
            }

            this.Location = new Point(this.Location.X, currentY);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

        private void lblSIGNUP_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (this.Owner is Home home)
            {
                home.showRegister();
            }

            this.Close();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;

            if (this.Owner is Home home)
            {
                home.showForgetPassword();
            }

            this.Close();
        }
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			string usernameEmail = tbxUnEA.Text.Trim();
			string password = tbxPassword.Text.Trim();

			if (string.IsNullOrWhiteSpace(usernameEmail) || string.IsNullOrWhiteSpace(password))
			{
				MessageBox.Show("Please enter complete credentials.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string userQuery = @"SELECT Username, [Email Address], Password, 'Donor' AS UserType FROM Donors WHERE Username = @usernameEmail OR [Email Address] = @usernameEmail
                                 UNION SELECT Username, [Email Address], Password, 'Hospital' AS UserType FROM Hospitals WHERE Username = @usernameEmail OR [Email Address] = @usernameEmail";
			OleDbParameter[] userParamaters = { new OleDbParameter("@usernameEmail", usernameEmail) };
			DataTable userResult = db.executeQuery(userQuery, userParamaters);

			string adminQuery = "SELECT Username, Password, 'Admin' AS UserType FROM Admin WHERE Username = @username";
			OleDbParameter[] adminParameters = { new OleDbParameter("@username", usernameEmail) };
			DataTable adminResult = db.executeQuery(adminQuery, adminParameters);

			Form dashboard = null;
			string username = null;
			string userType = null;

			foreach (DataRow row in userResult.Rows)
			{
				string userUsername = row["Username"].ToString();
				string userEmail = row["Email Address"].ToString();
				string userPassword = row["Password"].ToString();

				if ((usernameEmail == userUsername || usernameEmail == userEmail) && db.verifyPassword(password, userPassword))
				{
					username = userUsername;
					userType = row["UserType"].ToString();
					dashboard = userDashboard(userType, username);
					break;
				}
			}

			if (dashboard == null && adminResult.Rows.Count > 0)
			{
				string adminUsername = adminResult.Rows[0]["Username"].ToString();
				string adminPassword = adminResult.Rows[0]["Password"].ToString();

				if (db.verifyPassword(password, adminPassword))
				{
					username = adminUsername;
					userType = "Admin";
					dashboard = userDashboard(userType, username);
				}
			}

			if (dashboard != null)
			{
				UserLogs.Username = username;
				UserLogs.UserType = userType;
				UserLogs.LoginUser(db);

				if (this.Owner is Home home && home.WindowState == FormWindowState.Maximized)
				{
					dashboard.WindowState = FormWindowState.Maximized;
				}

				dashboard.Show();
				this.Opacity = 0;

				if (this.Owner is Home homeInstance)
				{
					homeInstance.Hide();
				}

				this.Close();
			}
			else
			{
				MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbxSPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSPassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

		private Form userDashboard(string userType, string username)
		{
			switch (userType)
			{
				case "Donor":
					return new DashboardD(username);
				case "Hospital":
					return new DashboardH(username);
				case "Admin":
					return new DashboardA(username);
				default:
					return null;
			}
		}
	}
}
