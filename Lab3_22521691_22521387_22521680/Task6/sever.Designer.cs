﻿namespace sever1
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
            this.StartServerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartServerButton
            // 
            this.StartServerButton.Location = new System.Drawing.Point(489, 296);
            this.StartServerButton.Name = "StartServerButton";
            this.StartServerButton.Size = new System.Drawing.Size(75, 59);
            this.StartServerButton.TabIndex = 0;
            this.StartServerButton.Text = "Start";
            this.StartServerButton.UseVisualStyleBackColor = true;
            this.StartServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 367);
            this.Controls.Add(this.StartServerButton);
            this.Name = "sever";
            this.Text = "Sever";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartServerButton;
    }
}

