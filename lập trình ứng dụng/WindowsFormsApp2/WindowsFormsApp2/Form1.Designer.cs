namespace WindowsFormsApp2
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
            this.txtaverage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstaring = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting number  of organisms";
            // 
            // txtaverage
            // 
            this.txtaverage.AutoSize = true;
            this.txtaverage.Location = new System.Drawing.Point(56, 121);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.Size = new System.Drawing.Size(146, 16);
            this.txtaverage.TabIndex = 1;
            this.txtaverage.Text = "Average daily increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "number of days to multiply";
            // 
            // txtstaring
            // 
            this.txtstaring.Location = new System.Drawing.Point(278, 49);
            this.txtstaring.Name = "txtstaring";
            this.txtstaring.Size = new System.Drawing.Size(100, 22);
            this.txtstaring.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(278, 188);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 22);
            this.txtnumber.TabIndex = 5;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(164, 480);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 7;
            this.btndisplay.Text = "Display";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(34, 289);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(725, 164);
            this.listBox1.TabIndex = 8;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(415, 480);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "save";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtstaring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtaverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstaring;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

