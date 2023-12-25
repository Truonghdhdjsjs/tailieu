using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        public SqlConnection cnn;
        public SqlDataAdapter da;
        public DataSet ds;

        void Dinh_dang_luoi()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Mã số học sinh";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Tên học sinh";
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].Width = 250;


        }
        void load_dulieu_from()
        {
            try
            {
                cnn = new SqlConnection();
                cnn.ConnectionString = "Data Source=LAPTOP-MNQHM0TG\\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
                cnn.Open();
                ds = new DataSet();
                da = new SqlDataAdapter("select * from HOCSINH", cnn);
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Dinh_dang_luoi();
                DataGridViewRow row = dataGridView1.Rows[0];
                txtmaso.Text = row.Cells["MAHS"].Value.ToString();
                txthoten.Text = row.Cells["HOTEN"].Value.ToString();
                if (row.Cells["NGAYSINH"].Value.ToString().Length > 0)

                    dttime.Value = DateTime.Parse(row.Cells["NGAYSINH"].Value.ToString());
                txtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
            }
            catch {

                MessageBox.Show(" không thể kết nối vào CSDL");
            }
        }
        bool kiem_tra_them()
        {
            if (txtmaso.Text == "")
            {
                MessageBox.Show(" chưa nhập mã số sinh viên");
                return false;
            }
            if (txthoten.Text == "")
            {
                MessageBox.Show(" chưa nhập họ tên ");
                return false;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show(" chưa nhập địa chỉ ");
                return false;
            }
            if (cnn.State == ConnectionState.Closed)

                cnn.Open();
            string lenh = "select * from HOCSINH where MAHS='" + txtmaso.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(lenh, cnn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã học sinh đã tồn tại");
                return false;
            }
            return true;
        }
        bool kiem_tra_xoa()
        {
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            string lenh = "select * from KETQUA  where MAHS='" + txtmaso.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(lenh, cnn);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Mã học sinh đã tồn tại không thể xóa được");
                return false;
            }
            return true;
        }
        void insert()
        {
            SqlCommand them_hocsinh = new SqlCommand("them_hocsinh", cnn);
            them_hocsinh.CommandType = CommandType.StoredProcedure;
            SqlParameter p1= them_hocsinh.Parameters.Add("@mahs",SqlDbType.Char,9);
            p1.Value = txtmaso.Text;
            SqlParameter p2 = them_hocsinh.Parameters.Add("@hoten", SqlDbType.Char, 100);
            p2.Value = txthoten.Text;
            SqlParameter p3 = them_hocsinh.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            p3.Value = dttime.Value;
            SqlParameter p4 = them_hocsinh.Parameters.Add("@diachi", SqlDbType.Char, 100);
            p4.Value = txtdiachi.Text;

            them_hocsinh.ExecuteNonQuery();
        }
            void delete()
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa chứ ?", "thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand xoa_hocsinh = new SqlCommand("xoa_hocsinh", cnn);
                xoa_hocsinh.CommandType = CommandType.StoredProcedure;
                SqlParameter p1 = xoa_hocsinh.Parameters.Add("@mahs", SqlDbType.Char, 9);
                p1.Value = txtmaso.Text;
                xoa_hocsinh.ExecuteNonQuery();
            }
        }
        void update()
        {
            string mahs_cu;
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            DataGridViewRow row = rows[0];
            mahs_cu = row.Cells["MAHS"].Value.ToString();
            SqlCommand lenh_sua = new SqlCommand("sua_hocsinh2", cnn);
            lenh_sua.CommandType = CommandType.StoredProcedure;
            SqlParameter p1= lenh_sua.Parameters.Add("@mahs_cu", SqlDbType.Char, 9);
            p1.Value = mahs_cu;
            SqlParameter p2 = lenh_sua.Parameters.Add("@mahs_moi", SqlDbType.Char, 9);
            p2.Value = txtmaso.Text;
            SqlParameter p3 = lenh_sua.Parameters.Add("@hoten", SqlDbType.Char, 100);
            p3.Value = txthoten.Text;
            SqlParameter p4 = lenh_sua.Parameters.Add("@ngaysinh", SqlDbType.DateTime);
            p4.Value = dttime.Value;
            SqlParameter p5 = lenh_sua.Parameters.Add("@diachi", SqlDbType.Char, 100);
            p5.Value = mahs_cu;
            lenh_sua.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_dulieu_from();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(kiem_tra_them())
            {
                if(cnn.State==ConnectionState.Closed) 
                cnn.Open();
                try
                {
                    insert();
                    MessageBox.Show(" đã thêm thành công ");
                }
                catch(Exception ex) {
                    MessageBox.Show(" đã thêm thất bại"+ex.ToString());
                }
                load_dulieu_from();
            }    
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc muốn update dữ liệu không", "thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (kiem_tra_xoa())
                {
                    if (cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    try
                    {
                        insert();
                        MessageBox.Show(" đã xoa thành công ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( ex.ToString());
                    }
                    load_dulieu_from();
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("bạn có chắc muốn update dữ liệu không" ,"thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                     
                try
                {
                    insert();
                    MessageBox.Show(" đã SU thành công ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(  ex.ToString());
                }
                load_dulieu_from();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rows.Count > 0)
            {
                DataGridViewRow row = rows[0];
                txtmaso.Text = row.Cells["MAHS"].Value.ToString();
                txthoten.Text = row.Cells["HOTEN"].Value.ToString();
                if(row.Cells["HOTEN"].Value.ToString().Length>0)
                    dttime.Value = DateTime.Parse(row.Cells["NGÁYINH"].Value.ToString());
                txtdiachi.Text = row.Cells["DIACHI"].Value.ToString();
            }
        }
    }
}
