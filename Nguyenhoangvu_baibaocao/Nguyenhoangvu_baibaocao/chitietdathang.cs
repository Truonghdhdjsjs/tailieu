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

namespace Nguyenhoangvu_baibaocao
{
    public partial class chitietdathang : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public chitietdathang()
        {
            InitializeComponent();
        }
        
        void connectDB()
        {
            string strDB = "Data Source=DESKTOP-JEIN43F\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            cnn = new SqlConnection(strDB);
            cnn.Open();
        }
        void disconnectDB()
        {
            cnn.Close();
        }
        DataTable FillDataTable(string strQuery)
        {
            connectDB();

            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter SqlDataAdapter = new SqlDataAdapter(strQuery, cnn);
                SqlDataAdapter.Fill(dataTable);
                SqlDataAdapter.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erros:" + ex.Message);

            }
            disconnectDB();
            return dataTable;
        }
        void LoadData()
        {
            string strSQL = "select * from chitietdathang";
            dataGridView1.DataSource = FillDataTable(strSQL);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chitietdathang_Load(object sender, EventArgs e)
        {
            LoadData();
            btnClear.Enabled = false;
            btnClose.Enabled = false;
            btnReload.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView1.Enabled=false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            btnClear.Enabled = false;
            btnClose.Enabled = false;
            btnReload.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void search()
        {
            string strsohoadon = Convert.ToString(txtsohoadon.Text);
            string strSQL = "select * from chitietdathang where sohoadon like '%" + strsohoadon + "%'";
            dataGridView1.DataSource = FillDataTable(strSQL);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                btnClear.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnClose.Enabled = true;
                btnReload.Enabled = true;
                btnSearch.Enabled = true;
                dataGridView1.Enabled = true;
                txtsohoadon.Focus();
                enable = false;
                

               
            }
            else
            {
                btnClear.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClose.Enabled = false;
                btnReload.Enabled = false;
                btnSearch.Enabled = false;
                dataGridView1.Enabled = false;
                txtsohoadon.Focus();
                enable = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strsohoadon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update chitietdathang  set sohoadon='" +
                this.txtsohoadon.Text.ToString() + "',mahang='" +
                   this.txtmahang.Text.ToString() + "',giaban='" +
                   this.txtgiaban.Text.ToString() + "',soluong='" +
                   this.txtsoluong.Text.ToString() + "',mucgiamgia='" +
                   this.txtmucgiamgia.Text.ToString() + "'where sohoadon='" +
                   strsohoadon + "'");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                LoadData();
                disconnectDB();

                MessageBox.Show("ĐÃ UPDATE THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ UPDATE ĐƯỢC!" + "XEM LẠI DỮ LIỆU NHẬP");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtsohoadon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtmahang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtgiaban.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtsoluong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtmucgiamgia.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strsohoadon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from chitietdathang where sohoadon='" + strsohoadon + "'");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                LoadData();
                disconnectDB();

                MessageBox.Show("ĐÃ DELETE THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ DELETE ĐƯỢC!" + "VUI LÒNG KIỂM TRA LẠI");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsohoadon.ResetText();
            txtsoluong.ResetText();
            txtmucgiamgia.ResetText();
            txtmahang.ResetText();
            txtgiaban.ResetText();
        }

    }
}
