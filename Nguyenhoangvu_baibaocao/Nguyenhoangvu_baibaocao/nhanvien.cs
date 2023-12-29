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
    public partial class nhanvien : System.Windows.Forms.Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
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
            string strSQL = "select * from nhanvien";
            dataGridView1.DataSource = FillDataTable(strSQL);
        }

        private void nhanvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
            txtmanhanvien.ResetText();
            txtngaysinh.ResetText();
            txtngaylamviec.ResetText();
            txtdiachi.ResetText();
            txtdt.ResetText();
            txtho.ResetText();
            txtten.ResetText();
            txtlcb.ResetText();
            txtpc.ResetText();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void search()
        {
            string strmanhanvien = Convert.ToString(txtmanhanvien.Text);
            string strSQL = "select * from nhanvien where manhanvien like '%" + strmanhanvien + "%'";
            dataGridView1.DataSource = FillDataTable(strSQL);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            txtmanhanvien.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            txtho.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            txtten.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            txtngaysinh.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            txtngaylamviec.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            txtdiachi.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            txtdt.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            txtlcb.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            txtpc.Text= Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmanhanvien = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("update nhanvien  set manhanvien='" +
                this.txtmanhanvien.Text.ToString() + "',ho='" +
                   this.txtho.Text.ToString() + "',ten='" +
                   this.txtten.Text.ToString() + "',ngaysinh='" +
                   this.txtngaysinh.Text.ToString() + "',ngaylamviec='" +
                   this.txtngaylamviec.Text.ToString() + "',diachi='" +
                   this.txtdiachi.Text.ToString() + "',dienthoai='" +
                   this.txtdt.Text.ToString() + "',luongcoban='" +
                   this.txtlcb.Text.ToString() + "',phucap = '" +
                   this.txtpc.Text.ToString() + "'where manhanvien='" +
                   strmanhanvien + "'");

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
            txtmanhanvien.ResetText();
            txtngaysinh.ResetText();
            txtngaylamviec.ResetText();
            txtten.ResetText();
            txtho.ResetText();
            txtdiachi.ResetText();
            txtdt.ResetText();
            txtlcb.ResetText();
            txtpc.ResetText();
            txtmanhanvien.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connectDB();
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                string strmanhanvien = dataGridView1.Rows[r].Cells[0].Value.ToString();
                string strSQL = System.String.Concat("delete from nhanvien where manhanvien='" + strmanhanvien + "'");

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

        private void btnInsert_Click(object sender, EventArgs e)
        {
           
            try
            {
                connectDB();


                string strSQL = System.String.Concat("Insert into manhanvien Values('" +
                this.txtmanhanvien.Text.ToString()  +
                   this.txtho.Text.ToString() + "','" +
                   this.txtten.Text.ToString() + "','" +
                   this.txtngaysinh.Text.ToString() + "','" +
                   this.txtngaylamviec.Text.ToString() + "','" +
                   this.txtdiachi.Text.ToString() + "','" +
                   this.txtdt.Text.ToString() + "','" +
                   this.txtlcb.Text.ToString() + "', '" +
                   this.txtpc.Text.ToString()   + "')");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();

                LoadData();
                disconnectDB();

                MessageBox.Show("ĐÃ Insert THÀNH CÔNG!");
            }
            catch (SqlException)
            {
                MessageBox.Show("KHÔNG THỂ Insert ĐƯỢC!" + "XEM LẠI DỮ LIỆU NHẬP");
            }

        }
    }
}
