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


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtaverage.Text);
            decimal INTEREST_RATE = rate / 100;
            //const decimal INTEREST_RATE = 0.005m;
            decimal balance;
            int months;
            int count = 1;
            if (decimal.TryParse(txtstaring.Text, out balance))
            {
                if (int.TryParse(txtnumber.Text, out months))
                {
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        listBox1.Items.Add("so lai moi ngay " + count + "la" + balance.ToString("c"));
                        count = count + 1;
                    }
                    
                }
                else
                {
                    MessageBox.Show("invalid value for months");
                }
            }
            else
            {
                MessageBox.Show("invalid value for starting balance");
            }
        }
        string duongdanluu()
        {
            string tam = "";
            saveFileDialog1.InitialDirectory = @"D:";
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
            meme.WriteLine("Bang lo");
            meme.WriteLine("Thich ctrl c");
            meme.WriteLine("ctrl v");
            meme.Close();

            MessageBox.Show("Ban da ghi File thanh cong\n Vi tri luu du nhu sau: " + path);
        }
    }
}
