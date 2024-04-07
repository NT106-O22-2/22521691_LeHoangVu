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
            this.exitBtn = new System.Windows.Forms.Button();
            this.ptBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).BeginInit();
            this.SuspendLayout();
            // 
            // driveTree
            // 
            this.driveTree.Font = new System.Drawing.Font("UTM Avo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveTree.Location = new System.Drawing.Point(12, 12);
            this.driveTree.Name = "driveTree";
            this.driveTree.Size = new System.Drawing.Size(298, 490);
            this.driveTree.TabIndex = 1;
            this.driveTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.driveTree_BeforeExpand);
            this.driveTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.driveTree_NodeMouseDoubleClick);
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
            this.exitBtn.Location = new System.Drawing.Point(52, 506);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(138, 38);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ptBox
            // 
            this.ptBox.BackColor = System.Drawing.Color.Transparent;
            this.ptBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptBox.Location = new System.Drawing.Point(320, 43);
            this.ptBox.Name = "ptBox";
            this.ptBox.Size = new System.Drawing.Size(590, 490);
            this.ptBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBox.TabIndex = 6;
            this.ptBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(316, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "File Content";
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(318, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(592, 490);
            this.label.TabIndex = 8;
            // 
            // Task7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2_22521691.Properties.Resources.Task72;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 563);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.driveTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duyệt thư mục";
            this.Load += new System.EventHandler(this.Task7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView driveTree;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox ptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
    }
}