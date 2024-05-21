namespace Lab2_22521691
{
    partial class Task1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task1));
            this.readFileBtn = new System.Windows.Forms.Button();
            this.writeFileBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.fileData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readFileBtn
            // 
            this.readFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatAppearance.BorderSize = 0;
            this.readFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.readFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.readFileBtn.Location = new System.Drawing.Point(22, 153);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(148, 45);
            this.readFileBtn.TabIndex = 1;
            this.readFileBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.readFileBtn.UseVisualStyleBackColor = false;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // writeFileBtn
            // 
            this.writeFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.writeFileBtn.FlatAppearance.BorderSize = 0;
            this.writeFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.writeFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.writeFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.writeFileBtn.Location = new System.Drawing.Point(176, 153);
            this.writeFileBtn.Name = "writeFileBtn";
            this.writeFileBtn.Size = new System.Drawing.Size(154, 45);
            this.writeFileBtn.TabIndex = 2;
            this.writeFileBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.writeFileBtn.UseVisualStyleBackColor = false;
            this.writeFileBtn.Click += new System.EventHandler(this.writeFileBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.deleteBtn.Location = new System.Drawing.Point(176, 206);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(154, 45);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitBtn.Location = new System.Drawing.Point(22, 206);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(148, 45);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // fileData
            // 
            this.fileData.AllowDrop = true;
            this.fileData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileData.Location = new System.Drawing.Point(387, 71);
            this.fileData.Multiline = true;
            this.fileData.Name = "fileData";
            this.fileData.Size = new System.Drawing.Size(476, 386);
            this.fileData.TabIndex = 5;
            this.fileData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.fileData);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.writeFileBtn);
            this.Controls.Add(this.readFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ghi và Đọc file";
            this.Load += new System.EventHandler(this.Task1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button writeFileBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox fileData;
    }
}