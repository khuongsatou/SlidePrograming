namespace ChuongTringXuLiChuoi
{
    partial class Form1
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
            this.lblThu = new System.Windows.Forms.Label();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnTenNgauNhien = new System.Windows.Forms.Button();
            this.btnXoaSVTheoTen = new System.Windows.Forms.Button();
            this.btnDoiTen = new System.Windows.Forms.Button();
            this.btnXoaSVTheoHo = new System.Windows.Forms.Button();
            this.btnDoiTenHoa = new System.Windows.Forms.Button();
            this.btnDoiHo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDoiHoaDauTu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThu
            // 
            this.lblThu.AutoSize = true;
            this.lblThu.Location = new System.Drawing.Point(147, 13);
            this.lblThu.Name = "lblThu";
            this.lblThu.Size = new System.Drawing.Size(131, 13);
            this.lblThu.TabIndex = 0;
            this.lblThu.Text = "Chương Trình Xử Lý Chuỗi";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(24, 21);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(203, 329);
            this.lstDanhSach.TabIndex = 1;
            this.lstDanhSach.SelectedIndexChanged += new System.EventHandler(this.lstDanhSach_SelectedIndexChanged);
            // 
            // btnTenNgauNhien
            // 
            this.btnTenNgauNhien.Location = new System.Drawing.Point(279, 50);
            this.btnTenNgauNhien.Name = "btnTenNgauNhien";
            this.btnTenNgauNhien.Size = new System.Drawing.Size(190, 33);
            this.btnTenNgauNhien.TabIndex = 2;
            this.btnTenNgauNhien.Text = "Nhập Tên Ngẫu Nhiên";
            this.btnTenNgauNhien.UseVisualStyleBackColor = true;
            this.btnTenNgauNhien.Click += new System.EventHandler(this.btnTenNgauNhien_Click);
            // 
            // btnXoaSVTheoTen
            // 
            this.btnXoaSVTheoTen.Location = new System.Drawing.Point(279, 89);
            this.btnXoaSVTheoTen.Name = "btnXoaSVTheoTen";
            this.btnXoaSVTheoTen.Size = new System.Drawing.Size(190, 29);
            this.btnXoaSVTheoTen.TabIndex = 3;
            this.btnXoaSVTheoTen.Text = "Xóa Sv Theo Tên";
            this.btnXoaSVTheoTen.UseVisualStyleBackColor = true;
            this.btnXoaSVTheoTen.Click += new System.EventHandler(this.btnXoaSVTheoTen_Click);
            // 
            // btnDoiTen
            // 
            this.btnDoiTen.Location = new System.Drawing.Point(279, 172);
            this.btnDoiTen.Name = "btnDoiTen";
            this.btnDoiTen.Size = new System.Drawing.Size(190, 29);
            this.btnDoiTen.TabIndex = 5;
            this.btnDoiTen.Text = "Đổi Tên";
            this.btnDoiTen.UseVisualStyleBackColor = true;
            // 
            // btnXoaSVTheoHo
            // 
            this.btnXoaSVTheoHo.Location = new System.Drawing.Point(279, 133);
            this.btnXoaSVTheoHo.Name = "btnXoaSVTheoHo";
            this.btnXoaSVTheoHo.Size = new System.Drawing.Size(190, 33);
            this.btnXoaSVTheoHo.TabIndex = 4;
            this.btnXoaSVTheoHo.Text = "Xóa Sv Theo Họ";
            this.btnXoaSVTheoHo.UseVisualStyleBackColor = true;
            this.btnXoaSVTheoHo.Click += new System.EventHandler(this.btnXoaSVTheoHo_Click);
            // 
            // btnDoiTenHoa
            // 
            this.btnDoiTenHoa.Location = new System.Drawing.Point(279, 246);
            this.btnDoiTenHoa.Name = "btnDoiTenHoa";
            this.btnDoiTenHoa.Size = new System.Drawing.Size(190, 29);
            this.btnDoiTenHoa.TabIndex = 7;
            this.btnDoiTenHoa.Text = "Đổi tên hoa";
            this.btnDoiTenHoa.UseVisualStyleBackColor = true;
            // 
            // btnDoiHo
            // 
            this.btnDoiHo.Location = new System.Drawing.Point(279, 207);
            this.btnDoiHo.Name = "btnDoiHo";
            this.btnDoiHo.Size = new System.Drawing.Size(190, 33);
            this.btnDoiHo.TabIndex = 6;
            this.btnDoiHo.Text = "Đổi Họ";
            this.btnDoiHo.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(279, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 32);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDoiHoaDauTu
            // 
            this.btnDoiHoaDauTu.Location = new System.Drawing.Point(279, 281);
            this.btnDoiHoaDauTu.Name = "btnDoiHoaDauTu";
            this.btnDoiHoaDauTu.Size = new System.Drawing.Size(190, 33);
            this.btnDoiHoaDauTu.TabIndex = 8;
            this.btnDoiHoaDauTu.Text = "Đổi hoa đầu từ";
            this.btnDoiHoaDauTu.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 369);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách SV";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(387, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 32);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 520);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDoiHoaDauTu);
            this.Controls.Add(this.btnDoiTenHoa);
            this.Controls.Add(this.btnDoiHo);
            this.Controls.Add(this.btnDoiTen);
            this.Controls.Add(this.btnXoaSVTheoHo);
            this.Controls.Add(this.btnXoaSVTheoTen);
            this.Controls.Add(this.btnTenNgauNhien);
            this.Controls.Add(this.lblThu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThu;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnTenNgauNhien;
        private System.Windows.Forms.Button btnXoaSVTheoTen;
        private System.Windows.Forms.Button btnDoiTen;
        private System.Windows.Forms.Button btnXoaSVTheoHo;
        private System.Windows.Forms.Button btnDoiTenHoa;
        private System.Windows.Forms.Button btnDoiHo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDoiHoaDauTu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

