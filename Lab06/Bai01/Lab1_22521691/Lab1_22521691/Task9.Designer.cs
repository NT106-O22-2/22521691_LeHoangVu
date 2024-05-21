namespace Lab1_22521691
{
    partial class Task9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task9));
            insertLB = new Label();
            insertTB = new TextBox();
            inforLB = new Label();
            insertBtn = new Button();
            button1 = new Button();
            exitBtn = new Button();
            button2 = new Button();
            label1 = new Label();
            resultTB = new TextBox();
            SuspendLayout();
            // 
            // insertLB
            // 
            insertLB.AutoSize = true;
            insertLB.BackColor = Color.Transparent;
            insertLB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertLB.ForeColor = SystemColors.ButtonFace;
            insertLB.Location = new Point(12, 23);
            insertLB.Name = "insertLB";
            insertLB.Size = new Size(156, 29);
            insertLB.TabIndex = 1;
            insertLB.Text = "Nhập món ăn:";
            // 
            // insertTB
            // 
            insertTB.BorderStyle = BorderStyle.FixedSingle;
            insertTB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertTB.Location = new Point(165, 20);
            insertTB.Name = "insertTB";
            insertTB.Size = new Size(224, 36);
            insertTB.TabIndex = 10;
            // 
            // inforLB
            // 
            inforLB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inforLB.ForeColor = SystemColors.ButtonFace;
            inforLB.Location = new Point(395, 20);
            inforLB.Name = "inforLB";
            inforLB.Padding = new Padding(0, 0, 0, 5);
            inforLB.Size = new Size(393, 421);
            inforLB.TabIndex = 13;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.Transparent;
            insertBtn.FlatAppearance.BorderColor = Color.White;
            insertBtn.FlatStyle = FlatStyle.Flat;
            insertBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insertBtn.ForeColor = SystemColors.ButtonFace;
            insertBtn.Location = new Point(280, 72);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(109, 41);
            insertBtn.TabIndex = 16;
            insertBtn.Text = "Nhập";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertFood;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(165, 72);
            button1.Name = "button1";
            button1.Size = new Size(109, 41);
            button1.TabIndex = 15;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clear_clicked;
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Transparent;
            exitBtn.FlatAppearance.BorderColor = Color.White;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = SystemColors.ButtonFace;
            exitBtn.Location = new Point(59, 72);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(100, 41);
            exitBtn.TabIndex = 14;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exit_clicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(165, 119);
            button2.Name = "button2";
            button2.Size = new Size(224, 59);
            button2.TabIndex = 17;
            button2.Text = "Tìm món ăn";
            button2.UseVisualStyleBackColor = false;
            button2.Click += find_food;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 330);
            label1.Name = "label1";
            label1.Size = new Size(215, 29);
            label1.TabIndex = 18;
            label1.Text = "Món ăn hôm nay là:";
            // 
            // resultTB
            // 
            resultTB.BackColor = SystemColors.ScrollBar;
            resultTB.BorderStyle = BorderStyle.FixedSingle;
            resultTB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultTB.Location = new Point(12, 373);
            resultTB.Name = "resultTB";
            resultTB.ReadOnly = true;
            resultTB.Size = new Size(377, 36);
            resultTB.TabIndex = 19;
            resultTB.TextAlign = HorizontalAlignment.Center;
            // 
            // Task9
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(resultTB);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(insertBtn);
            Controls.Add(button1);
            Controls.Add(exitBtn);
            Controls.Add(inforLB);
            Controls.Add(insertTB);
            Controls.Add(insertLB);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hôm nay ăn gì";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label insertLB;
        private TextBox insertTB;
        private Label inforLB;
        private Button insertBtn;
        private Button button1;
        private Button exitBtn;
        private Button button2;
        private Label label1;
        private TextBox resultTB;
    }
}