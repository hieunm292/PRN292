using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5TVEx3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text += Console.ReadLine();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            txtPhone.Text += Console.ReadLine();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Text += Console.ReadLine();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = listView1.Items.Add(txtName.Text);
            lvi.SubItems.Add(txtPhone.Text);
            lvi.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            lvi.SubItems.Add(txtAddress.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.SelectedItems[0].SubItems[0].Text = txtName.Text;
                listView1.SelectedItems[0].SubItems[1].Text = dateTimePicker1.Value.ToString();
                listView1.SelectedItems[0].SubItems[2].Text = txtPhone.Text;
                listView1.SelectedItems[0].SubItems[3].Text = txtAddress.Text;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
