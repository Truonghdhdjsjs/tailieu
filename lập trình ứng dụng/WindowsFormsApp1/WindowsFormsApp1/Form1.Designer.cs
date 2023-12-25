namespace WindowsFormsApp1
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
            this.txtstarting = new System.Windows.Forms.TextBox();
            this.txtending = new System.Windows.Forms.TextBox();
            this.txtmoths = new System.Windows.Forms.TextBox();
            this.btncaculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "starting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "number of months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ending balance";
            // 
            // txtstarting
            // 
            this.txtstarting.Location = new System.Drawing.Point(306, 59);
            this.txtstarting.Name = "txtstarting";
            this.txtstarting.Size = new System.Drawing.Size(100, 22);
            this.txtstarting.TabIndex = 3;
            // 
            // txtending
            // 
            this.txtending.Location = new System.Drawing.Point(306, 204);
            this.txtending.Name = "txtending";
            this.txtending.Size = new System.Drawing.Size(100, 22);
            this.txtending.TabIndex = 4;
            // 
            // txtmoths
            // 
            this.txtmoths.Location = new System.Drawing.Point(306, 127);
            this.txtmoths.Name = "txtmoths";
            this.txtmoths.Size = new System.Drawing.Size(100, 22);
            this.txtmoths.TabIndex = 5;
            // 
            // btncaculate
            // 
            this.btncaculate.Location = new System.Drawing.Point(84, 330);
            this.btncaculate.Name = "btncaculate";
            this.btncaculate.Size = new System.Drawing.Size(75, 23);
            this.btncaculate.TabIndex = 6;
            this.btncaculate.Text = "calculate";
            this.btncaculate.UseVisualStyleBackColor = true;
            this.btncaculate.Click += new System.EventHandler(this.btncaculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(331, 330);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(563, 330);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncaculate);
            this.Controls.Add(this.txtmoths);
            this.Controls.Add(this.txtending);
            this.Controls.Add(this.txtstarting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ending balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstarting;
        private System.Windows.Forms.TextBox txtending;
        private System.Windows.Forms.TextBox txtmoths;
        private System.Windows.Forms.Button btncaculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

