using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using ZXing;
using ZXing.Rendering;
using ZXing.Common;

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
			updateExtraction();
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
			if (cmbxDonor.SelectedIndex <= 0)
			{
				MessageBox.Show("Please select a donor.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int dataIndex = cmbxDonor.SelectedIndex - 1;
			string donorID = donorList.Rows[dataIndex]["Donor ID"].ToString();
			string donorUsername = db.donorUsername(donorID);

			addDonation(donorID);
			updateAppointments(donorUsername);

			MessageBox.Show("Donation recorded successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void addDonation(string donorID)
		{
			string donorUsername = db.donorUsername(donorID);
			string hospitalUsername = UserLogs.Username;

			string queryHospital = $"SELECT [Hospital Name] FROM Hospitals WHERE [Username] = '{hospitalUsername}'";
			DataTable hospitalData = db.executeQuery(queryHospital);
			string hospitalName = hospitalData.Rows[0]["Hospital Name"].ToString();

			string bloodType = tbxBloodType.Text;
			string extractionDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
			string expirationDate = DateTime.Now.AddDays(42).ToString("MM/dd/yyyy HH:mm:ss");
			string status = "Available";

			string barcodeValue = Guid.NewGuid().ToString().Substring(0, 10);

			Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
			Image barcodeImage = barcode.Draw(barcodeValue, 200);

			Bitmap barcodeBitmap = new Bitmap(barcodeImage);

			byte[] barcodeBytes;
			using (MemoryStream ms = new MemoryStream())
			{
				barcodeBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				barcodeBytes = ms.ToArray();
			}

			string insertQuery = @"INSERT INTO Extraction ([Donor Username], [Hospital Username], [Hospital], [Blood Type], [Extraction Date], [Expiration Date], [Status], [Barcode]) 
								   VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

			OleDbParameter[] insertParameters =
			{
				new OleDbParameter("?", donorUsername),
				new OleDbParameter("?", hospitalUsername),
				new OleDbParameter("?", hospitalName),
				new OleDbParameter("?", bloodType),
				new OleDbParameter("?", extractionDate),
				new OleDbParameter("?", expirationDate),
				new OleDbParameter("?", status),
				new OleDbParameter("?", OleDbType.LongVarBinary) { Value = barcodeBytes }
			};

			db.executeNonQuery(insertQuery, insertParameters);
		}

		private void updateAppointments(string donorUsername)
		{
			string updateAppointment = @"UPDATE Appointments SET Status = 'Completed' WHERE [Donor Username] = ? AND Status = 'Scheduled'";
			OleDbParameter[] updateParameters = { new OleDbParameter("?", donorUsername) };
			db.executeNonQuery(updateAppointment, updateParameters);
		}

		public void updateExtraction()
		{
			string expireStocksQuery = @"UPDATE Extraction SET Status = 'Expired' WHERE [Expiration Date] < ? AND Status = 'Available'";
			OleDbParameter[] stockParameter = { new OleDbParameter("?", DateTime.Now) };
			db.executeNonQuery(expireStocksQuery, stockParameter);
		}

		private void btnBarCode_Click(object sender, EventArgs e)
		{

		}
	}
}
