namespace Lab2_22521691
{
    partial class Task2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task2));
            this.readFileBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.fileSize = new System.Windows.Forms.TextBox();
            this.fileURL = new System.Windows.Forms.TextBox();
            this.fileLineCount = new System.Windows.Forms.TextBox();
            this.fileWordCount = new System.Windows.Forms.TextBox();
            this.fileCharCount = new System.Windows.Forms.TextBox();
            this.fileData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readFileBtn
            // 
            this.readFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatAppearance.BorderSize = 0;
            this.readFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFileBtn.Location = new System.Drawing.Point(83, 12);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(194, 58);
            this.readFileBtn.TabIndex = 0;
            this.readFileBtn.UseVisualStyleBackColor = false;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(83, 464);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(194, 54);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileName.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(187, 103);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(153, 28);
            this.fileName.TabIndex = 2;
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileSize
            // 
            this.fileSize.BackColor = System.Drawing.Color.LightGray;
            this.fileSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileSize.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSize.Location = new System.Drawing.Point(187, 156);
            this.fileSize.Name = "fileSize";
            this.fileSize.ReadOnly = true;
            this.fileSize.Size = new System.Drawing.Size(153, 28);
            this.fileSize.TabIndex = 3;
            this.fileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileURL
            // 
            this.fileURL.BackColor = System.Drawing.Color.LightGray;
            this.fileURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileURL.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileURL.Location = new System.Drawing.Point(187, 215);
            this.fileURL.Name = "fileURL";
            this.fileURL.ReadOnly = true;
            this.fileURL.Size = new System.Drawing.Size(153, 28);
            this.fileURL.TabIndex = 4;
            this.fileURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileLineCount
            // 
            this.fileLineCount.BackColor = System.Drawing.Color.LightGray;
            this.fileLineCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileLineCount.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLineCount.Location = new System.Drawing.Point(187, 273);
            this.fileLineCount.Name = "fileLineCount";
            this.fileLineCount.ReadOnly = true;
            this.fileLineCount.Size = new System.Drawing.Size(153, 28);
            this.fileLineCount.TabIndex = 5;
            this.fileLineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileWordCount
            // 
            this.fileWordCount.BackColor = System.Drawing.Color.LightGray;
            this.fileWordCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileWordCount.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileWordCount.Location = new System.Drawing.Point(187, 332);
            this.fileWordCount.Name = "fileWordCount";
            this.fileWordCount.ReadOnly = true;
            this.fileWordCount.Size = new System.Drawing.Size(153, 28);
            this.fileWordCount.TabIndex = 6;
            this.fileWordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileCharCount
            // 
            this.fileCharCount.BackColor = System.Drawing.Color.LightGray;
            this.fileCharCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileCharCount.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileCharCount.Location = new System.Drawing.Point(187, 390);
            this.fileCharCount.Name = "fileCharCount";
            this.fileCharCount.ReadOnly = true;
            this.fileCharCount.Size = new System.Drawing.Size(153, 28);
            this.fileCharCount.TabIndex = 7;
            this.fileCharCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fileData
            // 
            this.fileData.AllowDrop = true;
            this.fileData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileData.Location = new System.Drawing.Point(417, 66);
            this.fileData.Multiline = true;
            this.fileData.Name = "fileData";
            this.fileData.ReadOnly = true;
            this.fileData.Size = new System.Drawing.Size(476, 395);
            this.fileData.TabIndex = 8;
            this.fileData.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 547);
            this.Controls.Add(this.fileData);
            this.Controls.Add(this.fileCharCount);
            this.Controls.Add(this.fileWordCount);
            this.Controls.Add(this.fileLineCount);
            this.Controls.Add(this.fileURL);
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.readFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc thông tin một file .txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TextBox fileSize;
        private System.Windows.Forms.TextBox fileURL;
        private System.Windows.Forms.TextBox fileLineCount;
        private System.Windows.Forms.TextBox fileWordCount;
        private System.Windows.Forms.TextBox fileCharCount;
        private System.Windows.Forms.TextBox fileData;
    }
}