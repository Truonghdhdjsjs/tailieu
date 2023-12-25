namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.txtav = new System.Windows.Forms.TextBox();
            this.btnDTB = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoas = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnmo = new System.Windows.Forms.Button();
            this.btnketthuc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxeploaij = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm văn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm av";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(196, 53);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(100, 22);
            this.txthoten.TabIndex = 4;
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(196, 108);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 22);
            this.txttoan.TabIndex = 5;
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(196, 167);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 22);
            this.txtvan.TabIndex = 6;
            // 
            // txtav
            // 
            this.txtav.Location = new System.Drawing.Point(196, 225);
            this.txtav.Name = "txtav";
            this.txtav.Size = new System.Drawing.Size(100, 22);
            this.txtav.TabIndex = 7;
            // 
            // btnDTB
            // 
            this.btnDTB.Location = new System.Drawing.Point(39, 287);
            this.btnDTB.Name = "btnDTB";
            this.btnDTB.Size = new System.Drawing.Size(75, 23);
            this.btnDTB.TabIndex = 8;
            this.btnDTB.Text = "tính Dtbvà XL";
            this.btnDTB.UseVisualStyleBackColor = true;
            this.btnDTB.Click += new System.EventHandler(this.btnDTB_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(196, 287);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoas
            // 
            this.btnxoas.Location = new System.Drawing.Point(351, 287);
            this.btnxoas.Name = "btnxoas";
            this.btnxoas.Size = new System.Drawing.Size(75, 23);
            this.btnxoas.TabIndex = 10;
            this.btnxoas.Text = "Xóa";
            this.btnxoas.UseVisualStyleBackColor = true;
            this.btnxoas.Click += new System.EventHandler(this.btnxoas_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(39, 371);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "lưu file";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnmo
            // 
            this.btnmo.Location = new System.Drawing.Point(196, 371);
            this.btnmo.Name = "btnmo";
            this.btnmo.Size = new System.Drawing.Size(75, 23);
            this.btnmo.TabIndex = 12;
            this.btnmo.Text = "mở file";
            this.btnmo.UseVisualStyleBackColor = true;
            this.btnmo.Click += new System.EventHandler(this.btnmo_Click);
            // 
            // btnketthuc
            // 
            this.btnketthuc.Location = new System.Drawing.Point(351, 371);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(75, 23);
            this.btnketthuc.TabIndex = 13;
            this.btnketthuc.Text = "kết thúc";
            this.btnketthuc.UseVisualStyleBackColor = true;
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Điểm trung bình";
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(628, 61);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(100, 22);
            this.txtDTB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Xếp loại";
            // 
            // txtxeploaij
            // 
            this.txtxeploaij.Location = new System.Drawing.Point(628, 142);
            this.txtxeploaij.Name = "txtxeploaij";
            this.txtxeploaij.Size = new System.Drawing.Size(100, 22);
            this.txtxeploaij.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(506, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 196);
            this.listBox1.TabIndex = 18;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtxeploaij);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.btnmo);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoas);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnDTB);
            this.Controls.Add(this.txtav);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.TextBox txtav;
        private System.Windows.Forms.Button btnDTB;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoas;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnmo;
        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxeploaij;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

