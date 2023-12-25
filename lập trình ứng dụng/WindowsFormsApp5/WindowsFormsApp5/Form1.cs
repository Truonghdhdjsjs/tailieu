using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDTB_Click(object sender, EventArgs e)
        {
            double toan = Convert.ToDouble(txttoan.Text);
            double van = Convert.ToDouble(txtvan.Text);
            double anhvan = Convert.ToDouble(txtav.Text);
            double tb = (toan * 2 + van * 2 + anhvan) / 5;
            txtDTB.Text = tb.ToString();
            if (tb >= 9)
            {
                txtxeploaij.Text = "Giỏi";
            }
            if (tb >= 7 && tb < 9)
            {
                txtxeploaij.Text = "Khá";

            }
            if (tb >= 5 && tb < 7)
            {
                txtxeploaij.Text = "Trung bình";
            }
            if (tb < 5)
            {
                txtxeploaij.Text = "Yếu";
            }
            listBox1.Items.Add("Tên Học Sinh :" + txthoten.Text);
            listBox1.Items.Add("Điểm toán :" + toan.ToString());
            listBox1.Items.Add("Điểm văn :" + van.ToString());
            listBox1.Items.Add("Điểm Anh Văn :" + anhvan.ToString());
            listBox1.Items.Add("Điểm Trung Binh :" + tb.ToString());
            listBox1.Items.Add("Xếp loại :" + txtxeploaij.Text);


        }
        string duongdanluu()
        {
            string tam = "";
            saveFileDialog1.InitialDirectory = @"C:\aaa";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tam = saveFileDialog1.FileName;
            }
            else
            {
                return null;
            }
            return tam;
        }
        void ghiFile1()
        {
            StreamWriter meme;
            string path = duongdanluu();
            meme = File.CreateText(path);
            meme.WriteLine("Họ tên là ");
            meme.WriteLine("Điểm toán");
            meme.WriteLine("Điểm văn ");
            meme.WriteLine("Điểm anh văn  ");
            meme.WriteLine("điểm trung bình ");
            meme.WriteLine("Xếp loại ");
            meme.Close();

            MessageBox.Show("Ban da ghi File thanh cong\n Vi tri luu du nhu sau: " + path);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            StreamWriter meme;
            string path = duongdanluu();
            meme = File.CreateText(path);
            meme.WriteLine("Tên Học Sinh: " + txthoten.Text);
            meme.WriteLine("Điểm Toán: " + txttoan.Text);
            meme.WriteLine("Điểm Văn: " + txtvan.Text);
            meme.WriteLine("Điểm Anh Văn: " + txtav.Text);
            meme.WriteLine("Điểm Trung Bình: " + txtDTB.Text);
            meme.WriteLine("Xếp Loại: " + txtxeploaij.Text);
            meme.Close();
            MessageBox.Show("Ban da ghi File thanh cong\n Vi tri luu du nhu sau: " + path);
        }
        string duongdanmo()
        {
            string tam = "";
            openFileDialog1.InitialDirectory = @"C:\aaa";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                tam = openFileDialog1.FileName;
            return tam;
        }
        void DocFile()
        {
            StreamReader inputFile;
            string path = duongdanluu();
            inputFile = File.OpenText(path);
            while (!inputFile.EndOfStream)
            {
                string tam = inputFile.ReadLine();
                listBox1.Items.Add(tam);
            }
            inputFile.Close();
        }
        private void btnmo_Click(object sender, EventArgs e)
        {
            DocFile();
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txthoten.Focus();
            txttoan.Clear();
            txtvan.Clear();
            txtav.Clear();
            txtDTB.Clear();
                txtxeploaij.Clear();
        }

        private void btnxoas_Click(object sender, EventArgs e)
        {
            txthoten.Focus();
            txttoan.Clear();
            txtvan.Clear();
            txtav.Clear();
            txtDTB.Clear();
            txtxeploaij.Clear();
            listBox1.Items.Clear();
        }
    }
}
