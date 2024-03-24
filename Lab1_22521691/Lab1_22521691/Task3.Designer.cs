namespace Lab1_22521691
{
    partial class Task3
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
            input = new TextBox();
            label2 = new Label();
            result = new TextBox();
            readBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // exit
            // 
            exit.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(12, 12);
            exit.Name = "exit";
            exit.Size = new Size(90, 41);
            exit.TabIndex = 9;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(36, 89);
            label1.Name = "label1";
            label1.Size = new Size(326, 29);
            label1.TabIndex = 10;
            label1.Text = "Nhập vào số nguyên từ 0 đến 9";
            // 
            // input
            // 
            input.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input.Location = new Point(368, 86);
            input.Name = "input";
            input.Size = new Size(125, 36);
            input.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(36, 210);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 12;
            label2.Text = "Kết quả";
            // 
            // result
            // 
            result.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(36, 254);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(125, 36);
            result.TabIndex = 13;
            // 
            // readBtn
            // 
            readBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readBtn.Location = new Point(497, 158);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(99, 40);
            readBtn.TabIndex = 14;
            readBtn.Text = "Đọc";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += read_clicked;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(497, 235);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(99, 40);
            deleteBtn.TabIndex = 15;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += clear_clicked;
            // 
            // Task3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_dank_meme4;
            ClientSize = new Size(663, 418);
            Controls.Add(deleteBtn);
            Controls.Add(readBtn);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đọc số";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exit;
        private Label label1;
        private TextBox input;
        private Label label2;
        private TextBox result;
        private Button readBtn;
        private Button deleteBtn;
    }
}