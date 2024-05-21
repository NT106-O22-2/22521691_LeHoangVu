namespace Bai05
{
    partial class Client
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
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnGuiDuLieu = new Button();
            txtTenMonAn = new TextBox();
            txtTenNguoiDung = new TextBox();
            btnAnh = new Button();
            txtHinhAnhName = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnRanDom = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(25, 131);
            label6.Name = "label6";
            label6.Size = new Size(84, 30);
            label6.TabIndex = 29;
            label6.Text = "Họ tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(25, 187);
            label3.Name = "label3";
            label3.Size = new Size(51, 30);
            label3.TabIndex = 20;
            label3.Text = "Ảnh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(25, 74);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 18;
            label1.Text = "Nhập món ăn:";
            // 
            // btnGuiDuLieu
            // 
            btnGuiDuLieu.Font = new Font("Microsoft Sans Serif", 11F);
            btnGuiDuLieu.Location = new Point(181, 302);
            btnGuiDuLieu.Name = "btnGuiDuLieu";
            btnGuiDuLieu.Size = new Size(151, 34);
            btnGuiDuLieu.TabIndex = 30;
            btnGuiDuLieu.Text = "Gửi dữ liệu";
            btnGuiDuLieu.UseVisualStyleBackColor = true;
            btnGuiDuLieu.Click += btnGuiDuLieu_Click;
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Font = new Font("Segoe UI", 11F);
            txtTenMonAn.Location = new Point(181, 73);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(224, 37);
            txtTenMonAn.TabIndex = 31;
            // 
            // txtTenNguoiDung
            // 
            txtTenNguoiDung.Font = new Font("Segoe UI", 11F);
            txtTenNguoiDung.Location = new Point(181, 130);
            txtTenNguoiDung.Name = "txtTenNguoiDung";
            txtTenNguoiDung.Size = new Size(224, 37);
            txtTenNguoiDung.TabIndex = 32;
            // 
            // btnAnh
            // 
            btnAnh.Font = new Font("Microsoft Sans Serif", 11F);
            btnAnh.Location = new Point(256, 187);
            btnAnh.Name = "btnAnh";
            btnAnh.Size = new Size(149, 38);
            btnAnh.TabIndex = 34;
            btnAnh.Text = "Chọn ảnh";
            btnAnh.UseVisualStyleBackColor = true;
            btnAnh.Click += btnAnh_Click;
            // 
            // txtHinhAnhName
            // 
            txtHinhAnhName.AutoSize = true;
            txtHinhAnhName.Font = new Font("Microsoft Sans Serif", 11F);
            txtHinhAnhName.Location = new Point(150, 192);
            txtHinhAnhName.Name = "txtHinhAnhName";
            txtHinhAnhName.Size = new Size(99, 26);
            txtHinhAnhName.TabIndex = 35;
            txtHinhAnhName.Text = "path Ảnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 25);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 36;
            label2.Text = "Cập nhật thêm món ăn";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(422, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 263);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // btnRanDom
            // 
            btnRanDom.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRanDom.Location = new Point(530, 375);
            btnRanDom.Name = "btnRanDom";
            btnRanDom.Size = new Size(150, 48);
            btnRanDom.TabIndex = 38;
            btnRanDom.Text = "Chọn món";
            btnRanDom.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(415, 308);
            label4.Name = "label4";
            label4.Size = new Size(373, 28);
            label4.TabIndex = 39;
            label4.Text = "Hiện tên món ăn dới tên người đóng góp";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(btnRanDom);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(txtHinhAnhName);
            Controls.Add(btnAnh);
            Controls.Add(txtTenNguoiDung);
            Controls.Add(txtTenMonAn);
            Controls.Add(btnGuiDuLieu);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Client";
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label3;
        private Label label1;
        private Button btnGuiDuLieu;
        private TextBox txtTenMonAn;
        private TextBox txtTenNguoiDung;
        private Button btnAnh;
        private Label txtHinhAnhName;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnRanDom;
        private Label label4;
    }
}