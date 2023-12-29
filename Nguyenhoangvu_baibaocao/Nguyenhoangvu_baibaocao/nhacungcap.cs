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
    public partial class nhacungcap : System.Windows.Forms.Form
    {
        bool enable = true;
        SqlConnection cnn;
        public nhacungcap()
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
            string strSQL = "select * from nhacungcap";
            dataGridView1.DataSource = fillDatatable(strSQL);
        }
        void search()
        {
            string strmacongty = Convert.ToString(txtmacongty.Text);
            string strSQL = "select * from nhacungcap where macongty like '%" + strmacongty + "%'";
            dataGridView1.DataSource = fillDatatable(strSQL);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txttengiaodich.ResetText();
            txttencongty.ResetText();
            txtmacongty.ResetText();
            txtfax.ResetText();
            txtemail.ResetText();
            txtdt.ResetText();
            txtdiachi.ResetText();
            txtmacongty.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmacongty = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update nhacungcap  set macongty='" +
                this.txtmacongty.Text.ToString() + "',tencongty='" +
                   this.txttencongty.Text.ToString() + "',tengiaodich='" +
                   this.txttengiaodich.Text.ToString() + "',diachi='" +
                   this.txtdiachi.Text.ToString() + "',dienthoai='" +
                    this.txtdt.Text.ToString() + "',fax='" +
                     this.txtfax.Text.ToString() + "',email='" +
                   this.txtemail.Text.ToString() + "'where sohoadon='" +
                   strmacongty + "'");

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

                string strmacongty = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from nhacungcap where macongty='" + strmacongty + "'");

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

        private void btnReload_Click(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReload.Enabled = false;
            panel1.Enabled = false;
        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            Loaddata();
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnReload.Enabled = false;
            panel1.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtmacongty.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txttencongty.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txttengiaodich.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtdiachi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtdt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtemail.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            txtfax.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
