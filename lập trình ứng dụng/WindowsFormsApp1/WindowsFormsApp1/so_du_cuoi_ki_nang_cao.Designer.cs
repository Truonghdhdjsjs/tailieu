namespace WindowsFormsApp1
{
    partial class so_du_cuoi_ki_nang_cao
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
            this.txtstarting = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtending = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnlear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "starting Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "number of months";
            // 
            // txtstarting
            // 
            this.txtstarting.Location = new System.Drawing.Point(285, 58);
            this.txtstarting.Name = "txtstarting";
            this.txtstarting.Size = new System.Drawing.Size(100, 22);
            this.txtstarting.TabIndex = 2;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(285, 146);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(100, 22);
            this.txtnumber.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(77, 218);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 116);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ending balnace";
            // 
            // txtending
            // 
            this.txtending.Location = new System.Drawing.Point(285, 340);
            this.txtending.Name = "txtending";
            this.txtending.Size = new System.Drawing.Size(100, 22);
            this.txtending.TabIndex = 6;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(50, 402);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(75, 23);
            this.btncalculate.TabIndex = 7;
            this.btncalculate.Text = "calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnlear
            // 
            this.btnlear.Location = new System.Drawing.Point(285, 402);
            this.btnlear.Name = "btnlear";
            this.btnlear.Size = new System.Drawing.Size(75, 23);
            this.btnlear.TabIndex = 8;
            this.btnlear.Text = "clear";
            this.btnlear.UseVisualStyleBackColor = true;
            this.btnlear.Click += new System.EventHandler(this.btnlear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(506, 402);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "lai xuat co định";
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(622, 64);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(100, 22);
            this.txtrate.TabIndex = 11;
            // 
            // so_du_cuoi_ki_nang_cao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtending);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.txtstarting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "so_du_cuoi_ki_nang_cao";
            this.Text = "so_du_cuoi_ki_nang_cao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstarting;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtending;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnlear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrate;
    }
}