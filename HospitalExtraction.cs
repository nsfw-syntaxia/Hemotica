using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Hemotica
{
	public partial class HospitalExtraction : UserControl
	{
		Database db = new Database();
		DataTable donorList;

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

		private static extern IntPtr CreateRoundRectRgn(
			int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
			int nWidthEllipse, int nHeightEllipse);

		public HospitalExtraction()
		{
			InitializeComponent();
		}

		private void HospitalExtraction_Load(object sender, EventArgs e)
		{
			roundControls();
			loadDonorList();
		}

		public void roundControls()
		{
			pExtraction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pExtraction.Width, pExtraction.Height, 20, 20));
			pDonate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pDonate.Width, pDonate.Height, 20, 20));
			pBarCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pBarCode.Width, pBarCode.Height, 20, 20));

			if (pbxBarCode.Width > 0 && pbxBarCode.Height > 0)
			{
				pbxBarCode.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pbxBarCode.Width, pbxBarCode.Height, 20, 20));
			}
		}

		private void HospitalExtraction_Resize(object sender, EventArgs e)
		{
			roundControls();
		}

		private void cmbxDonor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbxDonor.SelectedIndex <= 0)
			{
				tbxGender.Text = "";
				tbxAge.Text = "";
				tbxAddress.Text = "";
				tbxCNumber.Text = "";
				tbxBloodType.Text = "";
				return;
			}

			int dataIndex = cmbxDonor.SelectedIndex - 1;
			string donorID = donorList.Rows[dataIndex]["Donor ID"].ToString();

			loadDonorDetails(donorID);
		}

		private void loadDonorList()
		{
			string query = "SELECT [Donor ID], [First Name], [Middle Name], [Last Name] FROM Donors";
			donorList = db.executeQuery(query);

			cmbxDonor.Items.Clear();
			cmbxDonor.Items.Add("Select donor");
			cmbxDonor.SelectedIndex = 0;

			foreach (DataRow row in donorList.Rows)
			{
				string firstName = row["First Name"].ToString();
				string middleName = row["Middle Name"].ToString();
				string lastName = row["Last Name"].ToString();

				string fullName = string.IsNullOrWhiteSpace(middleName) ? $"{firstName} {lastName}" : $"{firstName} {middleName} {lastName}";

				cmbxDonor.Items.Add(fullName);
			}
		}

		private void loadDonorDetails(string donorID)
		{
			string query = @"SELECT Gender, Age, Barangay, City, Province, [Contact Number], [Blood Type] FROM Donors WHERE [Donor ID] = ?";
			OleDbParameter[] parameter = { new OleDbParameter("?", donorID) };
			DataTable dt = db.executeQuery(query, parameter);

			if (dt.Rows.Count > 0)
			{
				DataRow row = dt.Rows[0];
				tbxGender.Text = row["Gender"].ToString();
				tbxAge.Text = row["Age"].ToString();
				tbxAddress.Text = $"{row["Barangay"]}, {row["City"]}, {row["Province"]}";
				tbxCNumber.Text = row["Contact Number"].ToString();
				tbxBloodType.Text = row["Blood Type"].ToString();
			}
		}

		private void btnDonate_Click(object sender, EventArgs e)
		{

		}
	}
}
