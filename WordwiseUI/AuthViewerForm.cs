using WordwiseLibrary.Data.Controller;

namespace WordwiseUI
{
    public partial class AuthViewerForm : Form
    {
        public AuthViewerForm()
        {
            InitializeComponent();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel2.BackColor = SystemColors.Control;
            txtUsername.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void AuthViewerForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter username and password");
                    return;
                }
                if (UserController.Login(txtUsername.Text, txtPassword.Text) == null)
                {
                    MessageBox.Show("Invalid username or password");
                    return;
                }
                else
                {
                    var frm = new WordLearningForm();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }
        }
    }
}