namespace Lab2_22521691
{
    partial class Task5
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
            this.movieCB = new System.Windows.Forms.ComboBox();
            this.roomCB = new System.Windows.Forms.ComboBox();
            this.findRoomBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.inforLB = new System.Windows.Forms.Label();
            this.buyBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.ticketBuy = new System.Windows.Forms.TextBox();
            this.insertName = new System.Windows.Forms.TextBox();
            this.filmDataBtn = new System.Windows.Forms.Button();
            this.movieDataLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieCB
            // 
            this.movieCB.Font = new System.Drawing.Font("UTM Avo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieCB.FormattingEnabled = true;
            this.movieCB.Location = new System.Drawing.Point(14, 55);
            this.movieCB.Name = "movieCB";
            this.movieCB.Size = new System.Drawing.Size(339, 43);
            this.movieCB.TabIndex = 0;
            this.movieCB.SelectedIndexChanged += new System.EventHandler(this.Choose_Film);
            // 
            // roomCB
            // 
            this.roomCB.Font = new System.Drawing.Font("UTM Avo", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomCB.FormattingEnabled = true;
            this.roomCB.Location = new System.Drawing.Point(14, 147);
            this.roomCB.Name = "roomCB";
            this.roomCB.Size = new System.Drawing.Size(339, 43);
            this.roomCB.TabIndex = 1;
            // 
            // findRoomBtn
            // 
            this.findRoomBtn.BackColor = System.Drawing.Color.Transparent;
            this.findRoomBtn.FlatAppearance.BorderSize = 0;
            this.findRoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findRoomBtn.Location = new System.Drawing.Point(184, 206);
            this.findRoomBtn.Name = "findRoomBtn";
            this.findRoomBtn.Size = new System.Drawing.Size(169, 39);
            this.findRoomBtn.TabIndex = 2;
            this.findRoomBtn.UseVisualStyleBackColor = false;
            this.findRoomBtn.Click += new System.EventHandler(this.findRoomBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(12, 206);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(169, 39);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // inforLB
            // 
            this.inforLB.Font = new System.Drawing.Font("UTM Avo", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforLB.Location = new System.Drawing.Point(37, 279);
            this.inforLB.Name = "inforLB";
            this.inforLB.Size = new System.Drawing.Size(297, 269);
            this.inforLB.TabIndex = 4;
            // 
            // buyBtn
            // 
            this.buyBtn.BackColor = System.Drawing.Color.Transparent;
            this.buyBtn.FlatAppearance.BorderSize = 0;
            this.buyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBtn.Location = new System.Drawing.Point(574, 201);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(194, 45);
            this.buyBtn.TabIndex = 5;
            this.buyBtn.UseVisualStyleBackColor = false;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.Transparent;
            this.delBtn.FlatAppearance.BorderSize = 0;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Location = new System.Drawing.Point(378, 200);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(190, 45);
            this.delBtn.TabIndex = 6;
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalPrice.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(562, 142);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Size = new System.Drawing.Size(156, 21);
            this.totalPrice.TabIndex = 9;
            this.totalPrice.Text = "0";
            this.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ticketBuy
            // 
            this.ticketBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ticketBuy.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketBuy.Location = new System.Drawing.Point(562, 84);
            this.ticketBuy.Name = "ticketBuy";
            this.ticketBuy.ReadOnly = true;
            this.ticketBuy.Size = new System.Drawing.Size(156, 21);
            this.ticketBuy.TabIndex = 10;
            this.ticketBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // insertName
            // 
            this.insertName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.insertName.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertName.Location = new System.Drawing.Point(562, 24);
            this.insertName.Name = "insertName";
            this.insertName.Size = new System.Drawing.Size(156, 21);
            this.insertName.TabIndex = 11;
            this.insertName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // filmDataBtn
            // 
            this.filmDataBtn.BackColor = System.Drawing.Color.Transparent;
            this.filmDataBtn.FlatAppearance.BorderSize = 0;
            this.filmDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmDataBtn.Location = new System.Drawing.Point(923, 193);
            this.filmDataBtn.Name = "filmDataBtn";
            this.filmDataBtn.Size = new System.Drawing.Size(115, 34);
            this.filmDataBtn.TabIndex = 12;
            this.filmDataBtn.UseVisualStyleBackColor = false;
            this.filmDataBtn.Click += new System.EventHandler(this.filmDataBtn_Click);
            // 
            // movieDataLB
            // 
            this.movieDataLB.BackColor = System.Drawing.Color.Transparent;
            this.movieDataLB.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieDataLB.ForeColor = System.Drawing.SystemColors.Control;
            this.movieDataLB.Location = new System.Drawing.Point(829, 48);
            this.movieDataLB.Name = "movieDataLB";
            this.movieDataLB.Size = new System.Drawing.Size(311, 137);
            this.movieDataLB.TabIndex = 13;
            this.movieDataLB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2_22521691.Properties.Resources.Task51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 608);
            this.Controls.Add(this.movieDataLB);
            this.Controls.Add(this.filmDataBtn);
            this.Controls.Add(this.insertName);
            this.Controls.Add(this.ticketBuy);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.inforLB);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.findRoomBtn);
            this.Controls.Add(this.roomCB);
            this.Controls.Add(this.movieCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng vé (phiên bản số 2)";
            this.Load += new System.EventHandler(this.Task5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox movieCB;
        private System.Windows.Forms.ComboBox roomCB;
        private System.Windows.Forms.Button findRoomBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label inforLB;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.TextBox ticketBuy;
        private System.Windows.Forms.TextBox insertName;
        private System.Windows.Forms.Button filmDataBtn;
        private System.Windows.Forms.Label movieDataLB;
    }
}