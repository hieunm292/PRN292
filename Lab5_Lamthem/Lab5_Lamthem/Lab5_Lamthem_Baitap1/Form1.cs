using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Lamthem_Baitap1
{
    public partial class Form1 : Form
    {
        DataTable tbOrder;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbOrder=new DataTable();
            tbOrder.Columns.Add("FoodName",typeof(string));
            tbOrder.Columns.Add("Quantity",typeof(int));
            //Tao khóa
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tbOrder.Columns[0];
            tbOrder.PrimaryKey = keys;
            dataGridView1.DataSource = tbOrder;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // lấy button được kích
            Button button = (Button) sender;
            
            DataRow foundrow = tbOrder.Rows.Find(button.Text);
            if (foundrow == null) tbOrder.Rows.Add(button.Text, 1);
            else
            {

                foreach (DataRow row in tbOrder.Rows)
                {
                    if (row["FoodName"].ToString() == button.Text)
                    {
                        row.SetField("Quantity", int.Parse(foundrow["Quantity"].ToString()) + 1);
                    }
                    break;
                }
            }
        }
    }
}
