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
    public partial class so_du_cuoi_ki_nang_cao : Form
    {
        public so_du_cuoi_ki_nang_cao()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            decimal rate = Convert.ToDecimal(txtrate.Text);
            decimal INTEREST_RATE = rate / 100;
            //const decimal INTEREST_RATE = 0.005m;
            decimal balance;
            int months;
            int count = 1;
            if(decimal.TryParse(txtstarting.Text, out balance))
            {
                if(int.TryParse(txtnumber.Text,out months))
                {
                    while (count<=months)
                    {
                        balance = balance + (INTEREST_RATE * balance);
                        listBox1.Items.Add("so lai moi thang"+count +"la"+balance.ToString("c"));
                        count=count+1;
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
                MessageBox.Show("invalid value for starting balance");
            }
        }

        private void btnlear_Click(object sender, EventArgs e)
        {
            txtending.Text = "";
            txtnumber.Text = "";
            txtstarting.Text = "";
            listBox1.Items.Clear();
            txtrate.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
