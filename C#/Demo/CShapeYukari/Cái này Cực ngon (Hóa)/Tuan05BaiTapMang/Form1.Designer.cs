namespace Tuan05BaiTapMang
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
            this.rtbMangGoc = new System.Windows.Forms.RichTextBox();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTongMang = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnDemChan = new System.Windows.Forms.Button();
            this.btnTongChan = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnDemLe = new System.Windows.Forms.Button();
            this.btnTongLe = new System.Windows.Forms.Button();
            this.btnSoNgTo = new System.Windows.Forms.Button();
            this.btnDemNgTo = new System.Windows.Forms.Button();
            this.btnDaoNguoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mảng gốc: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả:";
            // 
            // rtbMangGoc
            // 
            this.rtbMangGoc.Location = new System.Drawing.Point(130, 12);
            this.rtbMangGoc.Name = "rtbMangGoc";
            this.rtbMangGoc.Size = new System.Drawing.Size(262, 60);
            this.rtbMangGoc.TabIndex = 3;
            this.rtbMangGoc.Text = "";
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(130, 93);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(262, 60);
            this.rtbKetQua.TabIndex = 4;
            this.rtbKetQua.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(438, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(438, 93);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(47, 189);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(132, 28);
            this.btnTaoMang.TabIndex = 7;
            this.btnTaoMang.Text = "Mảng mới";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Enabled = false;
            this.btnTimKiem.Location = new System.Drawing.Point(226, 189);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 28);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(407, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 28);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTongMang
            // 
            this.btnTongMang.Enabled = false;
            this.btnTongMang.Location = new System.Drawing.Point(47, 223);
            this.btnTongMang.Name = "btnTongMang";
            this.btnTongMang.Size = new System.Drawing.Size(285, 33);
            this.btnTongMang.TabIndex = 10;
            this.btnTongMang.Text = "Tổng mảng";
            this.btnTongMang.UseVisualStyleBackColor = true;
            this.btnTongMang.Click += new System.EventHandler(this.btnTongMang_Click);
            // 
            // btnMax
            // 
            this.btnMax.Enabled = false;
            this.btnMax.Location = new System.Drawing.Point(407, 262);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(132, 28);
            this.btnMax.TabIndex = 13;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnDemChan
            // 
            this.btnDemChan.Enabled = false;
            this.btnDemChan.Location = new System.Drawing.Point(226, 262);
            this.btnDemChan.Name = "btnDemChan";
            this.btnDemChan.Size = new System.Drawing.Size(132, 28);
            this.btnDemChan.TabIndex = 12;
            this.btnDemChan.Text = "Đếm số chẵn";
            this.btnDemChan.UseVisualStyleBackColor = true;
            this.btnDemChan.Click += new System.EventHandler(this.btnDemChan_Click);
            // 
            // btnTongChan
            // 
            this.btnTongChan.Enabled = false;
            this.btnTongChan.Location = new System.Drawing.Point(47, 262);
            this.btnTongChan.Name = "btnTongChan";
            this.btnTongChan.Size = new System.Drawing.Size(132, 28);
            this.btnTongChan.TabIndex = 11;
            this.btnTongChan.Text = "Tổng chẵn";
            this.btnTongChan.UseVisualStyleBackColor = true;
            this.btnTongChan.Click += new System.EventHandler(this.btnTongChan_Click);
            // 
            // btnMin
            // 
            this.btnMin.Enabled = false;
            this.btnMin.Location = new System.Drawing.Point(407, 296);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(132, 28);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDemLe
            // 
            this.btnDemLe.Enabled = false;
            this.btnDemLe.Location = new System.Drawing.Point(226, 296);
            this.btnDemLe.Name = "btnDemLe";
            this.btnDemLe.Size = new System.Drawing.Size(132, 28);
            this.btnDemLe.TabIndex = 15;
            this.btnDemLe.Text = "Đếm số lẻ";
            this.btnDemLe.UseVisualStyleBackColor = true;
            this.btnDemLe.Click += new System.EventHandler(this.btnDemLe_Click);
            // 
            // btnTongLe
            // 
            this.btnTongLe.Enabled = false;
            this.btnTongLe.Location = new System.Drawing.Point(47, 296);
            this.btnTongLe.Name = "btnTongLe";
            this.btnTongLe.Size = new System.Drawing.Size(132, 28);
            this.btnTongLe.TabIndex = 14;
            this.btnTongLe.Text = "Tổng lẻ";
            this.btnTongLe.UseVisualStyleBackColor = true;
            this.btnTongLe.Click += new System.EventHandler(this.btnTongLe_Click);
            // 
            // btnSoNgTo
            // 
            this.btnSoNgTo.Enabled = false;
            this.btnSoNgTo.Location = new System.Drawing.Point(47, 330);
            this.btnSoNgTo.Name = "btnSoNgTo";
            this.btnSoNgTo.Size = new System.Drawing.Size(492, 28);
            this.btnSoNgTo.TabIndex = 17;
            this.btnSoNgTo.Text = "Các số nguyên tố";
            this.btnSoNgTo.UseVisualStyleBackColor = true;
            this.btnSoNgTo.Click += new System.EventHandler(this.btnSoNgTo_Click);
            // 
            // btnDemNgTo
            // 
            this.btnDemNgTo.Enabled = false;
            this.btnDemNgTo.Location = new System.Drawing.Point(47, 364);
            this.btnDemNgTo.Name = "btnDemNgTo";
            this.btnDemNgTo.Size = new System.Drawing.Size(492, 28);
            this.btnDemNgTo.TabIndex = 18;
            this.btnDemNgTo.Text = "Đếm các số nguyên tố";
            this.btnDemNgTo.UseVisualStyleBackColor = true;
            this.btnDemNgTo.Click += new System.EventHandler(this.btnDemNgTo_Click);
            // 
            // btnDaoNguoc
            // 
            this.btnDaoNguoc.Enabled = false;
            this.btnDaoNguoc.Location = new System.Drawing.Point(47, 398);
            this.btnDaoNguoc.Name = "btnDaoNguoc";
            this.btnDaoNguoc.Size = new System.Drawing.Size(492, 28);
            this.btnDaoNguoc.TabIndex = 19;
            this.btnDaoNguoc.Text = "Đảo ngược dãy số";
            this.btnDaoNguoc.UseVisualStyleBackColor = true;
            this.btnDaoNguoc.Click += new System.EventHandler(this.btnDaoNguoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 433);
            this.Controls.Add(this.btnDaoNguoc);
            this.Controls.Add(this.btnDemNgTo);
            this.Controls.Add(this.btnSoNgTo);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnDemLe);
            this.Controls.Add(this.btnTongLe);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnDemChan);
            this.Controls.Add(this.btnTongChan);
            this.Controls.Add(this.btnTongMang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.rtbMangGoc);
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
        private System.Windows.Forms.RichTextBox rtbMangGoc;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTongMang;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnDemChan;
        private System.Windows.Forms.Button btnTongChan;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnDemLe;
        private System.Windows.Forms.Button btnTongLe;
        private System.Windows.Forms.Button btnSoNgTo;
        private System.Windows.Forms.Button btnDemNgTo;
        private System.Windows.Forms.Button btnDaoNguoc;
    }
}

