using PRAS.Core;

namespace PRAS.App
{
    public partial class MainForm : Form
    {
        private Secretary _currentSecretary;
        private Doctor _currentDoctor;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_OnLoad(object sender, EventArgs e)
        {
            // Show the modern Login Form as a blocking dialog window
            using (LoginForm loginForm = new())
            {
                _ = loginForm.ShowDialog();

                // Extract the authenticated user instances from the login form context
                _currentSecretary = loginForm.AuthenticatedSecretary;
                _currentDoctor = loginForm.AuthenticatedDoctor;
            }

            // Route the session context to the appropriate administration dashboard
            if (_currentSecretary != null)
            {
                SecretaryForm secretaryForm = new();
                Hide(); // Hide the splash controller frame
                _ = secretaryForm.ShowDialog();
                Close(); // Kill the session resource upon child window exit
            }
            else if (_currentDoctor != null)
            {
                DoctorForm doctorForm = new()
                {
                    doctorId = _currentDoctor.Id // Pass the active identifier state
                };

                Hide();
                _ = doctorForm.ShowDialog();
                Close();
            }
            else
            {
                // If the user cancelled or closed the login window, terminate the process entirely
                Application.Exit();
            }
        }
    }
}