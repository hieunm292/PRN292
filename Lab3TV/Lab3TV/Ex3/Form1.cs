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

namespace Ex3
{
    public partial class Form1 : Form
    {
        private string code = "";
        private CorrectCode[] correctCode = {
            new CorrectCode("1645", "Technicians"),
            new CorrectCode("1689", "Technicians"),
            new CorrectCode("8345", "Custodians"),
            new CorrectCode("9998", "Scientist"),
            new CorrectCode("1006", "Scientist"),
            new CorrectCode("1008", "Scientist")};


        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
        }

        private void btn2_Click(object sender, EventArgs e)
        {
        }

        private void btn3_Click(object sender, EventArgs e)
        {
        }

        private void btn4_Click(object sender, EventArgs e)
        {
        }

        private void btn5_Click(object sender, EventArgs e)
        {
        }

        private void btn6_Click(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
        }

        private void btn8_Click(object sender, EventArgs e)
        {
        }

        private void btn9_Click(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            code = "";
            textBox1.Text = code;
        }

        private void btnSha_Click(object sender, EventArgs e)
        {
            if (code.Length <= 1)
            {
                listBox1.Items.Add($"{DateTime.Now.ToString()} - Restricted Access");
                code = "";
                textBox1.Text = code;
                return;
            }
            foreach (CorrectCode i in correctCode)
            {
                if (code.Equals(i.Code))
                {
                    listBox1.Items.Add($"{DateTime.Now.ToString()} - {i.Role} - Granted !");
                    code = "";
                    textBox1.Text = code;
                    return;
                }       
            }
            code = "";
            textBox1.Text = code;
            listBox1.Items.Add($"{DateTime.Now.ToString()} - Access Denied");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter|| e.KeyChar == 13)
            {
                btnSha_Click(sender,e);
            }
            else
            {
                code = code + (e.KeyChar);
                Console.WriteLine(code);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            code = code + a.Text;
            textBox1.Text = code;
        }
    }
}
