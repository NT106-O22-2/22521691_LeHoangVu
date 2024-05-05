namespace Task5
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtURL = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 0;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(33, 95);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(37, 151);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtURL
            // 
            txtURL.Font = new Font("Times New Roman", 12F);
            txtURL.Location = new Point(159, 21);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(491, 35);
            txtURL.TabIndex = 3;
            txtURL.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F);
            txtUsername.Location = new Point(159, 83);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(327, 35);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.Location = new Point(159, 148);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(327, 35);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumAquamarine;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 12F);
            btnLogin.Location = new Point(513, 83);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(137, 98);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(41, 219);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(609, 229);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(684, 472);
            Controls.Add(richTextBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtURL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtURL;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private RichTextBox richTextBox1;
    }
}
