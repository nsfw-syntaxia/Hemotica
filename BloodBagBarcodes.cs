using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hemotica
{
	public partial class BloodBagBarcodes : UserControl
	{
		Database db = new Database();
		Hospital hospital = new Hospital();

		public BloodBagBarcodes()
		{
			InitializeComponent();
		}

		private void BloodBagBarcodes_Load(object sender, EventArgs e)
		{
			loadBarbodes();
		}

		private void loadBarbodes()
		{
			DataTable dt = hospital.loadBarcodes(db);

			if (dt != null)
			{
				dgvBarcodes.DataSource = dt;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			DashboardH parentForm = this.FindForm() as DashboardH;

			if (parentForm != null)
			{
				parentForm.showBloodExtraction();
			}
		}
	}
}
