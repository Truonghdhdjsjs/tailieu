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
    public partial class khachhang : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public khachhang()
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
            string strSQL = "select * from khachhang";
            dataGridView1.DataSource = fillDatatable(strSQL);
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

        private void khachhang_Load(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReload.Enabled = false;
            panel1.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmakhachhang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update khachhang  set makhachhang='" +
                this.txtmakhachhang.Text.ToString() + "',tencongty='" +
                   this.txttencongty.Text.ToString() + "',tengiaodich='" +
                   this.txttengiaodich.Text.ToString() + "',diachi='" +
                   this.txtdiachi.Text.ToString() + "',email='" +
                   this.txtemail.Text.ToString() + "',dienthoai='" +
                   this.txtdt.Text.ToString() + "',fax='" +
                   this.txtfax.Text.ToString() + "'where makhachhang='" +
                   strmakhachhang + "'");

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

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (enable)
            {
                btnClear.Enabled = true;
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

                panel1.Enabled = true;
                txtmakhachhang.Focus();
                enable = false;
            }
            else
            {
                btnClear.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                panel1.Enabled = false;
                txtmakhachhang.Focus();
                enable = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtmakhachhang.ResetText();
            txttencongty.ResetText();
            txtdiachi.ResetText();
            txttengiaodich.ResetText();
            txtemail.ResetText();
            txtdt.ResetText();
            txtfax.ResetText();
            txtmakhachhang.Focus();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB();


                string strSQL = System.String.Concat("Insert into makhachhang Values('" +
                this.txtmakhachhang.Text.ToString() +
                   this.txttencongty.Text.ToString() + "','" +
                   this.txttengiaodich.Text.ToString() + "','" +
                   this.txtdiachi.Text.ToString() + "','" +
                   this.txtdt.Text.ToString() + "','" +
                   this.txtemail.Text.ToString() + "','" +
                   this.txtfax.Text.ToString() + "','" + "')");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                Loaddata();
                disconnectDB();

                MessageBox.Show("ĐÃ Insert THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ Insert ĐƯỢC!" + "XEM LẠI DỮ LIỆU NHẬP");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmakhachhang = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from khachhang where makhachhang='" + strmakhachhang + "'");

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
            txtmakhachhang.Text=Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txttencongty.Text=Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txttengiaodich.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtdiachi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtdt.Text=Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtemail.Text=Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            txtfax.Text=Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }
    }
}
