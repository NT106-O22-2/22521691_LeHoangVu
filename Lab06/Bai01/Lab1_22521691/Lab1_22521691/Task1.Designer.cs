﻿namespace Lab1_22521691
{
    partial class Task1
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
            firstNum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            secondNum = new TextBox();
            result = new TextBox();
            calculated = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(72, 83);
            label1.Name = "label1";
            label1.Size = new Size(110, 33);
            label1.TabIndex = 0;
            label1.Text = "Số thứ 1";
            // 
            // firstNum
            // 
            firstNum.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNum.Location = new Point(210, 80);
            firstNum.Name = "firstNum";
            firstNum.Size = new Size(292, 39);
            firstNum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(72, 173);
            label2.Name = "label2";
            label2.Size = new Size(110, 33);
            label2.TabIndex = 2;
            label2.Text = "Số thứ 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(72, 307);
            label3.Name = "label3";
            label3.Size = new Size(101, 33);
            label3.TabIndex = 3;
            label3.Text = "Kết quả";
            // 
            // secondNum
            // 
            secondNum.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNum.Location = new Point(210, 170);
            secondNum.Name = "secondNum";
            secondNum.Size = new Size(292, 39);
            secondNum.TabIndex = 4;
            // 
            // result
            // 
            result.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(210, 304);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(292, 39);
            result.TabIndex = 5;
            // 
            // calculated
            // 
            calculated.BackColor = Color.Transparent;
            calculated.FlatAppearance.BorderColor = Color.Green;
            calculated.FlatAppearance.BorderSize = 4;
            calculated.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            calculated.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            calculated.FlatStyle = FlatStyle.Flat;
            calculated.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculated.ForeColor = SystemColors.ButtonFace;
            calculated.Location = new Point(210, 234);
            calculated.Name = "calculated";
            calculated.Size = new Size(121, 48);
            calculated.TabIndex = 6;
            calculated.Text = "Tính";
            calculated.UseVisualStyleBackColor = false;
            calculated.Click += caculate_button;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.Green;
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(350, 234);
            button2.Name = "button2";
            button2.Size = new Size(114, 48);
            button2.TabIndex = 7;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += exit_button;
            // 
            // Task1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_dank_meme2;
            ClientSize = new Size(655, 410);
            Controls.Add(button2);
            Controls.Add(calculated);
            Controls.Add(result);
            Controls.Add(secondNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(firstNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính tổng 2 số nguyên";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox firstNum;
        private Label label2;
        private Label label3;
        private TextBox secondNum;
        private TextBox result;
        private Button calculated;
        private Button button2;
    }
}