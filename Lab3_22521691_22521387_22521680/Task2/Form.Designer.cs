namespace Task2
{
    partial class Form
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
            this.listenBtn = new System.Windows.Forms.Button();
            this.dataLv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listenBtn
            // 
            this.listenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listenBtn.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listenBtn.Location = new System.Drawing.Point(15, 22);
            this.listenBtn.Name = "listenBtn";
            this.listenBtn.Size = new System.Drawing.Size(96, 41);
            this.listenBtn.TabIndex = 4;
            this.listenBtn.Text = "Listen";
            this.listenBtn.UseVisualStyleBackColor = true;
            this.listenBtn.Click += new System.EventHandler(this.listenBtn_Click);
            // 
            // dataLv
            // 
            this.dataLv.Font = new System.Drawing.Font("UTM Avo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLv.HideSelection = false;
            this.dataLv.Location = new System.Drawing.Point(14, 69);
            this.dataLv.Name = "dataLv";
            this.dataLv.Size = new System.Drawing.Size(649, 369);
            this.dataLv.TabIndex = 3;
            this.dataLv.UseCompatibleStateImageBehavior = false;
            this.dataLv.View = System.Windows.Forms.View.List;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task2.Properties.Resources.Task2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 446);
            this.Controls.Add(this.listenBtn);
            this.Controls.Add(this.dataLv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button listenBtn;
        private System.Windows.Forms.ListView dataLv;
    }
}

