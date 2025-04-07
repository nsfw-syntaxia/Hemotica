using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hemotica
{
	public partial class HospitalStock : UserControl
	{
		Database db = new Database();
		Hospital hospital = new Hospital();

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalStock()
		{
			InitializeComponent();
		}

		private void HospitalStock_Load(object sender, EventArgs e)
		{
			loadStock();
			roundControls();
		}

		private void loadStock()
		{
			dgvStock.Columns.Clear();
			dgvStock.Rows.Clear();

			dgvStock.Columns.Add("BloodType", "Blood Type");
			dgvStock.Columns.Add("Unit", "Blood Bag/s");

			string[] bloodTypes = { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" };

			foreach (string type in bloodTypes)
			{
				dgvStock.Rows.Add(type, "0");
			}

			DataTable dt = hospital.loadStock(db);

			if (dt != null)
			{
				foreach (DataRow row in dt.Rows)
				{
					string type = row["Blood Type"].ToString();
					int unit = Convert.ToInt32(row["Unit"]);

					foreach (DataGridViewRow dgvRow in dgvStock.Rows)
					{
						if (dgvRow.Cells["BloodType"].Value.ToString() == type)
						{
							dgvRow.Cells["Unit"].Value = unit.ToString();
							break;
						}
					}
				}
			}
		}

		public void roundControls()
		{
			flpStock.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, flpStock.Width, flpStock.Height, 20, 20));
		}

		private void HospitalStock_Resize(object sender, EventArgs e)
		{
			roundControls();
		}
	}
}
