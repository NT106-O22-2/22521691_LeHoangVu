namespace Lab1_22521691
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.Location = new Point(100, 45);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 0;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += switch_to_task1;
            // 
            // button2
            // 
            button2.Location = new Point(400, 45);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 1;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += switch_to_task2;
            // 
            // button3
            // 
            button3.Location = new Point(400, 120);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 3;
            button3.Text = "Bài 4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += switch_to_task4;
            // 
            // button4
            // 
            button4.Location = new Point(100, 120);
            button4.Name = "button4";
            button4.Size = new Size(200, 40);
            button4.TabIndex = 2;
            button4.Text = "Bài 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += switch_to_task3;
            // 
            // button5
            // 
            button5.Location = new Point(400, 195);
            button5.Name = "button5";
            button5.Size = new Size(200, 40);
            button5.TabIndex = 5;
            button5.Text = "Bài 6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += switch_to_task6;
            // 
            // button6
            // 
            button6.Location = new Point(100, 195);
            button6.Name = "button6";
            button6.Size = new Size(200, 40);
            button6.TabIndex = 4;
            button6.Text = "Bài 5";
            button6.UseVisualStyleBackColor = true;
            button6.Click += switch_to_task5;
            // 
            // button7
            // 
            button7.Location = new Point(400, 270);
            button7.Name = "button7";
            button7.Size = new Size(200, 40);
            button7.TabIndex = 7;
            button7.Text = "Bài 8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += switch_to_task8;
            // 
            // button8
            // 
            button8.Location = new Point(100, 270);
            button8.Name = "button8";
            button8.Size = new Size(200, 40);
            button8.TabIndex = 6;
            button8.Text = "Bài 7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += switch_to_task7;
            // 
            // button9
            // 
            button9.Location = new Point(250, 345);
            button9.Name = "button9";
            button9.Size = new Size(200, 40);
            button9.TabIndex = 8;
            button9.Text = "Bài 9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += switch_to_task9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 409);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab01";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
