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
    public partial class dondathang : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public dondathang()
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
        DataTable fillDatatable(string strQuery)
        {
            connectDB();
            DataTable datatable = new DataTable();
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strQuery, cnn);
                sqlDataAdapter.Fill(datatable);
                sqlDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            disconnectDB();
            return datatable;
        }
        void Loaddata()
        {
            string strSQL = "select * from dondathang";
            dataGridView1.DataSource = fillDatatable(strSQL);
        }

        private void dondathang_Load(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReload.Enabled = false;

            panel1.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReload.Enabled = false;

            panel1.Enabled = false;
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                btnClear.Enabled = true;
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                panel1.Enabled = true;
                txtsohoadon.Focus();
                enable = false;
            }
            else
            {
                btnClear.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                panel1.Enabled = false;
                txtsohoadon.Focus();
                enable = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsohoadon.ResetText();
            txtnoigiao.ResetText();
            txtngaygiao.ResetText();
            txtngaydat.ResetText();
            txtngaychuyen.ResetText();
            txtmanhanvien.ResetText();
            txtmakhachhang.ResetText();
            txtsohoadon.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB();

                string strSQL = System.String.Concat("insert into dondathang values('" +
                   this.txtsohoadon.Text.ToString() + "','" +
                   this.txtmakhachhang.Text.ToString() + "','" +
                   this.txtmanhanvien.Text.ToString() + "','" +
                   Convert.ToInt32(this.txtngaydat.Text) + "','" +
                   Convert.ToInt32(this.txtngaychuyen.Text) + "','" +
                   this.txtngaygiao.Text.ToString() + "','" +
                   Convert.ToDouble(this.txtnoigiao.Text) + "')");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                Loaddata();
                disconnectDB();

                MessageBox.Show("ĐÃ INSERT THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ INSERT ĐƯỢC!" + "XEM LẠI KHÓA CHÍNH MÃ HÀNG" + "XEM LẠI KHÓA NGOẠI CỦA MÃ CÔNG TY HOẶC MÃ LOẠI HÀNG");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strsohoadon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update dondathang  set sohoadon='" +
                this.txtsohoadon.Text.ToString() + "',makhachhang='" +
                   this.txtmakhachhang.Text.ToString() + "',manhanvien='" +
                   this.txtmanhanvien.Text.ToString() + "',ngaydathang='" +
                   Convert.ToInt32(this.txtngaydat.Text) + "',ngaygiaohang='" +
                   Convert.ToInt32(this.txtngaygiao.Text) + "',ngaychuyenhang='" +
                   this.txtngaychuyen.Text.ToString() + "',noigiaohang='" +
                   Convert.ToDouble(this.txtnoigiao.Text) + "'where mahang='" +
                   strsohoadon + "'");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                Loaddata();
                disconnectDB();

                MessageBox.Show("ĐÃ UPDATE THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ UPDATE ĐƯỢC!" + "XEM LẠI DỮ LIỆU NHẬP");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strsohoadon = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from dondathang where sohoadon='" + strsohoadon + "'");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                Loaddata();
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtsohoadon.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtmakhachhang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtmanhanvien.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtngaydat.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtngaygiao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtngaychuyen.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtnoigiao.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }
    }
}
