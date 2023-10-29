namespace WordwiseUI
{
    partial class AuthViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthViewerForm));
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btnLogin = new Button();
            panel4 = new Panel();
            txtPassword = new TextBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            txtUsername = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            btnChangeView = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(182, 466);
            label4.Name = "label4";
            label4.Size = new Size(118, 19);
            label4.TabIndex = 1;
            label4.Text = "Le Tuan Dat Luu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(161, 485);
            label5.Name = "label5";
            label5.Size = new Size(139, 19);
            label5.TabIndex = 1;
            label5.Text = "Duy Khang Thuong";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(197, 449);
            label1.Name = "label1";
            label1.Size = new Size(103, 17);
            label1.TabIndex = 1;
            label1.Text = "Developed by:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 285);
            label3.Name = "label3";
            label3.Size = new Size(209, 21);
            label3.TabIndex = 1;
            label3.Text = "Unleash Your Potential!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(65, 248);
            label2.Name = "label2";
            label2.Size = new Size(235, 21);
            label2.TabIndex = 1;
            label2.Text = "Expand Your Vocabulary,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnChangeView);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 530);
            panel3.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(56, 318);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(txtPassword);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 45);
            panel4.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(41, 128, 185);
            txtPassword.Location = new Point(56, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(370, 21);
            txtPassword.TabIndex = 1;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 12);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.MouseDown += pictureBox3_MouseDown;
            pictureBox3.MouseUp += pictureBox3_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 45);
            panel2.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.FromArgb(41, 128, 185);
            txtUsername.Location = new Point(56, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 25);
            txtUsername.TabIndex = 1;
            txtUsername.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(41, 128, 185);
            label6.Location = new Point(32, 139);
            label6.Name = "label6";
            label6.Size = new Size(206, 21);
            label6.TabIndex = 1;
            label6.Text = "Login to your account";
            // 
            // btnChangeView
            // 
            btnChangeView.BackColor = SystemColors.Control;
            btnChangeView.FlatAppearance.BorderSize = 0;
            btnChangeView.FlatStyle = FlatStyle.Flat;
            btnChangeView.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeView.ForeColor = Color.FromArgb(41, 128, 185);
            btnChangeView.Location = new Point(239, 318);
            btnChangeView.Name = "btnChangeView";
            btnChangeView.Size = new Size(187, 35);
            btnChangeView.TabIndex = 4;
            btnChangeView.Text = "Register new account";
            btnChangeView.UseVisualStyleBackColor = false;
            // 
            // AuthViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthViewerForm";
            Text = "Form1";
            Load += AuthViewerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnLogin;
        private Button btnChangeView;
    }
}