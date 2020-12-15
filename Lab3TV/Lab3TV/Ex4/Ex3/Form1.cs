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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter writetext = new StreamWriter("log.txt"))
            {
                foreach (string i in listBox1.Items)
                writetext.WriteLine(i);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            code = code + a.Text;
            textBox1.Text = code;
        }
    }
}
