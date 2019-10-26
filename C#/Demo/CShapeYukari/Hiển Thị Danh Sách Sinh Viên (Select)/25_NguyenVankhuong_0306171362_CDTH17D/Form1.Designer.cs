namespace _25_NguyenVankhuong_0306171362_CDTH17D
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
            this.btnTatCaSP = new System.Windows.Forms.Button();
            this.btnSanPhamGiaBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sản Phẩm";
            // 
            // btnTatCaSP
            // 
            this.btnTatCaSP.Location = new System.Drawing.Point(83, 64);
            this.btnTatCaSP.Name = "btnTatCaSP";
            this.btnTatCaSP.Size = new System.Drawing.Size(275, 51);
            this.btnTatCaSP.TabIndex = 1;
            this.btnTatCaSP.Text = "DS Tất Cả Sản Phẩm";
            this.btnTatCaSP.UseVisualStyleBackColor = true;
            this.btnTatCaSP.Click += new System.EventHandler(this.btnTatCaSP_Click);
            // 
            // btnSanPhamGiaBan
            // 
            this.btnSanPhamGiaBan.Location = new System.Drawing.Point(83, 137);
            this.btnSanPhamGiaBan.Name = "btnSanPhamGiaBan";
            this.btnSanPhamGiaBan.Size = new System.Drawing.Size(275, 51);
            this.btnSanPhamGiaBan.TabIndex = 2;
            this.btnSanPhamGiaBan.Text = "DS Sản Phẩm Theo giá Bán";
            this.btnSanPhamGiaBan.UseVisualStyleBackColor = true;
            this.btnSanPhamGiaBan.Click += new System.EventHandler(this.btnSanPhamGiaBan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 229);
            this.Controls.Add(this.btnSanPhamGiaBan);
            this.Controls.Add(this.btnTatCaSP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTatCaSP;
        private System.Windows.Forms.Button btnSanPhamGiaBan;
    }
}

