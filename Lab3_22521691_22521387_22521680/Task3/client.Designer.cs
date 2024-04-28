namespace Task3
{
    partial class client
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
            this.messageTb = new System.Windows.Forms.TextBox();
            this.ConnectBt = new System.Windows.Forms.Button();
            this.SendBT = new System.Windows.Forms.Button();
            this.DisconnectBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTb
            // 
            this.messageTb.Location = new System.Drawing.Point(28, 36);
            this.messageTb.Multiline = true;
            this.messageTb.Name = "messageTb";
            this.messageTb.Size = new System.Drawing.Size(468, 149);
            this.messageTb.TabIndex = 0;
            // 
            // ConnectBt
            // 
            this.ConnectBt.Location = new System.Drawing.Point(548, 41);
            this.ConnectBt.Name = "ConnectBt";
            this.ConnectBt.Size = new System.Drawing.Size(146, 29);
            this.ConnectBt.TabIndex = 1;
            this.ConnectBt.Text = "Connect";
            this.ConnectBt.UseVisualStyleBackColor = true;
            this.ConnectBt.Click += new System.EventHandler(this.ConnectBt_Click);
            // 
            // SendBT
            // 
            this.SendBT.Location = new System.Drawing.Point(548, 99);
            this.SendBT.Name = "SendBT";
            this.SendBT.Size = new System.Drawing.Size(146, 27);
            this.SendBT.TabIndex = 2;
            this.SendBT.Text = "Send";
            this.SendBT.UseVisualStyleBackColor = true;
            this.SendBT.Click += new System.EventHandler(this.SendBT_Click);
            // 
            // DisconnectBt
            // 
            this.DisconnectBt.Location = new System.Drawing.Point(548, 158);
            this.DisconnectBt.Name = "DisconnectBt";
            this.DisconnectBt.Size = new System.Drawing.Size(146, 27);
            this.DisconnectBt.TabIndex = 2;
            this.DisconnectBt.Text = "Disconnect";
            this.DisconnectBt.UseVisualStyleBackColor = true;
            this.DisconnectBt.Click += new System.EventHandler(this.DisconnectBt_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 223);
            this.Controls.Add(this.DisconnectBt);
            this.Controls.Add(this.SendBT);
            this.Controls.Add(this.ConnectBt);
            this.Controls.Add(this.messageTb);
            this.Name = "client";
            this.Text = "client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTb;
        private System.Windows.Forms.Button ConnectBt;
        private System.Windows.Forms.Button SendBT;
        private System.Windows.Forms.Button DisconnectBt;
    }
}