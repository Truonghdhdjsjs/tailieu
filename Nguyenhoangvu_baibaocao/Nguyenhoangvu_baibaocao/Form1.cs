using Menu;
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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void chiTiếtĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new chitietdathang();
            frm.ShowDialog();
        }

        private void đơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new dondathang();
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new khachhang();
            frm.ShowDialog();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new loaihang();
            frm.ShowDialog();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new Form();
            frm.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new nhacungcap();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new nhanvien();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new dangnhap();
            frm.ShowDialog();
        }

        private void tìmKiếm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new Tk1();
            frm.ShowDialog();
        }

        private void tìmKiếm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new Tk2();
            frm.ShowDialog();
        }

        private void tìmKiếm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Form frm = new Tk3();
            frm.ShowDialog();
        }
    }
}
