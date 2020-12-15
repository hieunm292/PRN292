using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Lamthem_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ListViewItem item = lsvNhanVien.Items.Add(txtHoTen.Text);
            item.SubItems.Add(dtpNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(txtDiaChi.Text);
        }

        private void LsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Hien thi dong đang chọn lên Textbox
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                txtHoTen.Text=lsvNhanVien.SelectedItems[0].SubItems[0].Text;
                dtpNgaySinh.Text = lsvNhanVien.SelectedItems[0].SubItems[1].Text;
                txtDienThoai.Text = lsvNhanVien.SelectedItems[0].SubItems[2].Text;
                txtDiaChi.Text = lsvNhanVien.SelectedItems[0].SubItems[3].Text;
                
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.Items.Remove(lsvNhanVien.SelectedItems[0]);
            }
            else
                MessageBox.Show("Bạn chưa chọn dòng để xóa");
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                lsvNhanVien.SelectedItems[0].SubItems[0].Text = txtHoTen.Text;
                lsvNhanVien.SelectedItems[0].SubItems[1].Text = dtpNgaySinh.Value.ToShortDateString();
                lsvNhanVien.SelectedItems[0].SubItems[2].Text = txtDienThoai.Text;
                lsvNhanVien.SelectedItems[0].SubItems[3].Text = txtDiaChi.Text;
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.T)
            {
                btnThem.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.X)
            {
                btnXoa.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.S)
            {
                btnSua.PerformClick();
            }
            if (e.Control == true && e.KeyCode == Keys.Q)
            {
                btnThoat.PerformClick();
            }
        }
    }
}
