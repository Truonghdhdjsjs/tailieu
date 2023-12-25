using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndingBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //constant for the monthly interest
            const decimal INTEREST_RATE = 0.005m;

            //Local variables
            decimal balance;
            int months;
            int count = 1;
            // get starting balance
            if(decimal.TryParse(textBox1.Text, out balance))
            {

                //Get the number of months
                if (int.TryParse(textBox2.Text, out months))
                {
                    while (count <= months)
                    {


                        //add this months interest to balance
                        balance = balance + (INTEREST_RATE * balance);
                        //Display this months ending balance
                        count = count + 1;
                    }

                    //Display ending balance
                    textBox3.Text = balance.ToString("c");
                 }
                else
                {
                    //Invalid number of months
                    MessageBox.Show("Invalid number of months!");
                }
            }
            else
            {
                //Invalid number of months
                MessageBox.Show("Invalid number of starting balances!");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
