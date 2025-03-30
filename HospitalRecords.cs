using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class HospitalRecords : UserControl
	{
		private Database db = new Database();

		public HospitalRecords()
		{
			InitializeComponent();
		}

		private void HospitalRecords_Load(object sender, EventArgs e)
		{
			//
		}

		private void btnConnection_Click(object sender, EventArgs e)
		{
			using (OleDbConnection conn = db.getConnection())
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

		private void lDonors_Click(object sender, EventArgs e)
		{
			string query = "SELECT * FROM Donors";
			DataTable dt = db.executeQuery(query);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		private void lPatients_Click(object sender, EventArgs e)
		{
			//flpInputs.Controls.Clear();
			//flpInputs.Controls.Add(new RecordsPatient());
		}

		private void lPhysicians_Click(object sender, EventArgs e)
		{
			//flpInputs.Controls.Clear();
			//flpInputs.Controls.Add(new RecordsPhysician());
		}
	}
}
