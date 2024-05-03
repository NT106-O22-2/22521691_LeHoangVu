namespace Task3
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
            this.loadBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.downFileBtn = new System.Windows.Forms.Button();
            this.downResourcesBtn = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.Location = new System.Drawing.Point(577, 10);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(128, 35);
            this.loadBtn.TabIndex = 9;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 35);
            this.textBox1.TabIndex = 8;
            // 
            // downFileBtn
            // 
            this.downFileBtn.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downFileBtn.Location = new System.Drawing.Point(377, 51);
            this.downFileBtn.Name = "downFileBtn";
            this.downFileBtn.Size = new System.Drawing.Size(140, 35);
            this.downFileBtn.TabIndex = 11;
            this.downFileBtn.Text = "Down Files";
            this.downFileBtn.UseVisualStyleBackColor = true;
            this.downFileBtn.Click += new System.EventHandler(this.downFileBtn_Click);
            // 
            // downResourcesBtn
            // 
            this.downResourcesBtn.Font = new System.Drawing.Font("UTM Avo", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downResourcesBtn.Location = new System.Drawing.Point(523, 51);
            this.downResourcesBtn.Name = "downResourcesBtn";
            this.downResourcesBtn.Size = new System.Drawing.Size(182, 35);
            this.downResourcesBtn.TabIndex = 12;
            this.downResourcesBtn.Text = "Down Resources";
            this.downResourcesBtn.UseVisualStyleBackColor = true;
            this.downResourcesBtn.Click += new System.EventHandler(this.downResourcesBtn_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 91);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(693, 570);
            this.webView.TabIndex = 13;
            this.webView.ZoomFactor = 1D;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task3.Properties.Resources.Task2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(719, 666);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.downResourcesBtn);
            this.Controls.Add(this.downFileBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button downFileBtn;
        private System.Windows.Forms.Button downResourcesBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

