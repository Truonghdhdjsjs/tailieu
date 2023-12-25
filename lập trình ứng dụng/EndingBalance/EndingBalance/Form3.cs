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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
 

        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double toan;
            double van;
            double anh;
            double tong;

            if (double.TryParse(textBox2.Text, out toan) && double.TryParse(textBox3.Text, out van) && double.TryParse(textBox4.Text, out anh))
            {
                if (toan >= 1 && toan <= 10 && van >= 1 && van <= 10 && anh >= 1 && anh <= 10)
                {
                    tong = ((toan * 2) + (van * 2) + anh) / 5;
                    textBox6.Text = tong.ToString();
                    if (tong >= 9)
                    {
                        textBox5.Text = "Giỏi";
                    }
                    else if (tong >= 7)
                    {
                        textBox5.Text = "Khá";
                    }
                    else if (tong >= 5)
                    {
                        textBox5.Text = "Trung Bình";
                    }
                    else
                    {
                        textBox5.Text = "Yếu";
                    }
                    listBox1.Items.Add(textBox1.Text.ToString() + "," + tong.ToString() + "," + textBox5.Text.ToString());
                }
                else
                {
                    MessageBox.Show("Hãy nhập điểm từ 1 đến 10.","Thông báo!");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đúng số điểm.","Thông báo!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    foreach (var item in listBox1.Items)
                    {
                        sw.Write(item.ToString() + Environment.NewLine);
                    }
                }
                MessageBox.Show("Lưu file thành công \nFile ở vị trí: " + filePath, "Thông báo");
            }
            else
            {
                MessageBox.Show("Không thể lưu file.","Thông báo!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            textBox1.Focus();
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
                MessageBox.Show("Đã đọc được file: " + filePath,"Thông báo!");
            }
            else
            {
                MessageBox.Show("Không thể mở file.","Thông báo!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn tắt chứ ?", "thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

