using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ScrunchPLUS
{
    public partial class Login : Form
    {
        //DiscordFields
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public Login()
        {
            InitializeComponent();
            //EpochTime
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int)t.TotalSeconds;
            //Discord RPC
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("910304415498510406", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("910304415498510406", ref this.handlers, true, null);
            this.presence.details = "HEE HEE HEE HAW";
            this.presence.state = "Logging in...";
            this.presence.largeImageKey = "logo";
            this.presence.largeImageText = "ScrunchPLUS";
            this.presence.startTimestamp = secondsSinceEpoch;
            DiscordRpc.UpdatePresence(ref this.presence);
            //RememberMeFiller
            LoginUsernameTxt.Text = ScrunchPLUS.Properties.Settings.Default.UserName;
            LoginPasswordTxt.Text = ScrunchPLUS.Properties.Settings.Default.Password;
            if (LoginUsernameTxt.Text == string.Empty)
            {
                LoginCheckBoxRemMe.Checked = false;
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