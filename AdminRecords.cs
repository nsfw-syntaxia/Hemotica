using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace Hemotica
{
	public partial class AdminRecords : UserControl
	{
		private Admin admin = new Admin();
		private Database db = new Database();

		public AdminRecords()
		{
			InitializeComponent();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			donors();
		}

		private void loadDonors()
		{
			DataTable dt = admin.loadDonors(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		public void donors()
		{
			btnDelete.Visible = true;
			loadDonors();
		}

		private void lHospitals_Click(object sender, EventArgs e)
		{
			hospitals();
		}

		private void loadHospitals()
		{
			DataTable dt = admin.loadHospitals(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		public void hospitals()
		{
			btnDelete.Visible = true;
			loadHospitals();
		}

		private void lRequests_Click(object sender, EventArgs e)
		{

		}
	}
}
