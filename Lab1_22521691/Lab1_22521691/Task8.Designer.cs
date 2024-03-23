namespace Lab1_22521691
{
    partial class Task8
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
            exitBtn = new Button();
            insertLB = new Label();
            insertTB = new TextBox();
            button1 = new Button();
            insertBtn = new Button();
            inforLB = new Label();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.FlatAppearance.BorderColor = Color.White;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = SystemColors.ButtonFace;
            exitBtn.Location = new Point(532, 58);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(90, 41);
            exitBtn.TabIndex = 8;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exit_clicked;
            // 
            // insertLB
            // 
            insertLB.AutoSize = true;
            insertLB.BackColor = Color.Transparent;
            insertLB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertLB.ForeColor = SystemColors.ButtonFace;
            insertLB.Location = new Point(12, 19);
            insertLB.Name = "insertLB";
            insertLB.Size = new Size(170, 29);
            insertLB.TabIndex = 0;
            insertLB.Text = "Nhập thông tin:";
            // 
            // insertTB
            // 
            insertTB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertTB.Location = new Point(187, 16);
            insertTB.Name = "insertTB";
            insertTB.Size = new Size(601, 36);
            insertTB.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(436, 58);
            button1.Name = "button1";
            button1.Size = new Size(90, 41);
            button1.TabIndex = 10;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clear_clicked;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.Transparent;
            insertBtn.FlatAppearance.BorderColor = Color.White;
            insertBtn.FlatStyle = FlatStyle.Flat;
            insertBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertBtn.ForeColor = SystemColors.ButtonFace;
            insertBtn.Location = new Point(340, 58);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(90, 41);
            insertBtn.TabIndex = 11;
            insertBtn.Text = "Nhập";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insert_clicked;
            // 
            // inforLB
            // 
            inforLB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inforLB.ForeColor = SystemColors.ButtonFace;
            inforLB.Location = new Point(340, 115);
            inforLB.Name = "inforLB";
            inforLB.Padding = new Padding(0, 0, 0, 5);
            inforLB.Size = new Size(448, 355);
            inforLB.TabIndex = 12;
            // 
            // Task8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_dank_meme;
            ClientSize = new Size(800, 477);
            Controls.Add(inforLB);
            Controls.Add(insertBtn);
            Controls.Add(button1);
            Controls.Add(insertTB);
            Controls.Add(insertLB);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xử lý mảng";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label insertLB;
        private TextBox insertTB;
        private Button button1;
        private Button insertBtn;
        private Label inforLB;
    }
}