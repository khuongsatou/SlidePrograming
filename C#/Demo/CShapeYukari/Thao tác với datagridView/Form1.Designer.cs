namespace AccessDB
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
            this.btnHienDanhSach = new System.Windows.Forms.Button();
            this.btnHienLop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHienDanhSach
            // 
            this.btnHienDanhSach.Location = new System.Drawing.Point(71, 56);
            this.btnHienDanhSach.Name = "btnHienDanhSach";
            this.btnHienDanhSach.Size = new System.Drawing.Size(138, 37);
            this.btnHienDanhSach.TabIndex = 0;
            this.btnHienDanhSach.Text = "Hiện Danh Sách";
            this.btnHienDanhSach.UseVisualStyleBackColor = true;
            this.btnHienDanhSach.Click += new System.EventHandler(this.btnHienDanhSach_Click);
            // 
            // btnHienLop
            // 
            this.btnHienLop.Location = new System.Drawing.Point(71, 141);
            this.btnHienLop.Name = "btnHienLop";
            this.btnHienLop.Size = new System.Drawing.Size(138, 46);
            this.btnHienLop.TabIndex = 1;
            this.btnHienLop.Text = "Hiện Lớp";
            this.btnHienLop.UseVisualStyleBackColor = true;
            this.btnHienLop.Click += new System.EventHandler(this.btnHienLop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnHienLop);
            this.Controls.Add(this.btnHienDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHienDanhSach;
        private System.Windows.Forms.Button btnHienLop;
    }
}

