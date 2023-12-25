namespace WindowsFormsApp3
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
            this.txtstar = new System.Windows.Forms.TextBox();
            this.txtavarage = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "starting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "average";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "number";
            // 
            // txtstar
            // 
            this.txtstar.Location = new System.Drawing.Point(235, 43);
            this.txtstar.Name = "txtstar";
            this.txtstar.Size = new System.Drawing.Size(100, 22);
            this.txtstar.TabIndex = 3;
            // 
            // txtavarage
            // 
            this.txtavarage.Location = new System.Drawing.Point(235, 128);
            this.txtavarage.Name = "txtavarage";
            this.txtavarage.Size = new System.Drawing.Size(100, 22);
            this.txtavarage.TabIndex = 4;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(235, 211);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 22);
            this.txtnumber.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(684, 84);
            this.listBox1.TabIndex = 6;
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(130, 392);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(113, 30);
            this.btndisplay.TabIndex = 7;
            this.btndisplay.Text = "hiển thị";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(400, 392);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtavarage);
            this.Controls.Add(this.txtstar);
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
        private System.Windows.Forms.TextBox txtstar;
        private System.Windows.Forms.TextBox txtavarage;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

