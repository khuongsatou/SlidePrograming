namespace BaiTapCauTrucLap
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNut1 = new System.Windows.Forms.Button();
            this.btnNut2 = new System.Windows.Forms.Button();
            this.btnNut3 = new System.Windows.Forms.Button();
            this.btnNut4 = new System.Windows.Forms.Button();
            this.btnKTNgTo = new System.Windows.Forms.Button();
            this.btnInNgTo = new System.Windows.Forms.Button();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(76, 16);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 20);
            this.txtNhap.TabIndex = 1;
            // 
            // btnNut1
            // 
            this.btnNut1.Location = new System.Drawing.Point(16, 67);
            this.btnNut1.Name = "btnNut1";
            this.btnNut1.Size = new System.Drawing.Size(260, 26);
            this.btnNut1.TabIndex = 2;
            this.btnNut1.Text = "1. Tổng 1+2+...+N";
            this.btnNut1.UseVisualStyleBackColor = true;
            this.btnNut1.Click += new System.EventHandler(this.btnNut1_Click);
            // 
            // btnNut2
            // 
            this.btnNut2.Location = new System.Drawing.Point(16, 110);
            this.btnNut2.Name = "btnNut2";
            this.btnNut2.Size = new System.Drawing.Size(260, 26);
            this.btnNut2.TabIndex = 3;
            this.btnNut2.Text = "2. Tổng 1*2+2*3+...+N*(N+1)";
            this.btnNut2.UseVisualStyleBackColor = true;
            this.btnNut2.Click += new System.EventHandler(this.btnNut2_Click);
            // 
            // btnNut3
            // 
            this.btnNut3.Location = new System.Drawing.Point(16, 151);
            this.btnNut3.Name = "btnNut3";
            this.btnNut3.Size = new System.Drawing.Size(260, 26);
            this.btnNut3.TabIndex = 4;
            this.btnNut3.Text = "3. Tính( 1*2+2*3+...N*(N+1) ) / (1+2+...+N)";
            this.btnNut3.UseVisualStyleBackColor = true;
            this.btnNut3.Click += new System.EventHandler(this.btnNut3_Click);
            // 
            // btnNut4
            // 
            this.btnNut4.Location = new System.Drawing.Point(16, 192);
            this.btnNut4.Name = "btnNut4";
            this.btnNut4.Size = new System.Drawing.Size(260, 26);
            this.btnNut4.TabIndex = 5;
            this.btnNut4.Text = "4.Tính( 1*2+2*3+...N*(N+1) ) ^ 2 / (1+2+...+N)";
            this.btnNut4.UseVisualStyleBackColor = true;
            this.btnNut4.Click += new System.EventHandler(this.btnNut4_Click);
            // 
            // btnKTNgTo
            // 
            this.btnKTNgTo.Location = new System.Drawing.Point(16, 238);
            this.btnKTNgTo.Name = "btnKTNgTo";
            this.btnKTNgTo.Size = new System.Drawing.Size(260, 26);
            this.btnKTNgTo.TabIndex = 6;
            this.btnKTNgTo.Text = "5. Kiểm tra số Nguyên Tố";
            this.btnKTNgTo.UseVisualStyleBackColor = true;
            this.btnKTNgTo.Click += new System.EventHandler(this.btnKTNgTo_Click);
            // 
            // btnInNgTo
            // 
            this.btnInNgTo.Location = new System.Drawing.Point(16, 283);
            this.btnInNgTo.Name = "btnInNgTo";
            this.btnInNgTo.Size = new System.Drawing.Size(260, 26);
            this.btnInNgTo.TabIndex = 7;
            this.btnInNgTo.Text = "6. Các số Nguyên tố từ 2->N";
            this.btnInNgTo.UseVisualStyleBackColor = true;
            this.btnInNgTo.Click += new System.EventHandler(this.btnInNgTo_Click);
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Location = new System.Drawing.Point(16, 324);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(260, 26);
            this.btnFibonacci.TabIndex = 8;
            this.btnFibonacci.Text = "7.Dãy Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kết quả:";
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(16, 388);
            this.rtbKetQua.Name = "rtbKetQua";
            this.rtbKetQua.Size = new System.Drawing.Size(259, 45);
            this.rtbKetQua.TabIndex = 10;
            this.rtbKetQua.Text = "";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(200, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 431);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.btnInNgTo);
            this.Controls.Add(this.btnKTNgTo);
            this.Controls.Add(this.btnNut4);
            this.Controls.Add(this.btnNut3);
            this.Controls.Add(this.btnNut2);
            this.Controls.Add(this.btnNut1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNut1;
        private System.Windows.Forms.Button btnNut2;
        private System.Windows.Forms.Button btnNut3;
        private System.Windows.Forms.Button btnNut4;
        private System.Windows.Forms.Button btnKTNgTo;
        private System.Windows.Forms.Button btnInNgTo;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbKetQua;
        private System.Windows.Forms.Button btnThoat;
    }
}

