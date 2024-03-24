namespace Lab1_22521691
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
            exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            firstNum = new TextBox();
            secondNum = new TextBox();
            thirdNum = new TextBox();
            findBtn = new Button();
            deleteBtn = new Button();
            label4 = new Label();
            maxNum = new TextBox();
            minNum = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(12, 12);
            exit.Name = "exit";
            exit.Size = new Size(90, 41);
            exit.TabIndex = 8;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(30, 87);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 9;
            label1.Text = "Số thứ nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(30, 149);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 10;
            label2.Text = "Số thứ hai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(30, 211);
            label3.Name = "label3";
            label3.Size = new Size(101, 26);
            label3.TabIndex = 11;
            label3.Text = "Số thứ ba";
            // 
            // firstNum
            // 
            firstNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNum.Location = new Point(182, 84);
            firstNum.Name = "firstNum";
            firstNum.Size = new Size(125, 34);
            firstNum.TabIndex = 12;
            // 
            // secondNum
            // 
            secondNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNum.Location = new Point(182, 146);
            secondNum.Name = "secondNum";
            secondNum.Size = new Size(125, 34);
            secondNum.TabIndex = 13;
            // 
            // thirdNum
            // 
            thirdNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            thirdNum.Location = new Point(182, 208);
            thirdNum.Name = "thirdNum";
            thirdNum.Size = new Size(125, 34);
            thirdNum.TabIndex = 14;
            // 
            // findBtn
            // 
            findBtn.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findBtn.Location = new Point(42, 285);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(119, 46);
            findBtn.TabIndex = 15;
            findBtn.Text = "Tìm";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += find_num;
            // 
            // deleteBtn
            // 
            deleteBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 224, 192);
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Times New Roman", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(182, 285);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(125, 46);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += del_num;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(465, 92);
            label4.Name = "label4";
            label4.Size = new Size(119, 26);
            label4.TabIndex = 17;
            label4.Text = "Số lớn nhất";
            // 
            // maxNum
            // 
            maxNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maxNum.Location = new Point(465, 121);
            maxNum.Name = "maxNum";
            maxNum.ReadOnly = true;
            maxNum.Size = new Size(125, 34);
            maxNum.TabIndex = 18;
            // 
            // minNum
            // 
            minNum.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minNum.Location = new Point(465, 224);
            minNum.Name = "minNum";
            minNum.ReadOnly = true;
            minNum.Size = new Size(125, 34);
            minNum.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(465, 195);
            label5.Name = "label5";
            label5.Size = new Size(125, 26);
            label5.TabIndex = 19;
            label5.Text = "Số nhỏ nhất";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_dank_meme3;
            ClientSize = new Size(659, 414);
            Controls.Add(minNum);
            Controls.Add(label5);
            Controls.Add(maxNum);
            Controls.Add(label4);
            Controls.Add(deleteBtn);
            Controls.Add(findBtn);
            Controls.Add(thirdNum);
            Controls.Add(secondNum);
            Controls.Add(firstNum);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Số lớn nhất, nhỏ nhất";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox firstNum;
        private TextBox secondNum;
        private TextBox thirdNum;
        private Button findBtn;
        private Button deleteBtn;
        private Label label4;
        private TextBox maxNum;
        private TextBox minNum;
        private Label label5;
    }
}