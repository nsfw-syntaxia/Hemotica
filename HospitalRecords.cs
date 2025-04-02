using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Visitors;

namespace Hemotica
{
	public partial class HospitalRecords : UserControl
	{
		private Donor donor;
		private Hospital hospital;
		private Patient patient;
		private Physician physician;
		private Database db = new Database();

		public HospitalRecords()
		{
			InitializeComponent();
			this.donor = new Donor();
			this.hospital = new Hospital();
			this.patient = new Patient();
			this.physician = new Physician();
		}

		private void btnConnection_Click(object sender, EventArgs e)
		{
			db.connectDatabase();
		}

		private void lDonors_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = true;

			dgvDataMin.Visible = false;
			flpInputs.Visible = false;
			btnInsert.Visible = false;
			btnUpdate.Visible = false;
			btnDelete.Visible = false;

			loadDonors();
		}

		private void loadDonors()
		{
			DataTable dt = donor.loadDonors(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		private void lPatients_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = false;

			dgvDataMin.Visible = true;
			flpInputs.Visible = true;
			btnInsert.Visible = true;
			btnUpdate.Visible = true;
			btnDelete.Visible = true;

			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new RecordsPatient(this));
			loadPatients();
		}

		private void loadPatients()
		{
			DataTable dt = patient.loadPatients(db);

			if (dt != null)
			{
				dgvDataMin.DataSource = dt;
			}
		}

		private void dgvDataMin_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				DataGridViewRow row = dgvDataMin.Rows[e.RowIndex];

				recordsPatient.selectPatient(new Patient
				{
					FirstName = row.Cells["First Name"].Value?.ToString(),
					MiddleName = row.Cells["Middle Name"].Value?.ToString() ?? "",
					LastName = row.Cells["Last Name"].Value?.ToString(),
					Gender = row.Cells["Gender"].Value?.ToString(),
					Age = row.Cells["Age"].Value?.ToString(),
					Barangay = row.Cells["Barangay"].Value?.ToString(),
					City = row.Cells["City"].Value?.ToString(),
					Province = "Cebu",
					ContactNumber = row.Cells["Contact Number"].Value?.ToString(),
					BloodType = row.Cells["Blood Type"].Value?.ToString(),
					Request = row.Cells["Request"].Value?.ToString(),
					Priority = row.Cells["Priority"].Value?.ToString()
				});
			}
			else if (e.RowIndex >= 0 && flpInputs.Controls[0] is RecordsPhysician recordsPhysician)
			{
				DataGridViewRow row = dgvDataMin.Rows[e.RowIndex];

				recordsPhysician.selectPhysician(new Physician
				{
					FirstName = row.Cells["First Name"].Value?.ToString(),
					MiddleName = row.Cells["Middle Name"].Value?.ToString() ?? "",
					LastName = row.Cells["Last Name"].Value?.ToString(),
					Gender = row.Cells["Gender"].Value?.ToString(),
					Age = row.Cells["Age"].Value?.ToString(),
					Specialization = row.Cells["Specialization"].Value?.ToString(),
					License = row.Cells["License Number"].Value?.ToString(),
					ContactNumber = row.Cells["Contact Number"].Value?.ToString()
				});
			}
		}

		private void lPhysicians_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = false;

			dgvDataMin.Visible = true;
			flpInputs.Visible = true;
			btnInsert.Visible = true;
			btnUpdate.Visible = true;
			btnDelete.Visible = true;

			flpInputs.Controls.Clear();
			flpInputs.Controls.Add(new RecordsPhysician(this));
			loadPhysicians();
		}

		private void loadPhysicians()
		{
			DataTable dt = physician.loadPhysicians(db);

			if (dt != null)
			{
				dgvDataMin.DataSource = dt;
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				Patient patient = recordsPatient.inputPatient();

				if (patient != null)
				{
					if (patient.addPatient(db))
					{
						MessageBox.Show("Patient record inserted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						flpInputs.Controls.Clear();
						flpInputs.Controls.Add(new RecordsPatient(this));
						loadPatients();
					}
					else
					{
						MessageBox.Show("Patient record insertion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else if (flpInputs.Controls[0] is RecordsPhysician recordsPhysician)
			{
				Physician physician = recordsPhysician.inputPhysician();

				if (physician != null)
				{
					if (physician.addPhysician(db))
					{
						MessageBox.Show("Physician record inserted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						flpInputs.Controls.Clear();
						flpInputs.Controls.Add(new RecordsPhysician(this));
						loadPhysicians();
					}
					else
					{
						MessageBox.Show("Physician record insertion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				Patient patient = recordsPatient.inputPatient();

				if (patient != null)
				{
					if (dgvDataMin.SelectedRows.Count > 0)
					{
						int patientID = Convert.ToInt32(dgvDataMin.SelectedRows[0].Cells["Patient ID"].Value);

						if (patient.updatePatient(db, patientID))
						{
							MessageBox.Show("Patient record updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

							flpInputs.Controls.Clear();
							flpInputs.Controls.Add(new RecordsPatient(this));
							loadPatients();
						}
						else
						{
							MessageBox.Show("Patient record update failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else if (flpInputs.Controls[0] is RecordsPhysician recordsPhysician)
			{
				Physician physician = recordsPhysician.inputPhysician();

				if (physician != null)
				{
					if (dgvDataMin.SelectedRows.Count > 0)
					{
						int physicianID = Convert.ToInt32(dgvDataMin.SelectedRows[0].Cells["Physician ID"].Value);

						if (physician.updatePhysician(db, physicianID))
						{
							MessageBox.Show("Physician record updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

							flpInputs.Controls.Clear();
							flpInputs.Controls.Add(new RecordsPhysician(this));
							loadPhysicians();
						}
						else
						{
							MessageBox.Show("Physician record update failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (flpInputs.Controls[0] is RecordsPatient recordsPatient)
			{
				if (dgvDataMin.SelectedRows.Count > 0)
				{
					int patientID = Convert.ToInt32(dgvDataMin.SelectedRows[0].Cells["Patient ID"].Value);

					var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (confirmResult == DialogResult.Yes)
					{
						if (patient.deletePatient(patientID, db))
						{
							MessageBox.Show("Physician record deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

							DataTable dt = patient.loadPatients(db);
							dgvDataMin.DataSource = dt;
						}
						else
						{
							MessageBox.Show("Physician record deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else if (flpInputs.Controls[0] is RecordsPhysician recordsPhysician)
			{
				int physicianID = Convert.ToInt32(dgvDataMin.SelectedRows[0].Cells["Physician ID"].Value);
				var confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (confirmResult == DialogResult.Yes)
				{
					if (physician.deletePhysician(physicianID, db))
					{
						MessageBox.Show("Patient record deleted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

						DataTable dt = physician.loadPhysicians(db);
						dgvDataMin.DataSource = dt;
					}
					else
					{
						MessageBox.Show("Patient record deletion failed.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void lAppointments_Click(object sender, EventArgs e)
		{
			btnConnection.Visible = false;
			dgvDataMax.Visible = true;

			dgvDataMin.Visible = false;
			flpInputs.Visible = false;
			btnInsert.Visible = false;
			btnUpdate.Visible = false;
			btnDelete.Visible = false;

			loadAppointments();
		}

		private void loadAppointments()
		{
			DataTable dt = hospital.loadAppointments(db);

			if (dt != null)
			{
				dgvDataMax.DataSource = dt;
			}
		}

		private void lExtraction_Click(object sender, EventArgs e)
		{
			// after extraction functionality
		}

		private void lTransfusion_Click(object sender, EventArgs e)
		{
			// after transfusion functionality
		}

		public void exportPDF(DataGridView dgv)
		{
			if (dgv == null || dgv.Rows.Count == 0)
			{
				MessageBox.Show("No records to export.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PDF (*.pdf) | *.pdf";
			saveFileDialog.FilterIndex = 1;

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Document document = new Document();
				Section section = document.AddSection();

				section.PageSetup.PageFormat = PageFormat.Legal;
				section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Landscape;

				section.PageSetup.LeftMargin = Unit.FromCentimeter(1);
				section.PageSetup.RightMargin = Unit.FromCentimeter(1);
				section.PageSetup.TopMargin = Unit.FromCentimeter(1);
				section.PageSetup.BottomMargin = Unit.FromCentimeter(1);

				Table table = section.AddTable();
				table.Borders.Width = 0.75;

				foreach (DataGridViewColumn column in dgv.Columns)
				{
					Column tableColumn = table.AddColumn(Unit.FromCentimeter(3));
					tableColumn.Format.Alignment = ParagraphAlignment.Center;
				}

				Row headerRow = table.AddRow();
				for (int i = 0; i < dgv.Columns.Count; i++)
				{
					headerRow.Cells[i].AddParagraph(dgv.Columns[i].HeaderText);
					headerRow.Cells[i].Shading.Color = Colors.LightGray;
					headerRow.Cells[i].Format.Alignment = ParagraphAlignment.Center;
				}

				foreach (DataGridViewRow dgvRow in dgv.Rows)
				{
					if (!dgvRow.IsNewRow)
					{
						Row row = table.AddRow();
						for (int i = 0; i < dgv.Columns.Count; i++)
						{
							var cellValue = dgvRow.Cells[i].Value?.ToString() ?? string.Empty;

							Paragraph paragraph = row.Cells[i].AddParagraph(cellValue);
							row.Cells[i].Format.Alignment = ParagraphAlignment.Center;
						}
					}
				}

				PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true);
				pdfRenderer.Document = document;
				pdfRenderer.RenderDocument();

				pdfRenderer.PdfDocument.Save(saveFileDialog.FileName);
				MessageBox.Show("Records exported to PDF successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void pDonors_Click(object sender, EventArgs e)
		{
			exportPDF(dgvDataMax);
		}
	}
}
