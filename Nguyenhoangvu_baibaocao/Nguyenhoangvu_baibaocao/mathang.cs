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
    public partial class Form : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public Form()
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
            string strSQL = "select * from mathang";
            dataGridView1.DataSource = fillDatatable(strSQL);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            panel1.Enabled = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

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
                txtmahang.Focus();
                enable = false;
            }
            else
            {
                btnClear.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                panel1.Enabled = false;
                txtmahang.Focus();
                enable = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtmahang.ResetText();
            txttenhang.ResetText();
            txtmacongty.ResetText();
            txtmaloaihang.ResetText();
            txtsoluong.ResetText();
            txtdonvitinh.ResetText();
            txtgiahang.ResetText();

            txtmahang.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtmahang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txttenhang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtmacongty.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtmaloaihang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtsoluong.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtdonvitinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtgiahang.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB();

                string strSQL = System.String.Concat("insert into mathang values('" +
                   this.txtmahang.Text.ToString() + "','" +
                   this.txttenhang.Text.ToString() + "','" +
                   this.txtmacongty.Text.ToString() + "','" +
                   Convert.ToInt32(this.txtmaloaihang.Text) + "','" +
                   Convert.ToInt32(this.txtsoluong.Text) + "','" +
                   this.txtdonvitinh.Text.ToString() + "','" +
                   Convert.ToDouble(this.txtgiahang.Text) + "')");

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

                string strmahang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update mathang  set mahang='" +
                this.txtmahang.Text.ToString() + "',tenhang='" +
                   this.txttenhang.Text.ToString() + "',macongty='" +
                   this.txtmacongty.Text.ToString() + "',maloaihang='" +
                   Convert.ToInt32(this.txtmaloaihang.Text) + "',soluong='" +
                   Convert.ToInt32(this.txtsoluong.Text) + "',donvitinh='" +
                   this.txtdonvitinh.Text.ToString() + "',giahang='" +
                   Convert.ToDouble(this.txtgiahang.Text) + "'where mahang='" +
                   strmahang + "'");

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

                string strmahang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from mathang where mahang='" + strmahang + "'");

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
    }
}
