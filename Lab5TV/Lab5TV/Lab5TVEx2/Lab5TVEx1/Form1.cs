using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5TVEx1
{
    public partial class Form1 : Form
       
    {
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            bool kt = false;
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (row.ItemArray[i].ToString() == b.Text)
                {
                    kt = true;
                    row.SetField("Số lượng", int.Parse(row.ItemArray[i + 1].ToString()) + 1);
                    i++;
                    break;
                }

            }
            if (kt == false)
            {
                dt.Rows.Add(b.Text, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Món Ăn", typeof(string));
            dt.Columns.Add("Số Lượng", typeof(int));
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Số bàn trống,xin nhập số bàn !!!");
            }
            else
            {
                listBox1.Items.Add("Số bàn : " + comboBox1.SelectedItem);
                int i = 0;
                foreach (DataRow data in dt.Rows)
                {
                    if (i < dt.Rows.Count)
                    {
                        listBox1.Items.Add("Món ăn : " + data.ItemArray[i].ToString() + " |Số lượng : " + int.Parse(data.ItemArray[i + 1].ToString()));

                    }
                    else
                        break;
                }
            }
        }
    }
}
