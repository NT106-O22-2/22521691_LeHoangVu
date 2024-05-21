namespace Bai01
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
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbSender = new TextBox();
            tbReceive = new TextBox();
            tbSubject = new TextBox();
            tbBody = new TextBox();
            tbPassword = new TextBox();
            label5 = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(0, 192, 192);
            btnSend.FlatAppearance.MouseDownBackColor = Color.Teal;
            btnSend.FlatAppearance.MouseOverBackColor = Color.Cyan;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 11F);
            btnSend.Location = new Point(28, 25);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(112, 55);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(254, 40);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 1;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(282, 137);
            label2.Name = "label2";
            label2.Size = new Size(41, 30);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(97, 201);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 3;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(114, 247);
            label4.Name = "label4";
            label4.Size = new Size(68, 30);
            label4.TabIndex = 4;
            label4.Text = "Body:";
            // 
            // tbSender
            // 
            tbSender.Font = new Font("Segoe UI", 11F);
            tbSender.Location = new Point(329, 37);
            tbSender.Name = "tbSender";
            tbSender.Size = new Size(273, 37);
            tbSender.TabIndex = 5;
            // 
            // tbReceive
            // 
            tbReceive.Font = new Font("Segoe UI", 11F);
            tbReceive.Location = new Point(329, 130);
            tbReceive.Name = "tbReceive";
            tbReceive.Size = new Size(273, 37);
            tbReceive.TabIndex = 6;
            // 
            // tbSubject
            // 
            tbSubject.Font = new Font("Segoe UI", 11F);
            tbSubject.Location = new Point(223, 195);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(554, 37);
            tbSubject.TabIndex = 7;
            // 
            // tbBody
            // 
            tbBody.Font = new Font("Segoe UI", 11F);
            tbBody.Location = new Point(223, 244);
            tbBody.Multiline = true;
            tbBody.Name = "tbBody";
            tbBody.Size = new Size(554, 255);
            tbBody.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 11F);
            tbPassword.Location = new Point(329, 84);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(273, 37);
            tbPassword.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(218, 91);
            label5.Name = "label5";
            label5.Size = new Size(108, 30);
            label5.TabIndex = 9;
            label5.Text = "Password:";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11F);
            btnClose.Location = new Point(28, 109);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 53);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 511);
            Controls.Add(btnClose);
            Controls.Add(tbPassword);
            Controls.Add(label5);
            Controls.Add(tbBody);
            Controls.Add(tbSubject);
            Controls.Add(tbReceive);
            Controls.Add(tbSender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbSender;
        private TextBox tbReceive;
        private TextBox tbSubject;
        private TextBox tbBody;
        private TextBox tbPassword;
        private Label label5;
        private Button btnClose;
    }
}
