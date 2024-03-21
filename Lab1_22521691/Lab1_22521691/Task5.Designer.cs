namespace Lab1_22521691
{
    partial class buyBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buyBtn));
            button2 = new Button();
            movieCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            roomCB = new ComboBox();
            inforLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(100, 130);
            button2.Name = "button2";
            button2.Size = new Size(88, 41);
            button2.TabIndex = 8;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += exit_clicked;
            // 
            // movieCB
            // 
            movieCB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieCB.FormattingEnabled = true;
            movieCB.Items.AddRange(new object[] { "Đào, phở và piano", "Mai", "Gặp lại chị bầu", "Tarot" });
            movieCB.Location = new Point(12, 30);
            movieCB.Name = "movieCB";
            movieCB.Size = new Size(176, 30);
            movieCB.TabIndex = 9;
            movieCB.SelectedValueChanged += film_choose;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 10;
            label1.Text = "Chọn phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 12;
            label2.Text = "Phòng chiếu";
            // 
            // roomCB
            // 
            roomCB.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomCB.FormattingEnabled = true;
            roomCB.Location = new Point(12, 94);
            roomCB.Name = "roomCB";
            roomCB.Size = new Size(176, 30);
            roomCB.TabIndex = 11;
            // 
            // inforLabel
            // 
            inforLabel.BackColor = Color.LightGray;
            inforLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inforLabel.ForeColor = SystemColors.ButtonFace;
            inforLabel.Location = new Point(12, 192);
            inforLabel.Name = "inforLabel";
            inforLabel.Size = new Size(176, 249);
            inforLabel.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 130);
            button1.Name = "button1";
            button1.Size = new Size(82, 41);
            button1.TabIndex = 15;
            button1.Text = "Mua";
            button1.UseVisualStyleBackColor = true;
            // 
            // buyBtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(inforLabel);
            Controls.Add(label2);
            Controls.Add(roomCB);
            Controls.Add(label1);
            Controls.Add(movieCB);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "buyBtn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task5";
            Load += Task5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private ComboBox movieCB;
        private Label label1;
        private Label label2;
        private ComboBox roomCB;
        private Label inforLabel;
        private Button button1;
    }
}