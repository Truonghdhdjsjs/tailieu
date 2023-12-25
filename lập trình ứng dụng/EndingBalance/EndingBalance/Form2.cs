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

namespace EndingBalance
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal rate;
            //Local variables
            decimal balance;
            int day;
            int count = 1;
        
            // get starting balance
            if(decimal.TryParse(textBox1.Text, out balance))
            {

                //Get the number of months
                if (int.TryParse(textBox4.Text, out day))
                {
                    listBox1.Items.Add("DAY       APPROXIMATE");
                    if (decimal.TryParse(textBox2.Text, out rate))
                    {
                        if(count == 1)
                        {
                            listBox1.Items.Add(count + "          " + balance.ToString());
                            count = count + 1;
                        }
                       
                        while (count <= day && count >=2)
                        {
                  
                          
                                //add this months interest to balance
                                balance = balance + (balance * (rate / 100));

                                listBox1.Items.Add(count + "          " + balance.ToString());
                                //Display this months ending balance
                                count = count + 1;
                            
                        }
                    }
           

                }
                else
                {
                    //Invalid number of months
                    MessageBox.Show("Invalid number of days!");
                }
            }
            else
            {
                //Invalid number of months
                MessageBox.Show("Invalid number of starting number!");
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
  
            
            listBox1.Items.Clear();

            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            string fileName = @"D:\output.txt"; // change this to your desired location and file name
            using (var sw = File.AppendText(fileName))
                foreach (var item in listBox1.Items)
                    sw.WriteLine(item.ToString());
            MessageBox.Show("Success", "Thông báo!");
        }
    }
}
