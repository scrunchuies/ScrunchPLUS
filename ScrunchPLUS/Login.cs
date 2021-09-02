using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ScrunchPLUS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //RememberMeFiller
            LoginUsernameTxt.Text = ScrunchPLUS.Properties.Settings.Default.UserName;
            LoginPasswordTxt.Text = ScrunchPLUS.Properties.Settings.Default.Password;
            if (!string.IsNullOrEmpty(LoginUsernameTxt.Text))
            {
                LoginCheckBoxRemMe.Checked = true;
            }
        }

        private void GoToRegisterBtn_Click(object sender, System.EventArgs e)
        {
            LoginPanel.BringToFront();
            Transition.Hide(LoginPanel);
        }

        private void GoToLoginBtn_Click(object sender, System.EventArgs e)
        {
            LoginPanel.BringToFront();
            Transition.Show(LoginPanel);
        }

        private void LoginBtn_Click(object sender, System.EventArgs e)
        {
            if (API.Login(LoginUsernameTxt.Text, LoginPasswordTxt.Text))
            {
                if (LoginCheckBoxRemMe.Checked)
                {
                    ScrunchPLUS.Properties.Settings.Default.UserName = LoginUsernameTxt.Text;
                    ScrunchPLUS.Properties.Settings.Default.Password = LoginPasswordTxt.Text;
                    ScrunchPLUS.Properties.Settings.Default.Save();
                }
                //Put code here of what you want to do after successful login
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main main = new Main();
                main.Show();
                this.Hide();
            }
        }

        private void RegisterHelpBtn_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("You should of received an email or got a key from scrunch#1945", "How to find license key", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegisterBtn_Click(object sender, System.EventArgs e)
        {
            Thread threadRegister = new Thread(() =>
            {
                if (API.Register(RegisterUserNameTxt.Text, RegisterPasswordTxt.Text, RegisterEmailTxt.Text, RegisterLicenseTxt.Text))
                {
                    //Put code here of what you want to do after successful login
                    MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
            threadRegister.Start();
        }

        private void LoginResetPassHtml_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://discord.gg/FHjwNM6ZY6");
        }

        private void LoginExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void LoginSeePassBtn_MouseDown(object sender, MouseEventArgs e)
        {
            LoginPasswordTxt.UseSystemPasswordChar = false;
        }

        private void LoginSeePassBtn_MouseUp(object sender, MouseEventArgs e)
        {
            LoginPasswordTxt.UseSystemPasswordChar = true;
        }

        private void RegisterSeePassBtn_MouseDown(object sender, MouseEventArgs e)
        {
            RegisterPasswordTxt.UseSystemPasswordChar = false;
        }

        private void RegisterSeePassBtn_MouseUp(object sender, MouseEventArgs e)
        {
            RegisterPasswordTxt.UseSystemPasswordChar = true;
        }
    }
}