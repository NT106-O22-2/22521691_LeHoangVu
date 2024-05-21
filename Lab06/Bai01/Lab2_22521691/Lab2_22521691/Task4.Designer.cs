namespace Lab2_22521691
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
            this.writeFileBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pageNum = new System.Windows.Forms.Label();
            this.nameWrite = new System.Windows.Forms.TextBox();
            this.idWrite = new System.Windows.Forms.TextBox();
            this.phoneWrite = new System.Windows.Forms.TextBox();
            this.course1Write = new System.Windows.Forms.TextBox();
            this.course2Write = new System.Windows.Forms.TextBox();
            this.course3Write = new System.Windows.Forms.TextBox();
            this.course3Read = new System.Windows.Forms.TextBox();
            this.course2Read = new System.Windows.Forms.TextBox();
            this.course1Read = new System.Windows.Forms.TextBox();
            this.phoneRead = new System.Windows.Forms.TextBox();
            this.idRead = new System.Windows.Forms.TextBox();
            this.nameRead = new System.Windows.Forms.TextBox();
            this.avgRead = new System.Windows.Forms.TextBox();
            this.dataLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeFileBtn
            // 
            this.writeFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.writeFileBtn.FlatAppearance.BorderSize = 0;
            this.writeFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.writeFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.writeFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeFileBtn.Location = new System.Drawing.Point(67, 22);
            this.writeFileBtn.Name = "writeFileBtn";
            this.writeFileBtn.Size = new System.Drawing.Size(240, 70);
            this.writeFileBtn.TabIndex = 1;
            this.writeFileBtn.UseVisualStyleBackColor = false;
            this.writeFileBtn.Click += new System.EventHandler(this.writeFileBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Location = new System.Drawing.Point(25, 594);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(165, 45);
            this.addBtn.TabIndex = 2;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(196, 594);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(174, 45);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatAppearance.BorderSize = 0;
            this.readFileBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.readFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readFileBtn.Location = new System.Drawing.Point(818, 22);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(240, 70);
            this.readFileBtn.TabIndex = 4;
            this.readFileBtn.UseVisualStyleBackColor = false;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backBtn.Location = new System.Drawing.Point(798, 567);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(92, 45);
            this.backBtn.TabIndex = 6;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.nextBtn.Location = new System.Drawing.Point(975, 567);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(92, 45);
            this.nextBtn.TabIndex = 7;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pageNum
            // 
            this.pageNum.AutoSize = true;
            this.pageNum.BackColor = System.Drawing.Color.Transparent;
            this.pageNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pageNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNum.ForeColor = System.Drawing.Color.Yellow;
            this.pageNum.Location = new System.Drawing.Point(915, 575);
            this.pageNum.Name = "pageNum";
            this.pageNum.Size = new System.Drawing.Size(31, 32);
            this.pageNum.TabIndex = 8;
            this.pageNum.Text = "1";
            this.pageNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameWrite
            // 
            this.nameWrite.BackColor = System.Drawing.Color.White;
            this.nameWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameWrite.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameWrite.Location = new System.Drawing.Point(166, 144);
            this.nameWrite.Name = "nameWrite";
            this.nameWrite.Size = new System.Drawing.Size(151, 28);
            this.nameWrite.TabIndex = 9;
            this.nameWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idWrite
            // 
            this.idWrite.BackColor = System.Drawing.Color.White;
            this.idWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idWrite.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idWrite.Location = new System.Drawing.Point(166, 198);
            this.idWrite.Name = "idWrite";
            this.idWrite.Size = new System.Drawing.Size(151, 28);
            this.idWrite.TabIndex = 10;
            this.idWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoneWrite
            // 
            this.phoneWrite.BackColor = System.Drawing.Color.White;
            this.phoneWrite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneWrite.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneWrite.Location = new System.Drawing.Point(166, 256);
            this.phoneWrite.Name = "phoneWrite";
            this.phoneWrite.Size = new System.Drawing.Size(151, 28);
            this.phoneWrite.TabIndex = 11;
            this.phoneWrite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course1Write
            // 
            this.course1Write.BackColor = System.Drawing.Color.White;
            this.course1Write.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course1Write.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course1Write.Location = new System.Drawing.Point(166, 315);
            this.course1Write.Name = "course1Write";
            this.course1Write.Size = new System.Drawing.Size(151, 28);
            this.course1Write.TabIndex = 12;
            this.course1Write.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course2Write
            // 
            this.course2Write.BackColor = System.Drawing.Color.White;
            this.course2Write.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course2Write.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course2Write.Location = new System.Drawing.Point(166, 374);
            this.course2Write.Name = "course2Write";
            this.course2Write.Size = new System.Drawing.Size(151, 28);
            this.course2Write.TabIndex = 13;
            this.course2Write.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course3Write
            // 
            this.course3Write.BackColor = System.Drawing.Color.White;
            this.course3Write.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course3Write.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course3Write.Location = new System.Drawing.Point(166, 434);
            this.course3Write.Name = "course3Write";
            this.course3Write.Size = new System.Drawing.Size(151, 28);
            this.course3Write.TabIndex = 14;
            this.course3Write.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course3Read
            // 
            this.course3Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.course3Read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course3Read.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course3Read.Location = new System.Drawing.Point(916, 435);
            this.course3Read.Name = "course3Read";
            this.course3Read.ReadOnly = true;
            this.course3Read.Size = new System.Drawing.Size(151, 28);
            this.course3Read.TabIndex = 20;
            this.course3Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course2Read
            // 
            this.course2Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.course2Read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course2Read.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course2Read.Location = new System.Drawing.Point(916, 375);
            this.course2Read.Name = "course2Read";
            this.course2Read.ReadOnly = true;
            this.course2Read.Size = new System.Drawing.Size(151, 28);
            this.course2Read.TabIndex = 19;
            this.course2Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // course1Read
            // 
            this.course1Read.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.course1Read.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.course1Read.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course1Read.Location = new System.Drawing.Point(916, 316);
            this.course1Read.Name = "course1Read";
            this.course1Read.ReadOnly = true;
            this.course1Read.Size = new System.Drawing.Size(151, 28);
            this.course1Read.TabIndex = 18;
            this.course1Read.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phoneRead
            // 
            this.phoneRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.phoneRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneRead.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneRead.Location = new System.Drawing.Point(916, 257);
            this.phoneRead.Name = "phoneRead";
            this.phoneRead.ReadOnly = true;
            this.phoneRead.Size = new System.Drawing.Size(151, 28);
            this.phoneRead.TabIndex = 17;
            this.phoneRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idRead
            // 
            this.idRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.idRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idRead.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRead.Location = new System.Drawing.Point(916, 199);
            this.idRead.Name = "idRead";
            this.idRead.ReadOnly = true;
            this.idRead.Size = new System.Drawing.Size(151, 28);
            this.idRead.TabIndex = 16;
            this.idRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameRead
            // 
            this.nameRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nameRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameRead.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRead.Location = new System.Drawing.Point(916, 145);
            this.nameRead.Name = "nameRead";
            this.nameRead.ReadOnly = true;
            this.nameRead.Size = new System.Drawing.Size(151, 28);
            this.nameRead.TabIndex = 15;
            this.nameRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // avgRead
            // 
            this.avgRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.avgRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgRead.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgRead.Location = new System.Drawing.Point(916, 494);
            this.avgRead.Name = "avgRead";
            this.avgRead.ReadOnly = true;
            this.avgRead.Size = new System.Drawing.Size(151, 28);
            this.avgRead.TabIndex = 21;
            this.avgRead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataLB
            // 
            this.dataLB.Font = new System.Drawing.Font("UTM Avo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLB.Location = new System.Drawing.Point(427, 38);
            this.dataLB.Name = "dataLB";
            this.dataLB.Size = new System.Drawing.Size(290, 611);
            this.dataLB.TabIndex = 22;
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2_22521691.Properties.Resources.Task41;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 689);
            this.Controls.Add(this.dataLB);
            this.Controls.Add(this.avgRead);
            this.Controls.Add(this.course3Read);
            this.Controls.Add(this.course2Read);
            this.Controls.Add(this.course1Read);
            this.Controls.Add(this.phoneRead);
            this.Controls.Add(this.idRead);
            this.Controls.Add(this.nameRead);
            this.Controls.Add(this.course3Write);
            this.Controls.Add(this.course2Write);
            this.Controls.Add(this.course1Write);
            this.Controls.Add(this.phoneWrite);
            this.Controls.Add(this.idWrite);
            this.Controls.Add(this.nameWrite);
            this.Controls.Add(this.pageNum);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.writeFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Task4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đọc và Ghi file có cấu trúc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeFileBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label pageNum;
        private System.Windows.Forms.TextBox nameWrite;
        private System.Windows.Forms.TextBox idWrite;
        private System.Windows.Forms.TextBox phoneWrite;
        private System.Windows.Forms.TextBox course1Write;
        private System.Windows.Forms.TextBox course2Write;
        private System.Windows.Forms.TextBox course3Write;
        private System.Windows.Forms.TextBox course3Read;
        private System.Windows.Forms.TextBox course2Read;
        private System.Windows.Forms.TextBox course1Read;
        private System.Windows.Forms.TextBox phoneRead;
        private System.Windows.Forms.TextBox idRead;
        private System.Windows.Forms.TextBox nameRead;
        private System.Windows.Forms.TextBox avgRead;
        private System.Windows.Forms.Label dataLB;
    }
}