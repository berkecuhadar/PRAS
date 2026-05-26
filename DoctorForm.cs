using PRAS.Business;
using System.ComponentModel;

namespace PRAS.App
{
    public partial class DoctorForm : Form
    {
        // Handles doctor-side appointment and patient examination operations.
        public DoctorForm()
        {
            InitializeComponent();
        }

        // Business layer instance for appointment operations.
        private readonly AppointmentManager appointmentManager = new();

        // Stores the logged-in doctor's ID.
        public int doctorId;

        // Searches appointments by patient national ID.
        private void btn_findP_Click(object sender, EventArgs e)
        {
            try
            {
                // Fetch appointment list for selected patient and doctor.
                dgv_appointment.DataSource =
                    appointmentManager.GetAppointmentList(
                        Convert.ToInt32(txt_pNID.Text),
                        doctorId);

                // Hide medical detail columns from table view.
                dgv_appointment.Columns[5].Visible = false;
                dgv_appointment.Columns[6].Visible = false;
                dgv_appointment.Columns[7].Visible = false;

                int rowCount = dgv_appointment.Rows.Count - 1;

                // Enable medical details tab after valid search.
                tabPage1.Enabled = true;

                // Load latest patient examination data into text fields.
                txt_cc.Text =
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[5].Value.ToString();

                txt_diag.Text =
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[6].Value.ToString();

                txt_lab.Text =
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[7].Value.ToString();
            }
            catch
            {
                // Display error if input format is invalid.
                _ = MessageBox.Show(
                    "Error! Please enter the information in the correct format. For further assistance, contact the IT department.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Opens selected appointment details in a separate popup window.
        private void dgv_appointment_RowHeaderMouseDoubleClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            RichTextBox detailsTextBox = new();

            // Get selected appointment row index.
            int selectedRowIndex =
                dgv_appointment.SelectedCells[0].RowIndex;

            // Create formatted medical report text.
            detailsTextBox.Text =
                "Patient Complaint:\n" +
                dgv_appointment.Rows[selectedRowIndex]
                .Cells[5].Value.ToString() +
                "\n\n" +
                "Doctor's Diagnosis:\n" +
                dgv_appointment.Rows[selectedRowIndex]
                .Cells[6].Value.ToString() +
                "\n\n" +
                "Patient Lab Results:\n" +
                dgv_appointment.Rows[selectedRowIndex]
                .Cells[7].Value.ToString() +
                "\n";

            detailsTextBox.Dock = DockStyle.Fill;
            detailsTextBox.ReadOnly = true;

            // Create popup window for displaying details.
            Form detailsForm = new();

            detailsForm.Controls.Add(detailsTextBox);
            detailsForm.Width = 600;
            detailsForm.Height = 600;
            detailsForm.FormBorderStyle =
                FormBorderStyle.FixedToolWindow;
            detailsForm.ShowInTaskbar = false;

            // Show popup as modal dialog.
            _ = detailsForm.ShowDialog();
        }

        // Disable medical tab when form is loaded.
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            tabPage1.Enabled = false;
        }

        // Saves patient's chief complaint information.
        private void btn_saveChiefComplaint_Click(
            object sender,
            EventArgs e)
        {
            int rowCount = dgv_appointment.Rows.Count - 1;

            appointmentManager.SaveChiefComplaint(
                txt_cc.Text,
                Convert.ToInt32(
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[0].Value));

            // Refresh appointment list after update.
            dgv_appointment.DataSource =
                appointmentManager.GetAppointmentList(
                    Convert.ToInt32(txt_pNID.Text),
                    doctorId);
        }

        // Refresh appointment list when tab changes.
        private void tabControl1_Selected(
            object sender,
            TabControlEventArgs e)
        {
            if (dgv_appointment.DataSource != null)
            {
                dgv_appointment.DataSource =
                    appointmentManager.GetAppointmentList(
                        Convert.ToInt32(txt_pNID.Text),
                        doctorId);
            }
        }

        // Saves diagnosis notes for the selected patient.
        private void btn_saveDiagnosis_Click(
            object sender,
            EventArgs e)
        {
            int rowCount = dgv_appointment.Rows.Count - 1;

            appointmentManager.SaveDiagnosis(
                txt_diag.Text,
                Convert.ToInt32(
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[0].Value));

            // Refresh appointment list after saving.
            dgv_appointment.DataSource =
                appointmentManager.GetAppointmentList(
                    Convert.ToInt32(txt_pNID.Text),
                    doctorId);
        }

        // Saves laboratory or test results.
        private void btn_saveLabResults_Click(
            object sender,
            EventArgs e)
        {
            int rowCount = dgv_appointment.Rows.Count - 1;

            appointmentManager.SaveLabResults(
                txt_lab.Text,
                Convert.ToInt32(
                    dgv_appointment.Rows[rowCount - 1]
                    .Cells[0].Value));

            // Refresh appointment list after update.
            dgv_appointment.DataSource =
                appointmentManager.GetAppointmentList(
                    Convert.ToInt32(txt_pNID.Text),
                    doctorId);
        }

        // Displays usage information for doctors.
        private void DoctorForm_HelpButtonClicked(
            object sender,
            CancelEventArgs e)
        {
            _ = MessageBox.Show(
                "You cannot create a consultation record without entering the patient's national ID. To access previous consultations, enter the patient's national ID and double-click on the listed records.",
                "INFORMATION",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // Reserved for future email functionality.
        private void btn_mail_Click(object sender, EventArgs e)
        {

        }

        // Reserved for future PDF export functionality.
        private void btn_exportPdf_Click(object sender, EventArgs e)
        {

        }

        // Completely terminates application when form closes.
        private void DoctorForm_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}