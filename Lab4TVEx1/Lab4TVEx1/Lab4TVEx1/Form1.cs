using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4TVEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void GetPay()
        {
            int total = 0;
            if (textName.Text == "")
            {
                MessageBox.Show("Enter your name please !");
            }if(checkBoxCaoVoi.Checked==true){
                total += 100000;
            }
            if (checkBoxTayTrang.Checked == true)
            {
                total += 1200000;
            }
            if (checkBoxChupHinh.Checked == true)
            {
                total += 200000;
            }
            total = total + (int)numericUpDown.Value * 80000;
            textTotal.Text = total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            GetPay();
        }
    }
}
