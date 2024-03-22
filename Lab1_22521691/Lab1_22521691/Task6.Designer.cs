namespace Lab1_22521691
{
    partial class Task6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task6));
            exitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            firstNum = new TextBox();
            secondNum = new TextBox();
            calBtn = new Button();
            delBtn = new Button();
            resultLB = new Label();
            inforCB = new ComboBox();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(178, 278);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(88, 41);
            exitBtn.TabIndex = 9;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exit_clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 44);
            label1.Name = "label1";
            label1.Size = new Size(89, 26);
            label1.TabIndex = 10;
            label1.Text = "Nhập A:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 119);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 11;
            label2.Text = "Nhập B:";
            // 
            // firstNum
            // 
            firstNum.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNum.Location = new Point(123, 38);
            firstNum.Name = "firstNum";
            firstNum.Size = new Size(143, 36);
            firstNum.TabIndex = 12;
            // 
            // secondNum
            // 
            secondNum.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondNum.Location = new Point(122, 113);
            secondNum.Name = "secondNum";
            secondNum.Size = new Size(144, 36);
            secondNum.TabIndex = 13;
            // 
            // calBtn
            // 
            calBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            calBtn.Location = new Point(28, 231);
            calBtn.Name = "calBtn";
            calBtn.Size = new Size(144, 41);
            calBtn.TabIndex = 14;
            calBtn.Text = "Tính các giá trị";
            calBtn.UseVisualStyleBackColor = true;
            calBtn.Click += cal_clicked;
            // 
            // delBtn
            // 
            delBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(178, 231);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(88, 41);
            delBtn.TabIndex = 15;
            delBtn.Text = "Xóa";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += clear_clicked;
            // 
            // resultLB
            // 
            resultLB.BackColor = SystemColors.ButtonHighlight;
            resultLB.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLB.ForeColor = SystemColors.ButtonHighlight;
            resultLB.Location = new Point(329, 10);
            resultLB.Name = "resultLB";
            resultLB.Size = new Size(429, 414);
            resultLB.TabIndex = 16;
            // 
            // inforCB
            // 
            inforCB.DropDownStyle = ComboBoxStyle.DropDownList;
            inforCB.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inforCB.FormattingEnabled = true;
            inforCB.Items.AddRange(new object[] { "Bảng cửu chương", "Tính toán giá trị" });
            inforCB.Location = new Point(28, 168);
            inforCB.Name = "inforCB";
            inforCB.Size = new Size(238, 37);
            inforCB.TabIndex = 17;
            // 
            // Task6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(inforCB);
            Controls.Add(resultLB);
            Controls.Add(delBtn);
            Controls.Add(calBtn);
            Controls.Add(secondNum);
            Controls.Add(firstNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Task6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task6";
            Load += load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label label1;
        private Label label2;
        private TextBox firstNum;
        private TextBox secondNum;
        private Button calBtn;
        private Button delBtn;
        private Label resultLB;
        private ComboBox inforCB;
    }
}