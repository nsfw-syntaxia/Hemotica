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

			string userQuery = @"SELECT [Email Address] AS EmailAddress, [Username], [Password], 'Donor' AS UserType FROM Donors UNION 
                                 SELECT [Email Address] AS EmailAddress, [Username], [Password], 'Hospital' AS UserType FROM Hospitals";
			DataTable userResult = db.executeQuery(userQuery);

			string adminQuery = "SELECT Username, Password FROM Admin WHERE Username = @username";
			OleDbParameter[] parameters = { new OleDbParameter("@username", usernameEmail) };
			DataTable adminResult = db.executeQuery(adminQuery, parameters);

			Form dashboard = null;

			foreach (DataRow row in userResult.Rows)
			{
				string email = row["EmailAddress"].ToString();
				string username = row["Username"].ToString();
				string hashedPassword = row["Password"].ToString();
				string userType = row["UserType"].ToString();

				if ((usernameEmail == email || usernameEmail == username) && db.verifyPassword(password, hashedPassword))
				{
					dashboard = userType == "Donor" ? (Form)new DashboardD() : new DashboardH();
					break;
				}
			}

			if (dashboard == null && adminResult.Rows.Count > 0)
			{
				string adminUsername = adminResult.Rows[0]["Username"].ToString();
				string adminPassword = adminResult.Rows[0]["Password"].ToString();

				if (db.verifyPassword(password, adminPassword))
				{
					dashboard = new DashboardA();
				}
			}

			if (dashboard != null)
			{
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
    }
}
