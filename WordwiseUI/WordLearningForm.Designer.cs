namespace WordwiseUI
{
    partial class WordLearningForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordLearningForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            button1 = new Button();
            btnGetWord = new Button();
            txtNewWord = new TextBox();
            txtDefinition = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 525);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 11);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 93);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(41, 128, 185);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(24, 323);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(111, 49);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 185);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 165);
            button1.Name = "button1";
            button1.Size = new Size(111, 49);
            button1.TabIndex = 2;
            button1.Text = "Word Set";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnGetWord
            // 
            btnGetWord.BackColor = Color.FromArgb(41, 128, 185);
            btnGetWord.FlatStyle = FlatStyle.Flat;
            btnGetWord.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetWord.ForeColor = Color.White;
            btnGetWord.Location = new Point(430, 393);
            btnGetWord.Name = "btnGetWord";
            btnGetWord.Size = new Size(183, 36);
            btnGetWord.TabIndex = 6;
            btnGetWord.Text = "Get new word";
            btnGetWord.UseVisualStyleBackColor = false;
            btnGetWord.Click += btnGetWord_Click;
            // 
            // txtNewWord
            // 
            txtNewWord.BackColor = Color.DeepSkyBlue;
            txtNewWord.BorderStyle = BorderStyle.None;
            txtNewWord.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewWord.Location = new Point(405, 100);
            txtNewWord.Multiline = true;
            txtNewWord.Name = "txtNewWord";
            txtNewWord.ReadOnly = true;
            txtNewWord.Size = new Size(250, 82);
            txtNewWord.TabIndex = 7;
            txtNewWord.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDefinition
            // 
            txtDefinition.BackColor = Color.DeepSkyBlue;
            txtDefinition.BorderStyle = BorderStyle.None;
            txtDefinition.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDefinition.Location = new Point(323, 216);
            txtDefinition.Multiline = true;
            txtDefinition.Name = "txtDefinition";
            txtDefinition.ReadOnly = true;
            txtDefinition.Size = new Size(395, 135);
            txtDefinition.TabIndex = 7;
            txtDefinition.TextAlign = HorizontalAlignment.Center;
            // 
            // WordLearningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(910, 525);
            Controls.Add(txtDefinition);
            Controls.Add(txtNewWord);
            Controls.Add(btnGetWord);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WordLearningForm";
            Text = "WordLearningForm";
            Load += WordLearningForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnGetWord;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private TextBox txtNewWord;
        private TextBox txtDefinition;
    }
}