using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyenhoangvu_baibaocao
{
    public partial class dangnhap : System.Windows.Forms.Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if((txtUser.Text=="nva")&&(txtPass.Text=="111"))
            {
                this.Close();
            } 
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng", "Thông báo");
                txtUser.Focus();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
                Application.Exit();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
