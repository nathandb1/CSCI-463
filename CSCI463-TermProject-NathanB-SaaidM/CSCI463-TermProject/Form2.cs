using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCI463_TermProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string foundPassword = "";
            if (Form1.logins.TryGetValue(txtUsername.Text, out foundPassword) && (foundPassword == password))
            {
                //Form1.lblWelcome.Text = "Welcome, " + txtUsername.Text + ".";
                Form1.loggedIn = true;
                if (Form1.admins.Contains(txtUsername.Text))
                {
                    Form1.loggedInAdmin = true;
                }
                //check if username is an admin here. Create a public bool for loggedin, and one for loggedinAdmin.
                this.Close();
            }
            else
            {
                lblIncorrect.Text = "Incorrect username or password.";
            }
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
