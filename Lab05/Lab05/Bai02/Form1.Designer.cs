namespace Bai02
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
            label4 = new Label();
            lvEmails = new ListView();
            clEmail = new ColumnHeader();
            clFrom = new ColumnHeader();
            clTime = new ColumnHeader();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            lbTotal = new Label();
            lbRecent = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(26, 118);
            label3.Name = "label3";
            label3.Size = new Size(64, 30);
            label3.TabIndex = 2;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(221, 118);
            label4.Name = "label4";
            label4.Size = new Size(83, 30);
            label4.TabIndex = 3;
            label4.Text = "Recent:";
            // 
            // lvEmails
            // 
            lvEmails.Columns.AddRange(new ColumnHeader[] { clEmail, clFrom, clTime });
            lvEmails.Font = new Font("Segoe UI", 11F);
            lvEmails.Location = new Point(26, 164);
            lvEmails.Name = "lvEmails";
            lvEmails.Size = new Size(1218, 533);
            lvEmails.TabIndex = 4;
            lvEmails.UseCompatibleStateImageBehavior = false;
            lvEmails.View = View.Details;
            // 
            // clEmail
            // 
            clEmail.Text = "Email";
            clEmail.Width = 600;
            // 
            // clFrom
            // 
            clFrom.Text = "From";
            clFrom.Width = 400;
            // 
            // clTime
            // 
            clTime.Text = "Thời gian";
            clTime.Width = 218;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 11F);
            tbUsername.Location = new Point(132, 25);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(351, 37);
            tbUsername.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.Location = new Point(132, 64);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(351, 37);
            tbPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Green;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.Location = new Point(619, 22);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 73);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 11F);
            lbTotal.Location = new Point(124, 118);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(71, 30);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "label5";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Font = new Font("Segoe UI", 11F);
            lbRecent.Location = new Point(345, 118);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(71, 30);
            lbRecent.TabIndex = 9;
            lbRecent.Text = "label6";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(192, 0, 0);
            btnClose.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.Location = new Point(1114, 39);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(130, 53);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1286, 709);
            Controls.Add(btnClose);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lvEmails);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView lvEmails;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label lbTotal;
        private Label lbRecent;
        private ColumnHeader clEmail;
        private Button btnClose;
        private ColumnHeader clFrom;
        private ColumnHeader clTime;
    }
}
