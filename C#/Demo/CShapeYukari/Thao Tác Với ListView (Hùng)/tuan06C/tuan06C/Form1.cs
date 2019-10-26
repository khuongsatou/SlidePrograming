using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace tuan06C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string tensv = txtTenSV.Text;
            string dchi = txtDiachi.Text;
            string ngsinh = dateTimePicker1.Value.ToShortDateString();
            string lop = cbLop.Items[cbLop.SelectedIndex].ToString();
            dataGridView1.Rows.Add(masv, tensv, dchi, ngsinh, lop);

        }
        DataGridViewRow row = new DataGridViewRow();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            row.Cells["Column1"].Value = txtMaSV.Text;
            row.Cells["Column2"].Value = txtTenSV.Text;
            row.Cells["Column3"].Value = txtDiachi.Text;
            row.Cells["Column4"].Value = dateTimePicker1.Value;
            row.Cells["Column5"].Value = cbLop.Text;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView1.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells["Column1"].Value.ToString();
            txtTenSV.Text = row.Cells["Column2"].Value.ToString();
            txtDiachi.Text = row.Cells["Column3"].Value.ToString();
            dateTimePicker1.Text = row.Cells["Column4"].Value.ToString();
            cbLop.Text = row.Cells["Column5"].Value.ToString();

        }
        private void createclass()
        {
            cbLop.Items.Add("CDTH17A");
            cbLop.Items.Add("CDTH17B");
            cbLop.Items.Add("CDTH17C");
            cbLop.Items.Add("CDTH17D");
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
                dataGridView1.Rows.Remove(row);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string dir = Directory.GetCurrentDirectory();
                string patch = "..//..//Data/Data.txt";
                string[] allLine = File.ReadAllLines(patch);
                string line = "";
                for(int i=0;i<allLine.Length;i++)
                {
                    line = allLine[i];
                    string[] temp = line.Split("\t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if(temp.Length>0)
                    {
                        string masv = temp[0];
                        string tensv = temp[1];
                        string dchi = temp[2];
                        string ngsinh = temp[3];
                        string lop = temp[4];
                        dataGridView1.Rows.Add(masv, tensv, dchi, ngsinh, lop);
                    }
                }

            }
            catch(Exception err)
            { }
            createclass();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string patch = "..//..//Data/Data.txt";
            StreamWriter write = new StreamWriter(patch, false, Encoding.UTF8);
            for(int i=0;i<dataGridView1.RowCount-1;i++)
            {
                row = dataGridView1.Rows[i];
                string masv = row.Cells["Column1"].Value.ToString();
                string tensv = row.Cells["Column2"].Value.ToString();
                string dchi = row.Cells["Column3"].Value.ToString();
                string ngsinh = row.Cells["Column4"].Value.ToString();
                string lop = row.Cells["Column5"].Value.ToString();
                string str = masv + "\t" + tensv + "\t" + dchi + "\t" + ngsinh + "\t" + lop;
                write.WriteLine(str);
            }
            write.Close();
        }
    }
}
