using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Hemotica
{
	internal class Database
	{
		private readonly string connection = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\Trixie\\Downloads\\CPE262\\Hemotica\\Hemotica_Database.accdb;";

		public OleDbConnection getConnection()
		{
			return new OleDbConnection(connection);
		}

		public void connectDatabase()
		{
			using (OleDbConnection conn = getConnection())
			{
				try
				{
					conn.Open();
					MessageBox.Show("Connection successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception)
				{
					MessageBox.Show("Connection failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public string hashPassword(string password)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(password);
				byte[] hashBytes = sha256.ComputeHash(bytes);
				return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
			}
		}

		public bool verifyPassword(string inputPassword, string hashedPassword)
		{
			return hashPassword(inputPassword) == hashedPassword;
		}

		public bool executeNonQuery(string query, OleDbParameter[] parameters)
		{
			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				try
				{
					conn.Open();
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					return cmd.ExecuteNonQuery() > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		public object executeScalar(string query, OleDbParameter[] parameters = null)
		{
			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				try
				{
					conn.Open();
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					return cmd.ExecuteScalar();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}

		public DataTable executeQuery(string query, OleDbParameter[] parameters = null)
		{
			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
			{
				try
				{
					conn.Open();
					if (parameters != null)
						cmd.Parameters.AddRange(parameters);

					DataTable dt = new DataTable();
					adapter.Fill(dt);
					return dt;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}

		public bool userExists(string columnName, string value)
		{
			string query = $@"SELECT COUNT(*) FROM (SELECT [Email Address] AS EmailAddress, [Username] FROM Donors UNION 
							  SELECT [Email Address] AS EmailAddress, [Username] FROM Hospitals) WHERE [{columnName}] = ?";

			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("?", value);
				try
				{
					conn.Open();
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		public int countEmail(string email)
		{
			string query = @"SELECT COUNT(*) FROM (SELECT [Email Address] FROM Donors WHERE [Email Address] = ? UNION ALL
							 SELECT [Email Address] FROM Hospitals WHERE [Email Address] = ?) AS CombinedUsers";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", email),
				new OleDbParameter("?", email)
			};

			DataTable dt = executeQuery(query, parameters);

			if (dt != null && dt.Rows.Count > 0)
			{
				return Convert.ToInt32(dt.Rows[0][0]);
			}
			return 0;
		}

		public string userEmail(string username)
		{
			string query = @"SELECT [Email Address] AS Email FROM Donors WHERE [Username] = ? UNION
							 SELECT [Email Address] AS Email FROM Hospitals WHERE [Username] = ?";

			OleDbParameter[] parameters = 
			{
				new OleDbParameter("?", username),
				new OleDbParameter("?", username)
			};

			DataTable dt = executeQuery(query, parameters);

			if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("Email"))
			{
				return dt.Rows[0]["Email"].ToString();
			}
			return string.Empty;
		}

		public string donorUsername(string donorID)
		{
			string query = $"SELECT [Username] FROM Donors WHERE [Donor ID] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", donorID) };
			DataTable dt = executeQuery(query, parameters);

			if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("Username"))
			{
				return dt.Rows[0]["Username"].ToString();
			}
			return string.Empty;
		}

		public string hospitalUsername(string hospitalName)
		{
			string query = @"SELECT [Username] FROM Hospitals WHERE [Hospital Name] = ?";
			OleDbParameter[] parameters = { new OleDbParameter("?", hospitalName) };
			DataTable dt = executeQuery(query, parameters);

			if (dt != null && dt.Rows.Count > 0 && dt.Columns.Contains("Username"))
			{
				return dt.Rows[0]["Username"].ToString();
			}
			return string.Empty;
		}
	}
}
