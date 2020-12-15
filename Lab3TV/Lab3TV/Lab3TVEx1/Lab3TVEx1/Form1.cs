using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3TVEx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textNum1.Text);
            int n = int.Parse(textNum2.Text);
            int result = m + n;
            textResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textNum1.Text);
            int n = int.Parse(textNum2.Text);
            int result = m - n;
            textResult.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textNum1.Text);
            int n = int.Parse(textNum2.Text);
            int result = m * n;
            textResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int m = int.Parse(textNum1.Text);
            int n = int.Parse(textNum2.Text);
            int result = m % n;
            textResult.Text = result.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
