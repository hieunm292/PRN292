using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
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
            tbOrder = new DataTable();
            tbOrder.Columns.Add("FoodName",typeof(string));
            tbOrder.Columns.Add("Quantity",typeof(int));
            dataGridView1.DataSource = tbOrder;
        }

        private void All_button_Click(object sender, EventArgs e)
        {          
            Button b = (Button)sender;
            bool kt = false; //kiểm tra xem một món có trong danh sách chưa?
            //DataRow r;
            foreach (DataRow row in tbOrder.Rows)
            {
               if( row.ItemArray[0].ToString()==b.Text)
                {
                    kt = true;
                    //row.ItemArray[1] = int.Parse(row.ItemArray[1].ToString()) + 1;
                    row.SetField("Quantity", int.Parse(row.ItemArray[1].ToString()) + 1);
                    break;
                }
            }
            if (kt == false)
            {
                //r= tbOrder.NewRow();
                //r["FoodName"] = b.Text;
                //r["Quantity"] = 1;
                tbOrder.Rows.Add(b.Text,1);
            }
        }
    }
}
