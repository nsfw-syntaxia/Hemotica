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

			pImage.Visible = false;
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

			List<string> lowStock = new List<string>();
			foreach (DataGridViewRow row in dgvStock.Rows)
			{
				int unit = int.Parse(row.Cells["Unit"].Value.ToString());
				if (unit <= 3)
				{
					lowStock.Add(row.Cells["BloodType"].Value.ToString());
				}
			}

			if (lowStock.Count > 0)
			{
				lblWarning.Visible = true;
				lblNote.Visible = true;

				string bloodLowStock = string.Join(", ", lowStock);
				lblNote.Text = $"ATTENTION: Blood types {bloodLowStock} are low in stock or unavailable.\n\n" +
							   $"Kindly organize a blood donation drive to support the ongoing maintenance of the supply, readiness for emergencies, and the means to save lives.";

				lblNote.Width = 468;
				lblNote.MaximumSize = new Size(468, 0);
			}
			else
			{
				lblWarning.Visible = false;
				lblNote.Visible = false;
				lblWarning.Text = string.Empty;
			}
		}

		public void roundControls()
		{
			pPost.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pPost.Width, pPost.Height, 20, 20));
			pImage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pImage.Width, pImage.Height, 20, 20));
		}

		private void HospitalStock_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			pPost.Visible = false;
			pImage.Visible = true;

			// store the data inputed and pass it to the next form (to save to database, including the next data)
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			// goes back to pPost and hides pImage, and the prev inputted data will still be there
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			// save to database
		}

		private void tbxDescription_Enter(object sender, EventArgs e)
		{

		}

		private void tbxDescription_Leave(object sender, EventArgs e)
		{

		}

		private void tbxDate_Enter(object sender, EventArgs e)
		{

		}

		private void tbxDate_Leave(object sender, EventArgs e)
		{

		}

		private void tbxTime_Enter(object sender, EventArgs e)
		{

		}

		private void tbxTime_Leave(object sender, EventArgs e)
		{

		}

		private void cmbxCity_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
