using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordwiseLibrary.Data.Controller;

namespace WordwiseUI
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }


        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password");
                    return;
                }
                if (UserController.CreateAccount(txtUsername.Text, txtPassword.Text) == null)
                {
                    MessageBox.Show("Username existed");
                    return;
                }
                else
                {
                    MessageBox.Show("Account created successfully", "Signup");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Signup");
            }
        }

        private void btnChangeView_Click(object sender, EventArgs e)
        {
            var frm = new AuthViewerForm();
            //frm.Show();
            //this.Hide();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

