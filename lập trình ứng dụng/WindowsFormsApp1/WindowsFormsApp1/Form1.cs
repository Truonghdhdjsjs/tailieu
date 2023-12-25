using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncaculate_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005M;
            decimal balance;
            int months;
            int count = 1;
            if(decimal.TryParse(txtstarting.Text, out balance))
            {
                if (int.TryParse(txtmoths.Text, out months))
                {
                    while (count <= months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        count = count + 1;
                    }
                    txtending.Text = balance.ToString("c");
                }
                else
                {
                    MessageBox.Show("invalid value for months");
                }
            }
            else
            {
                MessageBox.Show("invalid value for staring balance");
            }
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtending.Text = "";
            txtmoths.Text = "";
            txtstarting.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
