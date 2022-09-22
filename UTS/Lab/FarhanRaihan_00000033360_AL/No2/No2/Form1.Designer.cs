
namespace No2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPinjam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAngsur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBunga = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Besar Pinjaman";
            // 
            // txtPinjam
            // 
            this.txtPinjam.Location = new System.Drawing.Point(151, 40);
            this.txtPinjam.Name = "txtPinjam";
            this.txtPinjam.Size = new System.Drawing.Size(200, 23);
            this.txtPinjam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Besar Angsuran";
            // 
            // txtAngsur
            // 
            this.txtAngsur.Location = new System.Drawing.Point(151, 82);
            this.txtAngsur.Name = "txtAngsur";
            this.txtAngsur.Size = new System.Drawing.Size(200, 23);
            this.txtAngsur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bunga";
            // 
            // txtBunga
            // 
            this.txtBunga.Location = new System.Drawing.Point(151, 122);
            this.txtBunga.Name = "txtBunga";
            this.txtBunga.Size = new System.Drawing.Size(43, 23);
            this.txtBunga.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "%";
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(161, 168);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(257, 168);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(41, 219);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(310, 190);
            this.txtShow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 461);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBunga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAngsur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPinjam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPinjam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAngsur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBunga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtShow;
    }
}

