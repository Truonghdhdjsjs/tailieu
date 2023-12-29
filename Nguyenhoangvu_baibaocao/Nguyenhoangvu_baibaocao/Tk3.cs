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
    public partial class Tk3 : Form
    {
        SqlConnection cnn;
        public Tk3()
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
            string strSQL1 = "select * from dondathang";
            string strSQL2 = "select * from chitietdathang";
            dataGridView1.DataSource = FillDataTable(strSQL1);
            dataGridView2.DataSource = FillDataTable(strSQL2);
        }
        void Search()
        {
            string strSHD = Convert.ToString(txtHoadon.Text);
            string strSQL1 = "select * from dondathang where sohoadon ='" + strSHD + "'";
            string strSQL2 = "select * from chitietdathang where sohoadon ='" + strSHD + "'";
            dataGridView1.DataSource = FillDataTable(strSQL1);
            dataGridView2.DataSource = FillDataTable(strSQL2);
        }
        private void txtTenhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string strSHD = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            string strSQL = "select * from chitietdathang where sohoadon ='" + strSHD + "'";
            dataGridView2.DataSource = FillDataTable(strSQL);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnReaload_Click(object sender, EventArgs e)
        {
            loadData();
            txtHoadon.ResetText();
            txtHoadon.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
