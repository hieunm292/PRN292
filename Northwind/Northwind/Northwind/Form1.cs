using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string stringconn = "Server=nmHieusPC; Database=Northwind; User id=sa;password=123456";
        SqlDataAdapter adapter = null;
        DataSet ds1 = null;
        DataSet ds2 = null;
        DataSet ds3 = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * from Products", stringconn);
            ds1 = new DataSet();
            adapter.Fill(ds1, "Products");

            adapter = new SqlDataAdapter("Select * from Suppliers", stringconn);
            ds2 = new DataSet();
            adapter.Fill(ds2, "Suppliers");

            adapter = new SqlDataAdapter("Select * from Categories", stringconn);
            ds3 = new DataSet();
            adapter.Fill(ds3, "Categories");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds1.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds2.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds3.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = txtProductName.Text;

            adapter = new SqlDataAdapter("Select * from Products where ProductName like '%" + str + "%'", stringconn);
            ds = new DataSet();
            adapter.Fill(ds, "Products");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = txtCompanyName.Text;

            adapter = new SqlDataAdapter("Select * from Suppliers where CompanyName like '%" + str + "%'", stringconn);
            ds = new DataSet();
            adapter.Fill(ds, "Suppliers");

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
