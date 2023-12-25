using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            double rate = Convert.ToInt32(txtannual.Text);
            int F = Convert.ToInt32(txtfuture.Text);
            int Y = Convert.ToInt32(txtyear.Text);
            double INTEREST_RATE = rate / 100;
            double mau1 = 1 + INTEREST_RATE;
            double mau2 = Math.Pow(mau1, Y);
            double kq = F / mau2;
            listBox1.Items.Add("Present value :" + kq.ToString("c"));
        }

        void ghiFile1()
        {
            StreamWriter meme;
            string path = duongdanluu();
            meme = File.CreateText(path);
            meme.WriteLine("Số tiền gửi ban đầu là :" + txtfuture);
            meme.WriteLine("Số phần trăm lãi xuất là : " + txtannual);
            meme.WriteLine("Số năm để nhân :" + txtyear + "%");
            String str = "";
            foreach (String line in listBox1.Items)
            {
                str += line + "\n";
            }
            meme.WriteLine(str);
            meme.WriteLine("Số năm gửi :" +txtyear);
            meme.Close();
            MessageBox.Show("Ban da ghi File thanh cong\n Vi tri luu du nhu sau: " + path);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            ghiFile1();
        }
    }
}
