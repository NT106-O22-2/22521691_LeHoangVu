namespace Task6
{
    partial class task6
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
            this.severBt = new System.Windows.Forms.Button();
            this.ClientBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // severBt
            // 
            this.severBt.Location = new System.Drawing.Point(34, 68);
            this.severBt.Name = "severBt";
            this.severBt.Size = new System.Drawing.Size(136, 61);
            this.severBt.TabIndex = 0;
            this.severBt.Text = "Mở sever";
            this.severBt.UseVisualStyleBackColor = true;
            this.severBt.Click += new System.EventHandler(this.severBt_Click);
            // 
            // ClientBt
            // 
            this.ClientBt.Location = new System.Drawing.Point(232, 71);
            this.ClientBt.Name = "ClientBt";
            this.ClientBt.Size = new System.Drawing.Size(108, 58);
            this.ClientBt.TabIndex = 0;
            this.ClientBt.Text = "Mở client";
            this.ClientBt.UseVisualStyleBackColor = true;
            this.ClientBt.Click += new System.EventHandler(this.ClientBt_Click);
            // 
            // task6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 218);
            this.Controls.Add(this.ClientBt);
            this.Controls.Add(this.severBt);
            this.Name = "task6";
            this.Text = "task6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button severBt;
        private System.Windows.Forms.Button ClientBt;
    }
}