namespace Lab1_22521691
{
    partial class Task4
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
            deleteBtn = new Button();
            readBtn = new Button();
            result = new TextBox();
            label2 = new Label();
            input = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(12, 12);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(90, 41);
            exitBtn.TabIndex = 10;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exit_clicked;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.Location = new Point(514, 160);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(99, 40);
            deleteBtn.TabIndex = 21;
            deleteBtn.Text = "Xóa";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += clear_clicked;
            // 
            // readBtn
            // 
            readBtn.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readBtn.Location = new Point(514, 73);
            readBtn.Name = "readBtn";
            readBtn.Size = new Size(99, 40);
            readBtn.TabIndex = 20;
            readBtn.Text = "Đọc";
            readBtn.UseVisualStyleBackColor = true;
            readBtn.Click += read_clicked;
            // 
            // result
            // 
            result.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(42, 275);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(571, 36);
            result.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 232);
            label2.Name = "label2";
            label2.Size = new Size(92, 29);
            label2.TabIndex = 18;
            label2.Text = "Kết quả";
            // 
            // input
            // 
            input.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            input.Location = new Point(42, 160);
            input.Name = "input";
            input.Size = new Size(220, 36);
            input.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 109);
            label1.Name = "label1";
            label1.Size = new Size(220, 29);
            label1.TabIndex = 16;
            label1.Text = "Nhập vào số nguyên";
            // 
            // Task4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 422);
            Controls.Add(deleteBtn);
            Controls.Add(readBtn);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đọc số nâng cao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Button deleteBtn;
        private Button readBtn;
        private TextBox result;
        private Label label2;
        private TextBox input;
        private Label label1;
    }
}