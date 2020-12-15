using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3TVEx2
{
    public partial class Form1 : Form
    {
        private int mode = 1;
        public Form1()
        {
            InitializeComponent();
        }

        public int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        public int GCD(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = a - b;
                if (b > a) b = b - a;
            }
            return a;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            mode = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            mode = 2;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (mode)
                {
                    case 1:
                        textResult.Text = GCD(int.Parse(textNum1.Text), int.Parse(textNum2.Text)).ToString();
                        break;
                    case 2:
                        textResult.Text = LCM(int.Parse(textNum1.Text), int.Parse(textNum2.Text)).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                textResult.Text = "Error";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textResult.Text = "";
            textNum2.Text = "";
            textNum1.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
