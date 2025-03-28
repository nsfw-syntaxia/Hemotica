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

		private OleDbConnection getConnection()
		{
			OleDbConnection conn = new OleDbConnection(connection);
			conn.Close();
			return conn;
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

		public bool executeNonQuery(string query, OleDbParameter[] parameters)
		{
			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				try
				{
					conn.Open();
					cmd.Parameters.AddRange(parameters);
					return cmd.ExecuteNonQuery() > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
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
					MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}

		public bool search(string columnName, string value, string tableName)
		{
			string query = $"SELECT COUNT(*) FROM [{tableName}] WHERE [{columnName}] = @Value";
			using (OleDbConnection conn = getConnection())
			using (OleDbCommand cmd = new OleDbCommand(query, conn))
			{
				cmd.Parameters.AddWithValue("@Value", value);
				try
				{
					conn.Open();
					int count = (int)cmd.ExecuteScalar();
					return count > 0;
				}
				catch (Exception ex)
				{
					MessageBox.Show("ERROR: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				finally
				{
					conn.Close();
				}
			}
		}
	}
}
