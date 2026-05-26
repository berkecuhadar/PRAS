using PRAS.Business;
using PRAS.Core;

namespace PRAS.App
{
    public partial class LoginForm : Form
    {
        // Managers used for login operations
        private readonly SecretaryManager _secretaryManager = new();
        private readonly DoctorManager _doctorManager = new();

        // Logged-in user information
        public Secretary AuthenticatedSecretary { get; private set; }
        public Doctor AuthenticatedDoctor { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Placeholder texts
            txt_DEmail.Text = "Enter your email address...";
            txt_DPass.Text = "Enter your password...";
            txt_SEmail.Text = "Enter your email address...";
            txt_SPass.Text = "Enter your password...";

            // Show password field as normal text until user types
            txt_SPass.PasswordChar = '\0';
            txt_DPass.PasswordChar = '\0';

            // Placeholder text color
            txt_DEmail.ForeColor = Color.Gray;
            txt_DPass.ForeColor = Color.Gray;
            txt_SEmail.ForeColor = Color.Gray;
            txt_SPass.ForeColor = Color.Gray;

            // Disable tab focus at startup
            txt_DEmail.TabStop = false;
            txt_DPass.TabStop = false;
            txt_SEmail.TabStop = false;
            txt_SPass.TabStop = false;
            btn_DLogin.TabStop = false;
            btn_SLogin.TabStop = false;
        }

        // Secretary login
        private void btn_SLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_SEmail.Text.Trim();
                string password = txt_SPass.Text.Trim();

                // Check if placeholders are still there
                if (email == "Enter your email address..." ||
                    password == "Enter your password...")
                {
                    _ = MessageBox.Show(
                        "Please fill in both email and password fields!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Try login
                AuthenticatedSecretary =
                    _secretaryManager.LoginSecretary(email, password);

                if (AuthenticatedSecretary != null)
                {
                    Close();
                }
                else
                {
                    _ = MessageBox.Show(
                        "Invalid secretary email or password!",
                        "Authentication Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Show validation errors
                _ = MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Doctor login
        private void btn_DLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_DEmail.Text.Trim();
                string password = txt_DPass.Text.Trim();

                // Check if placeholders are still there
                if (email == "Enter your email address..." ||
                    password == "Enter your password...")
                {
                    _ = MessageBox.Show(
                        "Please fill in both email and password fields!",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Try login
                AuthenticatedDoctor =
                    _doctorManager.LoginDoctor(email, password);

                if (AuthenticatedDoctor != null)
                {
                    Close();
                }
                else
                {
                    _ = MessageBox.Show(
                        "Invalid doctor email or password!",
                        "Authentication Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Show validation errors
                _ = MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void LoginForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            // Close app if no one logged in
            if (AuthenticatedSecretary == null &&
                AuthenticatedDoctor == null)
            {
                Application.Exit();
            }
        }

        // Enable keyboard navigation
        private void EnableFormTabStops()
        {
            txt_DEmail.TabStop = true;
            txt_DPass.TabStop = true;
            txt_SEmail.TabStop = true;
            txt_SPass.TabStop = true;
            btn_DLogin.TabStop = true;
            btn_SLogin.TabStop = true;
        }

        #region UI Focus Events

        private void txt_SEmail_Enter(
            object sender,
            EventArgs e)
        {
            // Remove placeholder on focus
            if (txt_SEmail.Text ==
                "Enter your email address...")
            {
                txt_SEmail.Text = "";
                txt_SEmail.ForeColor = Color.Black;
                EnableFormTabStops();
            }
        }

        private void txt_SEmail_Leave(
            object sender,
            EventArgs e)
        {
            // Restore placeholder if empty
            if (string.IsNullOrWhiteSpace(
                txt_SEmail.Text))
            {
                txt_SEmail.Text =
                    "Enter your email address...";

                txt_SEmail.ForeColor = Color.Gray;
            }
        }

        private void txt_SPass_Enter(
            object sender,
            EventArgs e)
        {
            // Remove password placeholder
            if (txt_SPass.Text ==
                "Enter your password...")
            {
                txt_SPass.Text = "";
                txt_SPass.ForeColor = Color.Black;
                txt_SPass.PasswordChar = '*';

                EnableFormTabStops();
            }
        }

        private void ttxt_SPass_Leave(
            object sender,
            EventArgs e)
        {
            // Restore placeholder if empty
            if (string.IsNullOrWhiteSpace(
                txt_SPass.Text))
            {
                txt_SPass.Text =
                    "Enter your password...";

                txt_SPass.ForeColor = Color.Gray;
                txt_SPass.PasswordChar = '\0';
            }
        }

        private void txt_DEmail_Enter(
            object sender,
            EventArgs e)
        {
            // Remove placeholder on focus
            if (txt_DEmail.Text ==
                "Enter your email address...")
            {
                txt_DEmail.Text = "";
                txt_DEmail.ForeColor = Color.Black;

                EnableFormTabStops();
            }
        }

        private void txt_DEmail_Leave(
            object sender,
            EventArgs e)
        {
            // Restore placeholder if empty
            if (string.IsNullOrWhiteSpace(
                txt_DEmail.Text))
            {
                txt_DEmail.Text =
                    "Enter your email address...";

                txt_DEmail.ForeColor = Color.Gray;
            }
        }

        private void txt_DPass_Enter(
            object sender,
            EventArgs e)
        {
            // Remove password placeholder
            if (txt_DPass.Text ==
                "Enter your password...")
            {
                txt_DPass.Text = "";
                txt_DPass.ForeColor = Color.Black;
                txt_DPass.PasswordChar = '*';

                EnableFormTabStops();
            }
        }

        private void txt_DPass_Leave(
            object sender,
            EventArgs e)
        {
            // Restore placeholder if empty
            if (string.IsNullOrWhiteSpace(
                txt_DPass.Text))
            {
                txt_DPass.Text =
                    "Enter your password...";

                txt_DPass.ForeColor = Color.Gray;
                txt_DPass.PasswordChar = '\0';
            }
        }

        #endregion
    }
}