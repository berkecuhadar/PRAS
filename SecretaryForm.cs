using PRAS.Business;

namespace PRAS.App
{
    public partial class SecretaryForm : Form
    {
        public SecretaryForm()
        {
            InitializeComponent();
        }

        // Managers used for CRUD operations
        private readonly SecretaryManager secretaryManager = new();
        private readonly AppointmentManager appointmentManager = new();
        private readonly PatientManager patientManager = new();
        private readonly DoctorManager doctorManager = new();

        public int Sid;
        public int Did;
        public int Pid;

        // Clears all textbox values inside the form
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllText(c);
                }
            }
        }

        private readonly string brans;

        private void SecretaryForm_Load(object sender, EventArgs e)
        {
            // Load initial data into grids
            dgv_S.DataSource = secretaryManager.GetAllSecretaries();
            dgv_doctor.DataSource = doctorManager.GetAllDoctors();
            dgv_P.DataSource = patientManager.GetAllPatients();

            // Set the minimum selectable date and time to NOW
            dtp_appointment.MinDate = DateTime.Now;

            // Set the maximum selectable date to 6 months from TODAY
            dtp_appointment.MaxDate = DateTime.Today.AddMonths(6);

            // --- Smart Initial Date & Time Logic ---
            DateTime initialDateTime = DateTime.Now;

            // If the current time is past the last appointment slot (15:30), 
            // move the default date to tomorrow morning at 09:00
            if (initialDateTime.Hour > 15 || (initialDateTime.Hour == 15 && initialDateTime.Minute >= 30))
            {
                initialDateTime = DateTime.Today.AddDays(1).AddHours(9); // Tomorrow at 09:00

                // Optional: If tomorrow is Sunday, skip to Monday (uncomment if needed)
                /*
                if (initialDateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    initialDateTime = initialDateTime.AddDays(1);
                }
                */
            }

            // Set default value to the most appropriate nearby date and time
            dtp_appointment.Value = initialDateTime;

            p_check();
        }

        // Save or update secretary information
        private void btn_S_Click(object sender, EventArgs e)
        {
            try
            {
                secretaryManager.SaveSecretary(
                    txt_sName.Text,
                    txt_sSurname.Text,
                    txt_sEmail.Text,
                    Convert.ToInt32(txt_sPN.Text),
                    Sid);
            }
            catch
            {
                _ = MessageBox.Show(
                    txt_sName.Text + " " + txt_sSurname.Text +
                    " could not be added. Please check the entered information.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgv_S.DataSource =
                secretaryManager.GetAllSecretaries();

            Sid = 0;
            txt_sID.Text = "0";

            ClearAllText(this);
        }

        // Refresh all data when tab changes
        private void tabControl1_Selected(
            object sender,
            TabControlEventArgs e)
        {
            dgv_S.DataSource =
                secretaryManager.GetAllSecretaries();

            dgv_doctor.DataSource =
                doctorManager.GetAllDoctors();

            dgv_P.DataSource =
                patientManager.GetAllPatients();

            dgv_appointment2.DataSource = null;

            ClearAllText(this);

            p_check();

            dgv_appointment1.DataSource = null;
        }

        // Remove selected secretary
        private void btn_rmvS_Click(
            object sender,
            EventArgs e)
        {
            Sid = Convert.ToInt32(txt_sID.Text);

            secretaryManager.RemoveSecretary(Sid);

            dgv_S.DataSource =
                secretaryManager.GetAllSecretaries();

            Sid = 0;
            txt_sID.Text = "0";

            ClearAllText(this);
        }

        // Fill secretary fields after selecting row
        private void dgv_S_RowHeaderMouseDoubleClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            int secim =
                dgv_S.SelectedCells[0].RowIndex;

            txt_sName.Text =
                dgv_S.Rows[secim].Cells[1].Value.ToString();

            txt_sSurname.Text =
                dgv_S.Rows[secim].Cells[2].Value.ToString();

            txt_sEmail.Text =
                dgv_S.Rows[secim].Cells[3].Value.ToString();

            txt_sPN.Text =
                dgv_S.Rows[secim].Cells[4].Value.ToString();

            string no =
                dgv_S.Rows[secim].Cells[0].Value.ToString();

            bool result =
                int.TryParse(no, out Sid);

            if (result == false)
            {
                Sid = 0;
            }
            else
            {
                txt_sID.Text = Sid.ToString();
            }
        }

        // Save or update doctor information
        private void btn_D_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                doctorManager.SaveDoctor(
                    txt_dName.Text,
                    txt_dSurname.Text,
                    txt_dEmail.Text,
                    Convert.ToInt32(txt_dPN.Text),
                    cb_field.SelectedItem.ToString(),
                    Did);
            }
            catch
            {
                _ = MessageBox.Show(
                    txt_dName.Text + " " + txt_dSurname.Text +
                    " could not be added. Please check the entered information.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgv_doctor.DataSource =
                doctorManager.GetAllDoctors();

            Did = 0;
            txt_dID.Text = "0";

            ClearAllText(this);
        }

        // Remove selected doctor
        private void btn_rmvD_Click(
            object sender,
            EventArgs e)
        {
            Did = Convert.ToInt32(txt_dID.Text);

            doctorManager.RemoveDoctor(Did);

            dgv_doctor.DataSource =
                doctorManager.GetAllDoctors();

            Did = 0;
            txt_dID.Text = "0";

            ClearAllText(this);
        }

        // Fill doctor fields after selecting row
        private void dgv_doctor_RowHeaderMouseDoubleClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            int secim =
                dgv_doctor.SelectedCells[0].RowIndex;

            txt_dName.Text =
                dgv_doctor.Rows[secim].Cells[1].Value.ToString();

            txt_dSurname.Text =
                dgv_doctor.Rows[secim].Cells[2].Value.ToString();

            txt_dEmail.Text =
                dgv_doctor.Rows[secim].Cells[3].Value.ToString();

            txt_dPN.Text =
                dgv_doctor.Rows[secim].Cells[4].Value.ToString();

            cb_field.SelectedText =
                dgv_doctor.Rows[secim].Cells[5].Value.ToString();

            string no =
                dgv_doctor.Rows[secim].Cells[0].Value.ToString();

            bool result =
                int.TryParse(no, out Did);

            if (result == false)
            {
                Did = 0;
            }
            else
            {
                txt_dID.Text = Did.ToString();
            }
        }

        public int secim;

        // Fill patient fields after selecting row
        private void dgv_P_RowHeaderMouseDoubleClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            secim =
                dgv_P.SelectedCells[0].RowIndex;

            txt_pName.Text =
                dgv_P.Rows[secim].Cells[1].Value.ToString();

            txt_pSurname.Text =
                dgv_P.Rows[secim].Cells[2].Value.ToString();

            txt_pPN.Text =
                dgv_P.Rows[secim].Cells[3].Value.ToString();

            txt_pNID.Text =
                dgv_P.Rows[secim].Cells[4].Value.ToString();

            string no =
                dgv_P.Rows[secim].Cells[0].Value.ToString();

            bool result =
                int.TryParse(no, out Pid);

            if (result == false)
            {
                Pid = 0;
            }
            else
            {
                txt_pID.Text = Pid.ToString();
            }
        }

        // Remove selected patient
        private void btn_rmvP_Click(
            object sender,
            EventArgs e)
        {
            Pid = Convert.ToInt32(txt_pID.Text);

            patientManager.RemovePatient(
                Pid,
                Convert.ToInt32(
                    dgv_P.Rows[secim].Cells[4].Value.ToString()));

            dgv_P.DataSource =
                patientManager.GetAllPatients();

            Pid = 0;
            txt_pID.Text = "0";

            ClearAllText(this);
        }

        // Save or update patient information
        private void btn_P_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                patientManager.SavePatient(
                    txt_pName.Text,
                    txt_pSurname.Text,
                    Convert.ToInt32(txt_pPN.Text),
                    txt_pNID.Text,
                    Pid);
            }
            catch (Exception ex) // 'ex' değişkenini ekledik
            {
                // Hatanın teknik detayını mesajın sonuna ekliyoruz
                _ = MessageBox.Show(
                    txt_pName.Text + " " + txt_pSurname.Text +
                    " could not be added. Please check the entered information.\n\n" +
                    "Hata Detayı: " + ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            dgv_P.DataSource =
                patientManager.GetAllPatients();

            Pid = 0;
            txt_pID.Text = "0";

            ClearAllText(this);
        }

        // Enable or disable appointment controls
        private void p_check()
        {
            if (dgv_appointment1.DataSource == null)
            {
                cb_poli.Enabled = false;
                dtp_appointment.Enabled = false;
                EnableAllHours(false); // Code cleanup using our helper
                btn_appointment.Enabled = false;
            }
            else
            {
                cb_poli.Enabled = true;
                dtp_appointment.Enabled = true;
                btn_appointment.Enabled = true;

                // Instead of making all hours true blindly, check if they are valid
                CheckAvailableHours();
            }
        }

        // Find patient and load appointment history
        private void btn_findP_Click(
            object sender,
            EventArgs e)
        {
            dgv_appointment1.DataSource =
                patientManager.GetPatientByTc(txt_findP.Text);

            dgv_appointment2.DataSource =
                patientManager.GetAppointmentsByPatient(txt_findP.Text);

            p_check();
        }

        // Create appointment for selected patient
        private void btn_appointment_Click(
            object sender,
            EventArgs e)
        {
            string saat = "10";

            if (rs_9.Checked)
            {
                saat = rs_9.Text;
            }

            if (rs_9h.Checked)
            {
                saat = rs_9h.Text;
            }

            if (rs_10.Checked)
            {
                saat = rs_10.Text;
            }

            if (rs_10h.Checked)
            {
                saat = rs_10h.Text;
            }

            if (rs_11.Checked)
            {
                saat = rs_11.Text;
            }

            if (rs_11h.Checked)
            {
                saat = rs_11h.Text;
            }

            if (rs_12.Checked)
            {
                saat = rs_12.Text;
            }

            if (rs_13h.Checked)
            {
                saat = rs_13h.Text;
            }

            if (rs_14.Checked)
            {
                saat = rs_14.Text;
            }

            if (rs_14h.Checked)
            {
                saat = rs_14h.Text;
            }

            if (rs_15.Checked)
            {
                saat = rs_15.Text;
            }

            if (rs_15h.Checked)
            {
                saat = rs_15h.Text;
            }

            try
            {
                patientManager.BookAppointment(
                    Convert.ToInt32(
                        dgv_appointment1.Rows[0]
                        .Cells[3].Value.ToString()),

                    Convert.ToInt32(
                        doctorManager.GetRandomDoctorByField(
                            cb_poli.Items[cb_poli.SelectedIndex]
                            .ToString())),

                    dtp_appointment.Value.ToString(),
                    saat);

                dgv_appointment2.DataSource =
                    patientManager.GetAppointmentsByPatient(txt_findP.Text);
            }
            catch
            {
                _ = MessageBox.Show(
                    "Appointment could not be created.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Fully close the application
        private void SecretaryForm_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void cb_poli_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }
        // Checks the selected date and disables past hours for today
        private void CheckAvailableHours()
        {
            // If the selected date is strictly in the future, enable all hours
            if (dtp_appointment.Value.Date > DateTime.Today)
            {
                EnableAllHours(true);
                return;
            }

            // If the selected date is today, check each hour button against current time
            int currentHour = DateTime.Now.Hour;
            int currentMinute = DateTime.Now.Minute;

            // Format check or manual parsing based on your radio button texts (e.g., "09:00", "09:30")
            rs_9.Enabled = currentHour < 9;
            rs_9h.Enabled = currentHour < 9 || (currentHour == 9 && currentMinute < 30);

            rs_10.Enabled = currentHour < 10;
            rs_10h.Enabled = currentHour < 10 || (currentHour == 10 && currentMinute < 30);

            rs_11.Enabled = currentHour < 11;
            rs_11h.Enabled = currentHour < 11 || (currentHour == 11 && currentMinute < 30);

            rs_12.Enabled = currentHour < 12; // 12:00

            rs_13h.Enabled = currentHour < 13 || (currentHour == 13 && currentMinute < 30); // 13:30

            rs_14.Enabled = currentHour < 14;
            rs_14h.Enabled = currentHour < 14 || (currentHour == 14 && currentMinute < 30);

            rs_15.Enabled = currentHour < 15;
            rs_15h.Enabled = currentHour < 15 || (currentHour == 15 && currentMinute < 30);

            // If the currently checked hour gets disabled, uncheck it to prevent wrong booking
            if (rs_9.Checked && !rs_9.Enabled)
            {
                rs_9.Checked = false;
            }

            if (rs_9h.Checked && !rs_9h.Enabled)
            {
                rs_9h.Checked = false;
            }

            if (rs_10.Checked && !rs_10.Enabled)
            {
                rs_10.Checked = false;
            }

            if (rs_10h.Checked && !rs_10h.Enabled)
            {
                rs_10h.Checked = false;
            }

            if (rs_11.Checked && !rs_11.Enabled)
            {
                rs_11.Checked = false;
            }

            if (rs_11h.Checked && !rs_11h.Enabled)
            {
                rs_11h.Checked = false;
            }

            if (rs_12.Checked && !rs_12.Enabled)
            {
                rs_12.Checked = false;
            }

            if (rs_13h.Checked && !rs_13h.Enabled)
            {
                rs_13h.Checked = false;
            }

            if (rs_14.Checked && !rs_14.Enabled)
            {
                rs_14.Checked = false;
            }

            if (rs_14h.Checked && !rs_14h.Enabled)
            {
                rs_14h.Checked = false;
            }

            if (rs_15.Checked && !rs_15.Enabled)
            {
                rs_15.Checked = false;
            }

            if (rs_15h.Checked && !rs_15h.Enabled)
            {
                rs_15h.Checked = false;
            }
        }

        // Helper method to set state for all hour buttons
        private void EnableAllHours(bool state)
        {
            rs_9.Enabled = state;
            rs_9h.Enabled = state;
            rs_10.Enabled = state;
            rs_10h.Enabled = state;
            rs_11.Enabled = state;
            rs_11h.Enabled = state;
            rs_12.Enabled = state;
            rs_13h.Enabled = state;
            rs_14.Enabled = state;
            rs_14h.Enabled = state;
            rs_15.Enabled = state;
            rs_15h.Enabled = state;
        }
        // Prevent user from selecting past dates and times, and refresh available hours
        private void dtp_appointment_ValueChanged(object sender, EventArgs e)
        {
            // If the selected date and time is in the past
            if (dtp_appointment.Value < DateTime.Now)
            {
                _ = MessageBox.Show(
                    "You cannot select a past date or time.",
                    "INVALID SELECTION",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                DateTime safeDateTime = DateTime.Now;

                // Smart nearest date check: If today's slots are over (past 15:30),
                // automatically move the selection to tomorrow morning at 09:00
                if (safeDateTime.Hour > 15 || (safeDateTime.Hour == 15 && safeDateTime.Minute >= 30))
                {
                    safeDateTime = DateTime.Today.AddDays(1).AddHours(9); // Tomorrow at 09:00
                }

                // Reset the value to the nearest valid date and time
                dtp_appointment.Value = safeDateTime;
            }

            // Always check hour buttons after date changes
            CheckAvailableHours();
        }
    }
}