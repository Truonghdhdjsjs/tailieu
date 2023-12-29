using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Menu
{
    public partial class Tk1 : Form
    {
        SqlConnection cnn;
        public Tk1()
        {
            InitializeComponent();
        }
        void ConnectDB()
        {
            string strDB = "Data Source=DESKTOP-JEIN43F\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            cnn = new SqlConnection(strDB);
            cnn.Open();
        }
        void DisConnectDB()
        {
            cnn.Close();
        }
        DataTable FillDataTable(string sqlQuery)
        {
            ConnectDB();
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, cnn);
                //điền dữ liệu
                sqlDataAdapter.Fill(dataTable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            DisConnectDB();
            return dataTable;
        }
        void loadData()
        {
            string strSQL = "select * from mathang";
            dataGridView1.DataSource = FillDataTable(strSQL);
        }
        void Search()
        {
            string Tenhang = Convert.ToString(txtTenhang.Text);
            string Mahang = Convert.ToString(txtMahang.Text);
            string strSQL = "select * from mathang where tenhang='" + Tenhang + "' or mahang='"+Mahang+"'";
            dataGridView1.DataSource = FillDataTable(strSQL);
        }
        private void btnReaload_Click(object sender, EventArgs e)
        {
            loadData();
            txtTenhang.ResetText();
            txtTenhang.Focus();
            txtMahang.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
