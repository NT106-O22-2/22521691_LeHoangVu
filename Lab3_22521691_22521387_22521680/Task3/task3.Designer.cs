namespace Task3
{
    partial class task3
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
            this.clientBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // severBt
            // 
            this.severBt.Location = new System.Drawing.Point(28, 53);
            this.severBt.Name = "severBt";
            this.severBt.Size = new System.Drawing.Size(166, 72);
            this.severBt.TabIndex = 0;
            this.severBt.Text = "Mở sever";
            this.severBt.UseVisualStyleBackColor = true;
            this.severBt.Click += new System.EventHandler(this.severBt_Click);
            // 
            // clientBt
            // 
            this.clientBt.Location = new System.Drawing.Point(230, 53);
            this.clientBt.Name = "clientBt";
            this.clientBt.Size = new System.Drawing.Size(172, 72);
            this.clientBt.TabIndex = 0;
            this.clientBt.Text = "Mở client";
            this.clientBt.UseVisualStyleBackColor = true;
            this.clientBt.Click += new System.EventHandler(this.clientBt_Click);
            // 
            // task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 194);
            this.Controls.Add(this.clientBt);
            this.Controls.Add(this.severBt);
            this.Name = "task3";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button severBt;
        private System.Windows.Forms.Button clientBt;
    }
}

