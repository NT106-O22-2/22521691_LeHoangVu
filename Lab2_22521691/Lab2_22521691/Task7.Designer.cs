namespace Lab2_22521691
{
    partial class Task7
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
            this.driveTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // driveTree
            // 
            this.driveTree.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveTree.Location = new System.Drawing.Point(12, 12);
            this.driveTree.Name = "driveTree";
            this.driveTree.Size = new System.Drawing.Size(212, 539);
            this.driveTree.TabIndex = 1;
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2_22521691.Properties.Resources.Task7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 563);
            this.Controls.Add(this.driveTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt thư mục";
            this.Load += new System.EventHandler(this.Task7_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView driveTree;
    }
}