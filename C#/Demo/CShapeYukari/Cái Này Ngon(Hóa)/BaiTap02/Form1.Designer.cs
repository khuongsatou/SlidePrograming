namespace BaiTap02
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGiaTri = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKTNgTo = new System.Windows.Forms.Button();
            this.btnSLUocChan = new System.Windows.Forms.Button();
            this.btnTongUoc = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGiaTri);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập dữ liệu";
            // 
            // cboGiaTri
            // 
            this.cboGiaTri.FormattingEnabled = true;
            this.cboGiaTri.Location = new System.Drawing.Point(6, 73);
            this.cboGiaTri.Name = "cboGiaTri";
            this.cboGiaTri.Size = new System.Drawing.Size(155, 21);
            this.cboGiaTri.TabIndex = 2;
            this.cboGiaTri.SelectedIndexChanged += new System.EventHandler(this.cboGiaTri_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(119, 21);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(6, 23);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(96, 20);
            this.txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.btnKTNgTo);
            this.groupBox2.Controls.Add(this.btnSLUocChan);
            this.groupBox2.Controls.Add(this.btnTongUoc);
            this.groupBox2.Location = new System.Drawing.Point(259, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết";
            // 
            // btnKTNgTo
            // 
            this.btnKTNgTo.Location = new System.Drawing.Point(15, 219);
            this.btnKTNgTo.Name = "btnKTNgTo";
            this.btnKTNgTo.Size = new System.Drawing.Size(264, 26);
            this.btnKTNgTo.TabIndex = 3;
            this.btnKTNgTo.Text = "Kiểm tra số nguyên tố";
            this.btnKTNgTo.UseVisualStyleBackColor = true;
            // 
            // btnSLUocChan
            // 
            this.btnSLUocChan.Location = new System.Drawing.Point(15, 187);
            this.btnSLUocChan.Name = "btnSLUocChan";
            this.btnSLUocChan.Size = new System.Drawing.Size(264, 26);
            this.btnSLUocChan.TabIndex = 2;
            this.btnSLUocChan.Text = "Số lượng ước số chẵn";
            this.btnSLUocChan.UseVisualStyleBackColor = true;
            this.btnSLUocChan.Click += new System.EventHandler(this.btnSLUocChan_Click);
            // 
            // btnTongUoc
            // 
            this.btnTongUoc.Location = new System.Drawing.Point(15, 155);
            this.btnTongUoc.Name = "btnTongUoc";
            this.btnTongUoc.Size = new System.Drawing.Size(264, 26);
            this.btnTongUoc.TabIndex = 1;
            this.btnTongUoc.Text = "Tổng các ước số";
            this.btnTongUoc.UseVisualStyleBackColor = true;
            this.btnTongUoc.Click += new System.EventHandler(this.btnTongUoc_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 121);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 275);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGiaTri;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKTNgTo;
        private System.Windows.Forms.Button btnSLUocChan;
        private System.Windows.Forms.Button btnTongUoc;
        private System.Windows.Forms.ListBox listBox1;
    }
}

