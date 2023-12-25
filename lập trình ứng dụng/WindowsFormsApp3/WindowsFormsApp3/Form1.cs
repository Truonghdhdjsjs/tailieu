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

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
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
        private void btndisplay_Click(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtavarage.Text);
            decimal INTEREST_RATE = rate / 100;
            //const decimal INTEREST_RATE = 0.005m;
            decimal balance;
            int months;
            int count = 2;
            if (decimal.TryParse(txtstar.Text, out balance))
            {
                if (int.TryParse(txtnumber.Text, out months))
                {
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        listBox1.Items.Add("so lai moi thang" + count + "la" + balance.ToString("c"));
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
        void ghiFile1()
        {
            StreamWriter meme;
            string path = duongdanluu();
            meme = File.CreateText(path);
            meme.WriteLine("so tien la");
            meme.WriteLine("so tien ");
         
            meme.Close();

            MessageBox.Show("Ban da ghi File thanh cong\n Vi tri luu du nhu sau: " + path);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            ghiFile1();
        }
    }
}
