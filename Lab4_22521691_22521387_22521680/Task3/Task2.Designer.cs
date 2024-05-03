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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnDownFiles = new System.Windows.Forms.Button();
            this.btnDownResources = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(22, 131);
            this.webView21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(788, 513);
            this.webView21.TabIndex = 13;
            this.webView21.ZoomFactor = 1D;
            // 
            // btnViewSource
            // 
            this.btnViewSource.BackColor = System.Drawing.Color.LightCyan;
            this.btnViewSource.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnViewSource.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewSource.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewSource.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnViewSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSource.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSource.Location = new System.Drawing.Point(306, 65);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(135, 45);
            this.btnViewSource.TabIndex = 19;
            this.btnViewSource.Text = "View Source ";
            this.btnViewSource.UseVisualStyleBackColor = false;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(114, 17);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(548, 35);
            this.txtUrl.TabIndex = 18;
            this.txtUrl.Text = "https://uit.edu.vn";
            // 
            // btnDownFiles
            // 
            this.btnDownFiles.BackColor = System.Drawing.Color.LightCyan;
            this.btnDownFiles.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDownFiles.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDownFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDownFiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnDownFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownFiles.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownFiles.Location = new System.Drawing.Point(454, 65);
            this.btnDownFiles.Name = "btnDownFiles";
            this.btnDownFiles.Size = new System.Drawing.Size(125, 45);
            this.btnDownFiles.TabIndex = 17;
            this.btnDownFiles.Text = "Down Files";
            this.btnDownFiles.UseVisualStyleBackColor = false;
            this.btnDownFiles.Click += new System.EventHandler(this.btnDownFiles_Click);
            // 
            // btnDownResources
            // 
            this.btnDownResources.BackColor = System.Drawing.Color.LightCyan;
            this.btnDownResources.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDownResources.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDownResources.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDownResources.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnDownResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownResources.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownResources.Location = new System.Drawing.Point(595, 65);
            this.btnDownResources.Name = "btnDownResources";
            this.btnDownResources.Size = new System.Drawing.Size(215, 45);
            this.btnDownResources.TabIndex = 16;
            this.btnDownResources.Text = "Down Resources";
            this.btnDownResources.UseVisualStyleBackColor = false;
            this.btnDownResources.Click += new System.EventHandler(this.btnDownResources_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.LightCyan;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(684, 11);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(127, 45);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCyan;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(22, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 45);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 657);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnDownFiles);
            this.Controls.Add(this.btnDownResources);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.webView21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnDownFiles;
        private System.Windows.Forms.Button btnDownResources;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLoad;
    }
}

