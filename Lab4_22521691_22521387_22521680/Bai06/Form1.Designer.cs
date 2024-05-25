namespace Bai06
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
            richTextBox1 = new RichTextBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtURL = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGet = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 210);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(741, 304);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SeaGreen;
            btnLogin.Font = new Font("Times New Roman", 12F);
            btnLogin.Location = new Point(504, 74);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(122, 98);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.Location = new Point(150, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(327, 35);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F);
            txtUsername.Location = new Point(150, 74);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(327, 35);
            txtUsername.TabIndex = 12;
            // 
            // txtURL
            // 
            txtURL.Font = new Font("Times New Roman", 12F);
            txtURL.Location = new Point(150, 12);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(491, 35);
            txtURL.TabIndex = 11;
            txtURL.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.Location = new Point(28, 142);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 10;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 27);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 27);
            label1.TabIndex = 8;
            label1.Text = "URL";
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.MediumSeaGreen;
            btnGet.Font = new Font("Times New Roman", 12F);
            btnGet.Location = new Point(662, 74);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(107, 98);
            btnGet.TabIndex = 16;
            btnGet.Text = "GET";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 543);
            Controls.Add(btnGet);
            Controls.Add(richTextBox1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtURL);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Task6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtURL;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGet;
    }
}
