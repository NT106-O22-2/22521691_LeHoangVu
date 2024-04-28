namespace Task3
{
    partial class sever
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
            this.messageLv = new System.Windows.Forms.ListView();
            this.StartBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageLv
            // 
            this.messageLv.HideSelection = false;
            this.messageLv.Location = new System.Drawing.Point(12, 12);
            this.messageLv.Name = "messageLv";
            this.messageLv.Size = new System.Drawing.Size(493, 316);
            this.messageLv.TabIndex = 0;
            this.messageLv.UseCompatibleStateImageBehavior = false;
            this.messageLv.View = System.Windows.Forms.View.List;
            // 
            // StartBt
            // 
            this.StartBt.Location = new System.Drawing.Point(185, 334);
            this.StartBt.Name = "StartBt";
            this.StartBt.Size = new System.Drawing.Size(134, 36);
            this.StartBt.TabIndex = 1;
            this.StartBt.Text = "Start";
            this.StartBt.UseVisualStyleBackColor = true;
            this.StartBt.Click += new System.EventHandler(this.StartBt_Click);
            // 
            // sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task3.Properties.Resources.Lab3_NT132;
            this.ClientSize = new System.Drawing.Size(515, 374);
            this.Controls.Add(this.StartBt);
            this.Controls.Add(this.messageLv);
            this.Name = "sever";
            this.Text = "Sever";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView messageLv;
        private System.Windows.Forms.Button StartBt;
    }
}