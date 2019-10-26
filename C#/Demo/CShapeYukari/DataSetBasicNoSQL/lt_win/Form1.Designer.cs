namespace lt_win
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
            this.components = new System.ComponentModel.Container();
            this.dfvSinhvien = new System.Windows.Forms.DataGridView();
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienTableAdapter = new lt_win.sinhvienDataSetTableAdapters.sinhvienTableAdapter();
            this.sinhvienDataSet = new lt_win.sinhvienDataSet();
            this.masvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phaiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dfvSinhvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dfvSinhvien
            // 
            this.dfvSinhvien.AutoGenerateColumns = false;
            this.dfvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvDataGridViewTextBoxColumn,
            this.hotenDataGridViewTextBoxColumn,
            this.ngaysinhDataGridViewTextBoxColumn,
            this.phaiDataGridViewCheckBoxColumn,
            this.diachiDataGridViewTextBoxColumn});
            this.dfvSinhvien.DataSource = this.sinhvienBindingSource;
            this.dfvSinhvien.Location = new System.Drawing.Point(2, 2);
            this.dfvSinhvien.Name = "dfvSinhvien";
            this.dfvSinhvien.Size = new System.Drawing.Size(543, 150);
            this.dfvSinhvien.TabIndex = 0;
            this.dfvSinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataMember = "sinhvien";
            this.sinhvienBindingSource.DataSource = this.sinhvienDataSet;
            // 
            // sinhvienTableAdapter
            // 
            this.sinhvienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhvienDataSet
            // 
            this.sinhvienDataSet.DataSetName = "sinhvienDataSet";
            this.sinhvienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masvDataGridViewTextBoxColumn
            // 
            this.masvDataGridViewTextBoxColumn.DataPropertyName = "masv";
            this.masvDataGridViewTextBoxColumn.HeaderText = "masv";
            this.masvDataGridViewTextBoxColumn.Name = "masvDataGridViewTextBoxColumn";
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            this.hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            this.hotenDataGridViewTextBoxColumn.HeaderText = "hoten";
            this.hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // ngaysinhDataGridViewTextBoxColumn
            // 
            this.ngaysinhDataGridViewTextBoxColumn.DataPropertyName = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.HeaderText = "ngaysinh";
            this.ngaysinhDataGridViewTextBoxColumn.Name = "ngaysinhDataGridViewTextBoxColumn";
            // 
            // phaiDataGridViewCheckBoxColumn
            // 
            this.phaiDataGridViewCheckBoxColumn.DataPropertyName = "phai";
            this.phaiDataGridViewCheckBoxColumn.HeaderText = "phai";
            this.phaiDataGridViewCheckBoxColumn.Name = "phaiDataGridViewCheckBoxColumn";
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "diachi";
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 488);
            this.Controls.Add(this.dfvSinhvien);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dfvSinhvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dfvSinhvien;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private sinhvienDataSetTableAdapters.sinhvienTableAdapter sinhvienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn phaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private sinhvienDataSet sinhvienDataSet;
    }
}

