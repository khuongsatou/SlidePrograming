namespace Tuan05BaiTapMang
{
    partial class Form2
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
            this.btnNhapN = new System.Windows.Forms.Button();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNhapN
            // 
            this.btnNhapN.Location = new System.Drawing.Point(81, 67);
            this.btnNhapN.Name = "btnNhapN";
            this.btnNhapN.Size = new System.Drawing.Size(75, 23);
            this.btnNhapN.TabIndex = 0;
            this.btnNhapN.Text = "OK";
            this.btnNhapN.UseVisualStyleBackColor = true;
            this.btnNhapN.Click += new System.EventHandler(this.btnNhapN_Click);
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(62, 41);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(123, 20);
            this.txtNhapN.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 164);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.btnNhapN);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapN;
        private System.Windows.Forms.TextBox txtNhapN;
    }
}