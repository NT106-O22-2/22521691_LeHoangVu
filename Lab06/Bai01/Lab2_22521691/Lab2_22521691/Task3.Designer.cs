namespace Lab2_22521691
{
    partial class Task3
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.Label();
            this.outputData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Location = new System.Drawing.Point(249, 463);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(193, 58);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(481, 465);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(191, 54);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inputData
            // 
            this.inputData.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Location = new System.Drawing.Point(27, 105);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(407, 301);
            this.inputData.TabIndex = 11;
            // 
            // outputData
            // 
            this.outputData.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputData.Location = new System.Drawing.Point(486, 105);
            this.outputData.Name = "outputData";
            this.outputData.Size = new System.Drawing.Size(407, 301);
            this.outputData.TabIndex = 12;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2_22521691.Properties.Resources.Task3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 557);
            this.Controls.Add(this.outputData);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loadBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc, Ghi file và tính toán";
            this.Load += new System.EventHandler(this.Task3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label inputData;
        private System.Windows.Forms.Label outputData;
    }
}