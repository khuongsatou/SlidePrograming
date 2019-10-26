namespace tuan04_c
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
            this.rtbGoc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKQ = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSumChan = new System.Windows.Forms.Button();
            this.btnCountChan = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSumLe = new System.Windows.Forms.Button();
            this.btnCountLe = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnNT = new System.Windows.Forms.Button();
            this.btnCountNT = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbGoc
            // 
            this.rtbGoc.Location = new System.Drawing.Point(68, 12);
            this.rtbGoc.Name = "rtbGoc";
            this.rtbGoc.Size = new System.Drawing.Size(237, 55);
            this.rtbGoc.TabIndex = 0;
            this.rtbGoc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mảng Gốc";
            // 
            // rtbKQ
            // 
            this.rtbKQ.Location = new System.Drawing.Point(68, 73);
            this.rtbKQ.Name = "rtbKQ";
            this.rtbKQ.Size = new System.Drawing.Size(237, 55);
            this.rtbKQ.TabIndex = 2;
            this.rtbKQ.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết Quả";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(348, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(348, 82);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(68, 134);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Mảng mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 134);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(348, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(68, 175);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(215, 23);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "Tổng mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSumChan
            // 
            this.btnSumChan.Location = new System.Drawing.Point(68, 220);
            this.btnSumChan.Name = "btnSumChan";
            this.btnSumChan.Size = new System.Drawing.Size(75, 23);
            this.btnSumChan.TabIndex = 10;
            this.btnSumChan.Text = "Tổng chẵn";
            this.btnSumChan.UseVisualStyleBackColor = true;
            this.btnSumChan.Click += new System.EventHandler(this.btnSumChan_Click);
            // 
            // btnCountChan
            // 
            this.btnCountChan.Location = new System.Drawing.Point(190, 220);
            this.btnCountChan.Name = "btnCountChan";
            this.btnCountChan.Size = new System.Drawing.Size(115, 23);
            this.btnCountChan.TabIndex = 11;
            this.btnCountChan.Text = "Đếm số chẵn";
            this.btnCountChan.UseVisualStyleBackColor = true;
            this.btnCountChan.Click += new System.EventHandler(this.btnCountChan_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(348, 220);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 23);
            this.btnMax.TabIndex = 12;
            this.btnMax.Text = "Max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSumLe
            // 
            this.btnSumLe.Location = new System.Drawing.Point(68, 260);
            this.btnSumLe.Name = "btnSumLe";
            this.btnSumLe.Size = new System.Drawing.Size(75, 23);
            this.btnSumLe.TabIndex = 15;
            this.btnSumLe.Text = "Tổng lẻ";
            this.btnSumLe.UseVisualStyleBackColor = true;
            // 
            // btnCountLe
            // 
            this.btnCountLe.Location = new System.Drawing.Point(190, 260);
            this.btnCountLe.Name = "btnCountLe";
            this.btnCountLe.Size = new System.Drawing.Size(115, 23);
            this.btnCountLe.TabIndex = 14;
            this.btnCountLe.Text = "Đếm số lẻ";
            this.btnCountLe.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(348, 260);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 23);
            this.btnMin.TabIndex = 13;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnNT
            // 
            this.btnNT.Location = new System.Drawing.Point(68, 300);
            this.btnNT.Name = "btnNT";
            this.btnNT.Size = new System.Drawing.Size(355, 23);
            this.btnNT.TabIndex = 16;
            this.btnNT.Text = "Các số nguyên tố";
            this.btnNT.UseVisualStyleBackColor = true;
            // 
            // btnCountNT
            // 
            this.btnCountNT.Location = new System.Drawing.Point(68, 335);
            this.btnCountNT.Name = "btnCountNT";
            this.btnCountNT.Size = new System.Drawing.Size(355, 23);
            this.btnCountNT.TabIndex = 17;
            this.btnCountNT.Text = "Đếm các số nguyên tố";
            this.btnCountNT.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(68, 372);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(355, 23);
            this.btnReverse.TabIndex = 18;
            this.btnReverse.Text = "Đảo ngược dãy số";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 407);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnCountNT);
            this.Controls.Add(this.btnNT);
            this.Controls.Add(this.btnSumLe);
            this.Controls.Add(this.btnCountLe);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnCountChan);
            this.Controls.Add(this.btnSumChan);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbGoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbGoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbKQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSumChan;
        private System.Windows.Forms.Button btnCountChan;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSumLe;
        private System.Windows.Forms.Button btnCountLe;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnNT;
        private System.Windows.Forms.Button btnCountNT;
        private System.Windows.Forms.Button btnReverse;
    }
}

