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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!Form1.logins.ContainsKey(txtUsername.Text))
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    Form1.logins.Add(txtUsername.Text, txtPassword.Text);
                    lblError.Text = "User added";
                    if (checkAdmin.Checked)
                    {
                        lblError.Text += " as admin";
                        Form1.admins.Add(txtUsername.Text);
                    }
                    lblError.Text += ".";
                }
                else
                {
                    lblError.Text = "Passwords do not match.";
                }
            }
            else
            {
                lblError.Text = "That username already exists.";
            }
        }
    }
}
