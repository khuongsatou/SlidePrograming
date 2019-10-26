using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttuan05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            ListViewItem lvwitem = new ListViewItem();
            lvwitem.Text = txtmasv.Text;
            lvwitem.SubItems.Add(txthoten.Text);
            lvwitem.SubItems.Add(txtdiachi.Text);
            lvwitem.SubItems.Add(dateTimePicker1.Text);
            lvwitem.SubItems.Add(cbxlop.Text);
            lvwds.Items.Add(lvwitem);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvwItem in lvwds.SelectedItems)
            {
                lvwItem.Remove();
            }


        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lvwds.SelectedItems[0];
                if (item != null)
                {
                    item.SubItems[0].Text = txtmasv.Text;//' <=> item.Text  
                    item.SubItems[1].Text = txthoten.Text;
                    item.SubItems[2].Text = txtdiachi.Text;
                    item.SubItems[3].Text = dateTimePicker1.Text;
                    item.SubItems[4].Text = cbxlop.Text;
                }
            }
            catch
            {
                MessageBox.Show("Ban chu nhap sinh vien !!!!");
            }

        }

        private void lvwds_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                ListViewItem item = lvwds.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    txtmasv.Text = item.SubItems[0].Text;//' <=> item.Text  
                    txthoten.Text = item.SubItems[1].Text;
                    txtdiachi.Text = item.SubItems[2].Text;
                    dateTimePicker1.Text = item.SubItems[3].Text;
                    cbxlop.Text = item.SubItems[4].Text;
                }

            }

        }

        

    }
}
