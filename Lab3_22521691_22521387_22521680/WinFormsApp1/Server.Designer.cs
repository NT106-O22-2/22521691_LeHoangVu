﻿namespace Bai01
{
    partial class Server
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
            label1 = new Label();
            label2 = new Label();
            txbPort = new TextBox();
            btnListen = new Button();
            lsvMessage = new ListView();
            lblListening = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Port:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 74);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Received messages";
            // 
            // txbPort
            // 
            txbPort.Location = new Point(109, 29);
            txbPort.Margin = new Padding(2, 2, 2, 2);
            txbPort.Name = "txbPort";
            txbPort.Size = new Size(121, 27);
            txbPort.TabIndex = 2;
            // 
            // btnListen
            // 
            btnListen.Location = new Point(494, 22);
            btnListen.Margin = new Padding(2, 2, 2, 2);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(90, 32);
            btnListen.TabIndex = 3;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = true;
            btnListen.Click += btnListen_Click;
            // 
            // lsvMessage
            // 
            lsvMessage.Location = new Point(52, 106);
            lsvMessage.Margin = new Padding(2, 2, 2, 2);
            lsvMessage.Name = "lsvMessage";
            lsvMessage.Size = new Size(533, 222);
            lsvMessage.TabIndex = 4;
            lsvMessage.UseCompatibleStateImageBehavior = false;
            lsvMessage.View = View.List;
            // 
            // lblListening
            // 
            lblListening.AutoSize = true;
            lblListening.Location = new Point(202, 74);
            lblListening.Margin = new Padding(2, 0, 2, 0);
            lblListening.Name = "lblListening";
            lblListening.Size = new Size(37, 20);
            lblListening.TabIndex = 6;
            lblListening.Text = "wait";
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(640, 360);
            Controls.Add(lblListening);
            Controls.Add(lsvMessage);
            Controls.Add(btnListen);
            Controls.Add(txbPort);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Server";
            Text = "Server";
            FormClosed += Server_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txbPort;
        private Button btnListen;
        private ListView lsvMessage;
        private Label lblListening;
    }
}