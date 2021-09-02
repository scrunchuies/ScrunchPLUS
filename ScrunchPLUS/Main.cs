using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace ScrunchPLUS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void LoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
