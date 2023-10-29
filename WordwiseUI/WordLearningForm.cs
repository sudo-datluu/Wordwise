using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordwiseLibrary.Data.ExternalAPI;

namespace WordwiseUI
{
    public partial class WordLearningForm : Form
    {
        public WordLearningForm()
        {
            InitializeComponent();
        }

        private async void WordLearningForm_Load(object sender, EventArgs e)
        {
            var newWord = await APIClient.GetRandomWord();
            if (newWord == null)
            {
                MessageBox.Show("Something wrong. Cannot generate new word");
                return;
            }
            else
            {
                txtNewWord.Text = $"{newWord.word}\n/{newWord.pronunciation}/";
                txtDefinition.Text = $"{newWord.definition}";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private async void btnGetWord_Click(object sender, EventArgs e)
        {
            var newWord = await APIClient.GetRandomWord();
            if (newWord == null)
            {
                MessageBox.Show("Something wrong. Cannot generate new word");
                return;
            }
            else
            {
                txtNewWord.Text = $"{newWord.word}\n/{newWord.pronunciation}/";
                txtDefinition.Text = $"{newWord.definition}";
            }
        }
    }
}
