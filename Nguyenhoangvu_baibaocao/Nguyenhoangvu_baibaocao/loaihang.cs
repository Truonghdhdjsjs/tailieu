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
    public partial class loaihang : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public loaihang()
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
            string strSQL = "select * from loaihang";
            dataGridView1.DataSource = FillDataTable(strSQL);
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
                txtmaloaihang.Focus();
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
                txtmaloaihang.Focus();
                enable = true;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            btnReload.Enabled = false;
            btnSearch.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void loaihang_Load(object sender, EventArgs e)
        {
            LoadData();
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnClose.Enabled = false;
            btnReload.Enabled = false;
            btnSearch.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmaloaihang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update loaihang set maloaihang='" +
                Convert.ToInt32(this.txtmaloaihang.Text) + "',tenloaihang='" +
                this.txttenloaihang.Text.ToString() + "' where maloaihang='" + strmaloaihang + "'");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtmaloaihang.ResetText();
            txttenloaihang.ResetText();
            txtmaloaihang.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtmaloaihang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txttenloaihang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);

        }
        void search()
        {
            string strmaloaihang = Convert.ToString(txtmaloaihang.Text);
            string strSQL = "select * from loaihang where maloaihang like '%" + strmaloaihang + "%'";
            dataGridView1.DataSource = FillDataTable(strSQL);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmaloaihang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from loaihang where maloaihang='" + strmaloaihang + "'");

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
