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

namespace FELAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strconn = "Server=nmHieusPC; Database=QL_BANGDIAX; User id=sa;password=123456";
        SqlConnection conn = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        int result = -1;
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDia.Text.Equals("") || txtTenDia.Text.Equals("") || txtTheLoai.Text.Equals(""))
            {
                MessageBox.Show("All Information Cannot Be Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (conn == null) conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = conn;
                command.CommandText = "insert into DIA values(@MADIA, @TENDIA,@THELOAI)";
                SqlParameter parameter1 = new SqlParameter("@MADIA", txtMaDia.Text);
                command.Parameters.Add(parameter1);
                SqlParameter parameter2 = new SqlParameter("@TENDIA", txtTenDia.Text);
                command.Parameters.Add(parameter2);
                SqlParameter parameter3 = new SqlParameter("@THELOAI", txtTheLoai.Text);
                command.Parameters.Add(parameter3);
                try
                {
                    result = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n Add Fail");
                }
                if (result > 0)
                {
                    MessageBox.Show("\n Success");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDia.Text.Equals("") || txtTenDia.Text.Equals("") || txtTheLoai.Text.Equals(""))
            {
                MessageBox.Show("All Information Cannot Be Empty!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "update DIA set TheLoai=@THELOAI,TenDia=@TENDIA where MaDia=@MADIA";
            SqlParameter parameter1 = new SqlParameter("@MADIA", txtMaDia.Text);
            command.Parameters.Add(parameter1);
            SqlParameter parameter2 = new SqlParameter("@TENDIA", txtTenDia.Text);
            command.Parameters.Add(parameter2);
            SqlParameter parameter3 = new SqlParameter("@THELOAI", txtTheLoai.Text);
            command.Parameters.Add(parameter3);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update fail");
            }
            if (result > 0)
            {
                MessageBox.Show("\n Success");
            }
        }
        

    private void btnXoa_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = "delete from DIA where MaDia=@MADIA";
            SqlParameter parameter1 = new SqlParameter("@MADIA", txtMaDia.Text);
            command.Parameters.Add(parameter1);
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update fail");
            }
            if (result > 0)
            {
                txtMaDia.Clear();
                txtTenDia.Clear();
                txtTheLoai.Clear();
            }
            if (result > 0)
            {
                MessageBox.Show("\n Success");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNhapDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string str = txtNhapDia.Text;

            adapter = new SqlDataAdapter("Select * from DIA where TenDia like N'%" + str + "%'", strconn);
            ds = new DataSet();
            adapter.Fill(ds, "DIA");

            dataGridView1.DataSource = ds.Tables[0];
        }
    
    }
}
