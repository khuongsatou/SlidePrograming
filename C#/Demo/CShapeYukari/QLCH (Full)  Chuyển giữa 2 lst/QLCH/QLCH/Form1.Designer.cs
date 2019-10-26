namespace QLCH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNhom1 = new System.Windows.Forms.ListBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.cbNhom = new System.Windows.Forms.ComboBox();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstNhom2 = new System.Windows.Forms.ListBox();
            this.btnChuyenNhom1 = new System.Windows.Forms.Button();
            this.btnChuyenHet1 = new System.Windows.Forms.Button();
            this.btnChuyenNhom2 = new System.Windows.Forms.Button();
            this.btnChuyenHet2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblTong1 = new System.Windows.Forms.Label();
            this.lblTong2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuong Trinh Quan Ly Ca Hoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap Ten SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chon Nhom";
            // 
            // lstNhom1
            // 
            this.lstNhom1.FormattingEnabled = true;
            this.lstNhom1.Location = new System.Drawing.Point(40, 175);
            this.lstNhom1.Name = "lstNhom1";
            this.lstNhom1.Size = new System.Drawing.Size(183, 95);
            this.lstNhom1.TabIndex = 3;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(122, 56);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(121, 20);
            this.txtTenSV.TabIndex = 4;
            // 
            // cbNhom
            // 
            this.cbNhom.FormattingEnabled = true;
            this.cbNhom.Items.AddRange(new object[] {
            "Nhom 1",
            "Nhom 2"});
            this.cbNhom.Location = new System.Drawing.Point(122, 98);
            this.cbNhom.Name = "cbNhom";
            this.cbNhom.Size = new System.Drawing.Size(121, 21);
            this.cbNhom.TabIndex = 5;
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(366, 56);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhap.TabIndex = 6;
            this.btnCapNhap.Text = "Cap Nhat";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.btnCapNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(366, 98);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstNhom2
            // 
            this.lstNhom2.FormattingEnabled = true;
            this.lstNhom2.Location = new System.Drawing.Point(366, 175);
            this.lstNhom2.Name = "lstNhom2";
            this.lstNhom2.Size = new System.Drawing.Size(177, 95);
            this.lstNhom2.TabIndex = 8;
            // 
            // btnChuyenNhom1
            // 
            this.btnChuyenNhom1.Location = new System.Drawing.Point(244, 175);
            this.btnChuyenNhom1.Name = "btnChuyenNhom1";
            this.btnChuyenNhom1.Size = new System.Drawing.Size(36, 23);
            this.btnChuyenNhom1.TabIndex = 9;
            this.btnChuyenNhom1.Text = ">";
            this.btnChuyenNhom1.UseVisualStyleBackColor = true;
            this.btnChuyenNhom1.Click += new System.EventHandler(this.btnChuyenNhom1_Click);
            // 
            // btnChuyenHet1
            // 
            this.btnChuyenHet1.Location = new System.Drawing.Point(244, 204);
            this.btnChuyenHet1.Name = "btnChuyenHet1";
            this.btnChuyenHet1.Size = new System.Drawing.Size(36, 23);
            this.btnChuyenHet1.TabIndex = 10;
            this.btnChuyenHet1.Text = ">>";
            this.btnChuyenHet1.UseVisualStyleBackColor = true;
            this.btnChuyenHet1.Click += new System.EventHandler(this.btnChuyenHet1_Click);
            // 
            // btnChuyenNhom2
            // 
            this.btnChuyenNhom2.Location = new System.Drawing.Point(306, 175);
            this.btnChuyenNhom2.Name = "btnChuyenNhom2";
            this.btnChuyenNhom2.Size = new System.Drawing.Size(35, 23);
            this.btnChuyenNhom2.TabIndex = 10;
            this.btnChuyenNhom2.Text = "<";
            this.btnChuyenNhom2.UseVisualStyleBackColor = true;
            this.btnChuyenNhom2.Click += new System.EventHandler(this.btnChuyenNhom2_Click);
            // 
            // btnChuyenHet2
            // 
            this.btnChuyenHet2.Location = new System.Drawing.Point(306, 204);
            this.btnChuyenHet2.Name = "btnChuyenHet2";
            this.btnChuyenHet2.Size = new System.Drawing.Size(35, 23);
            this.btnChuyenHet2.TabIndex = 11;
            this.btnChuyenHet2.Text = "<<";
            this.btnChuyenHet2.UseVisualStyleBackColor = true;
            this.btnChuyenHet2.Click += new System.EventHandler(this.btnChuyenHet2_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(244, 247);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblTong1
            // 
            this.lblTong1.AutoSize = true;
            this.lblTong1.Location = new System.Drawing.Point(37, 316);
            this.lblTong1.Name = "lblTong1";
            this.lblTong1.Size = new System.Drawing.Size(57, 13);
            this.lblTong1.TabIndex = 13;
            this.lblTong1.Text = "Tong So:0";
            // 
            // lblTong2
            // 
            this.lblTong2.AutoSize = true;
            this.lblTong2.Location = new System.Drawing.Point(366, 315);
            this.lblTong2.Name = "lblTong2";
            this.lblTong2.Size = new System.Drawing.Size(57, 13);
            this.lblTong2.TabIndex = 14;
            this.lblTong2.Text = "Tong So:0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 426);
            this.Controls.Add(this.lblTong2);
            this.Controls.Add(this.lblTong1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChuyenHet2);
            this.Controls.Add(this.btnChuyenNhom2);
            this.Controls.Add(this.btnChuyenHet1);
            this.Controls.Add(this.btnChuyenNhom1);
            this.Controls.Add(this.lstNhom2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.cbNhom);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.lstNhom1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNhom1;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.ComboBox cbNhom;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstNhom2;
        private System.Windows.Forms.Button btnChuyenNhom1;
        private System.Windows.Forms.Button btnChuyenHet1;
        private System.Windows.Forms.Button btnChuyenNhom2;
        private System.Windows.Forms.Button btnChuyenHet2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblTong1;
        private System.Windows.Forms.Label lblTong2;
    }
}

