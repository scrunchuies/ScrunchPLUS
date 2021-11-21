using FontAwesome.Sharp;
using ScrunchPLUS.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ScrunchPLUS
{
    public partial class Main : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Main()
        {
            InitializeComponent();
            //Settings
            SettingsInitializer settingsInitializer = new SettingsInitializer();
            settingsInitializer.DiscordRpcMainInitializer();
            if (ScrunchPLUS.Properties.Settings.Default.AutoLogin == "true")
            {
                AutoLogonBtn.Checked = true;
            }
            if (ScrunchPLUS.Properties.Settings.Default.DiscordRpc == "true")
            {
                DiscordStatusBtn.Checked = true;
            }
            //Auth.GG Info Loader
            pictureBoxPFPMain.Load(User.ProfilePicture);
            pictureBoxPFPSettings.Load(User.ProfilePicture);
            labelWelcomeMain.Text = "Welcome back, " + User.Username + "!";
            labelWelcomeSettings.Text = "Welcome back, " + User.Username + "!";
            label1.Text = "ID: " + User.ID;
            label2.Text = "Username: " + User.Username;
            label3.Text = "Email: " + User.Email;
            label4.Text = "IP: " + User.IP;
            label5.Text = "Expiry: " + User.Expiry;
            label6.Text = "Last Login: " + User.LastLogin;
            label7.Text = "Register Date: " + User.RegisterDate;
            //Panel
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(15, 19, 25);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(15, 19, 25);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            iconCurrentChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            iconCurrentChildForm.Text = "Home";
            panelSettings.Dock = DockStyle.None;
            panelSettings.Location = new Point(1000, 1000);
        }

        //Events
        //Reset
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        //Menu Button_Clicks
        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Dashboard());
        }

        private void GamesBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Games());
        }

        private void ChatBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Chat());
        }

        private void NewsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new NewsForm());
        }

        private void ExtraBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Extra());
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            iconCurrentChildForm.Text = "Settings";
            panelSettings.Dock = DockStyle.Fill;
            panelSettings.Location = new Point(882, 641);
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UploadPfpBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                string profilepic = open.FileName;
                string pic = Convert.ToBase64String(File.ReadAllBytes(profilepic));
                API.UploadPic(User.Username, pic);
            }
        }

        private void AutoLogonBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoLogonBtn.Checked == true)
            {
                ScrunchPLUS.Properties.Settings.Default.AutoLogin = "true";
            }
            else if (AutoLogonBtn.Checked == false)
            {
                ScrunchPLUS.Properties.Settings.Default.AutoLogin = "false";
            }
            Console.WriteLine("Value of button saved: " + ScrunchPLUS.Properties.Settings.Default.AutoLogin);
            Console.WriteLine("Button checked: " + AutoLogonBtn.Checked);
            ScrunchPLUS.Properties.Settings.Default.Save();
        }

        private void DiscordStatusBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DiscordStatusBtn.Checked == true)
            {
                ScrunchPLUS.Properties.Settings.Default.DiscordRpc = "true";
            }
            else if (DiscordStatusBtn.Checked == false)
            {
                ScrunchPLUS.Properties.Settings.Default.DiscordRpc = "false";
            }
            Console.WriteLine("Value of button saved: " + ScrunchPLUS.Properties.Settings.Default.DiscordRpc);
            Console.WriteLine("Button checked: " + DiscordStatusBtn.Checked);
            ScrunchPLUS.Properties.Settings.Default.Save();
        }
    }
}
