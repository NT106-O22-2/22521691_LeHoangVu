namespace Lab1_22521691
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
            label1 = new Label();
            inputTB = new TextBox();
            checkBtn = new Button();
            inforLB = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(171, 29);
            label1.TabIndex = 11;
            label1.Text = "Nhập ngày sinh";
            // 
            // inputTB
            // 
            inputTB.BackColor = SystemColors.WindowText;
            inputTB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTB.ForeColor = SystemColors.Window;
            inputTB.Location = new Point(189, 110);
            inputTB.Name = "inputTB";
            inputTB.Size = new Size(154, 36);
            inputTB.TabIndex = 12;
            // 
            // checkBtn
            // 
            checkBtn.BackColor = Color.Transparent;
            checkBtn.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            checkBtn.FlatStyle = FlatStyle.Flat;
            checkBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBtn.ForeColor = Color.White;
            checkBtn.Location = new Point(189, 170);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(134, 36);
            checkBtn.TabIndex = 13;
            checkBtn.Text = "Kiểm tra";
            checkBtn.UseVisualStyleBackColor = false;
            checkBtn.Click += check_clicked;
            // 
            // inforLB
            // 
            inforLB.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inforLB.ForeColor = SystemColors.ControlLightLight;
            inforLB.Location = new Point(358, 9);
            inforLB.Name = "inforLB";
            inforLB.Size = new Size(238, 286);
            inforLB.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 170);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 15;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += exit_clicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(109, 170);
            button2.Name = "button2";
            button2.Size = new Size(74, 36);
            button2.TabIndex = 16;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += clear_clicked;
            // 
            // Task7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.astrology_wheel_with_zodiac_signs_on_outer_space_background_mystery_and_esoteric_star_map_horoscope_illustration_spiritual_tarot_poster_vector;
            ClientSize = new Size(599, 307);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(inforLB);
            Controls.Add(checkBtn);
            Controls.Add(inputTB);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task7";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox inputTB;
        private Button checkBtn;
        private Label inforLB;
        private Button button1;
        private Button button2;
    }
}