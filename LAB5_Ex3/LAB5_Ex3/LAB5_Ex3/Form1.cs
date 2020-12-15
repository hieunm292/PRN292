using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtTen.Text += Console.ReadLine();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            txtDienThoai.Text += Console.ReadLine();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text += Console.ReadLine();
        }

        private void cbNgaySinh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Equals("") || txtDiaChi.Text.Equals("") || txtEmail.Text.Equals("") || txtDienThoai.Text.Equals(""))
            {
                MessageBox.Show("All Information Cannot Be Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtDienThoai.Text, @"[0]{1}[0-9]{9}$"))
            {
                MessageBox.Show("Phone number must start with 0 and has 10 digits", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("Email format: a@a.a", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListViewItem lvi = listView.Items.Add(txtTen.Text);
                lvi.SubItems.Add(txtDienThoai.Text);
                lvi.SubItems.Add(dtpDate.Value.ToShortDateString());
                lvi.SubItems.Add(txtDiaChi.Text);
                lvi.SubItems.Add(txtTuoi.Text);
                lvi.SubItems.Add(txtNamKinhNghiem.Text);
                lvi.SubItems.Add(txtEmail.Text);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.SelectedItems[0].SubItems[0].Text = txtTen.Text;
                listView.SelectedItems[0].SubItems[1].Text = dtpDate.Value.ToString();
                listView.SelectedItems[0].SubItems[2].Text = txtDienThoai.Text;
                listView.SelectedItems[0].SubItems[3].Text = txtDiaChi.Text;
                listView.SelectedItems[0].SubItems[3].Text = txtTuoi.Text;
                listView.SelectedItems[0].SubItems[3].Text = txtNamKinhNghiem.Text;
                listView.SelectedItems[0].SubItems[3].Text = txtEmail.Text;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Remove(listView.SelectedItems[0]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd =new SaveFileDialog() { Filter="TExt Document |*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using(TextWriter tw=new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach(ListViewItem item in listView.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2] + "\t" + item.SubItems[3].Text + "\t" + item.SubItems[4].Text + "\t" + item.SubItems[5].Text + "\t" + item.SubItems[6].Text );
                        }
                        MessageBox.Show("Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtTuoi_TextChanged(object sender, EventArgs e)
        {
            txtTuoi.Text += Console.ReadLine();
        }

        private void txtNamKinhNghiem_TextChanged(object sender, EventArgs e)
        {
            txtNamKinhNghiem.Text += Console.ReadLine();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.Text += Console.ReadLine();
        }

        private void export2File(ListView lv, string splitter)
        {
            string filename = "text.txt";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.txt) | *.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "text.txt")
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
                    {
                        foreach (ListViewItem item in lv.Items)
                        {
                            sw.WriteLine("{0}{1}{2}", item.SubItems[0].Text, splitter, item.SubItems[1].Text);
                        }
                    }
                }
            }
        }
    }
}
