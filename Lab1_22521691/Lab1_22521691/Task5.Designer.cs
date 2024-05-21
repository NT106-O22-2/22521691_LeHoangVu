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
            label4 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backGrLb = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            name = new TextBox();
            label7 = new Label();
            ticket = new TextBox();
            label8 = new Label();
            totalPrice = new TextBox();
            find = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 130);
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
            movieCB.Size = new Size(188, 30);
            movieCB.TabIndex = 9;
            movieCB.SelectedIndexChanged += film_choose;
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
            roomCB.Size = new Size(188, 30);
            roomCB.TabIndex = 11;
            // 
            // inforLabel
            // 
            inforLabel.BackColor = Color.LightGray;
            inforLabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inforLabel.ForeColor = SystemColors.ButtonFace;
            inforLabel.Location = new Point(12, 192);
            inforLabel.Name = "inforLabel";
            inforLabel.Size = new Size(188, 249);
            inforLabel.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(806, 202);
            button1.Name = "button1";
            button1.Size = new Size(141, 61);
            button1.TabIndex = 15;
            button1.Text = "Mua";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buy_clicked;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(256, 109);
            label4.Name = "label4";
            label4.Size = new Size(63, 63);
            label4.TabIndex = 17;
            label4.Text = "A";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backGrLb
            // 
            backGrLb.Location = new Point(239, 30);
            backGrLb.Name = "backGrLb";
            backGrLb.Size = new Size(527, 411);
            backGrLb.TabIndex = 18;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(256, 192);
            label3.Name = "label3";
            label3.Size = new Size(63, 63);
            label3.TabIndex = 19;
            label3.Text = "B";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 31.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(256, 275);
            label5.Name = "label5";
            label5.Size = new Size(63, 63);
            label5.TabIndex = 20;
            label5.Text = "C";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(772, 31);
            label6.Name = "label6";
            label6.Size = new Size(116, 29);
            label6.TabIndex = 21;
            label6.Text = "Họ và tên:";
            // 
            // name
            // 
            name.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(908, 28);
            name.Name = "name";
            name.Size = new Size(238, 36);
            name.TabIndex = 22;
            name.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(772, 95);
            label7.Name = "label7";
            label7.Size = new Size(104, 29);
            label7.TabIndex = 23;
            label7.Text = "Vé chọn:";
            // 
            // ticket
            // 
            ticket.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ticket.Location = new Point(908, 95);
            ticket.Name = "ticket";
            ticket.ReadOnly = true;
            ticket.Size = new Size(238, 36);
            ticket.TabIndex = 24;
            ticket.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(772, 159);
            label8.Name = "label8";
            label8.Size = new Size(126, 29);
            label8.TabIndex = 25;
            label8.Text = "Thành tiền:";
            // 
            // totalPrice
            // 
            totalPrice.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPrice.Location = new Point(908, 156);
            totalPrice.Name = "totalPrice";
            totalPrice.ReadOnly = true;
            totalPrice.Size = new Size(238, 36);
            totalPrice.TabIndex = 26;
            totalPrice.Text = "0";
            totalPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // find
            // 
            find.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            find.Location = new Point(106, 130);
            find.Name = "find";
            find.Size = new Size(94, 41);
            find.TabIndex = 27;
            find.Text = "Tìm";
            find.UseVisualStyleBackColor = true;
            find.Click += find_room_clicked;
            // 
            // delete
            // 
            delete.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(953, 202);
            delete.Name = "delete";
            delete.Size = new Size(141, 61);
            delete.TabIndex = 28;
            delete.Text = "Xóa";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_clicked;
            // 
            // buyBtn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1158, 450);
            Controls.Add(delete);
            Controls.Add(find);
            Controls.Add(totalPrice);
            Controls.Add(label8);
            Controls.Add(ticket);
            Controls.Add(label7);
            Controls.Add(name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(inforLabel);
            Controls.Add(label2);
            Controls.Add(roomCB);
            Controls.Add(label1);
            Controls.Add(movieCB);
            Controls.Add(button2);
            Controls.Add(backGrLb);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "buyBtn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý phòng vé";
            Load += load;
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
        private Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label backGrLb;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox name;
        private Label label7;
        private TextBox ticket;
        private Label label8;
        private TextBox totalPrice;
        private Button find;
        private Button delete;
    }
}