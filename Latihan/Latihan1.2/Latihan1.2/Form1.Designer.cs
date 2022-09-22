
namespace Latihan1._2
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
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.Hasil = new System.Windows.Forms.Label();
            this.Angka1 = new System.Windows.Forms.Label();
            this.Angka2 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(83, 24);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(135, 23);
            this.txtAngka1.TabIndex = 0;
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(83, 81);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(135, 23);
            this.txtAngka2.TabIndex = 1;
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Location = new System.Drawing.Point(83, 185);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(0, 15);
            this.Hasil.TabIndex = 2;
            // 
            // Angka1
            // 
            this.Angka1.AutoSize = true;
            this.Angka1.Location = new System.Drawing.Point(20, 31);
            this.Angka1.Name = "Angka1";
            this.Angka1.Size = new System.Drawing.Size(50, 15);
            this.Angka1.TabIndex = 3;
            this.Angka1.Text = "Angka 1";
            this.Angka1.Click += new System.EventHandler(this.label2_Click);
            // 
            // Angka2
            // 
            this.Angka2.AutoSize = true;
            this.Angka2.Location = new System.Drawing.Point(20, 89);
            this.Angka2.Name = "Angka2";
            this.Angka2.Size = new System.Drawing.Size(50, 15);
            this.Angka2.TabIndex = 4;
            this.Angka2.Text = "Angka 2";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 139);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(45, 23);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hasil";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(71, 139);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(45, 23);
            this.btnKurang.TabIndex = 7;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(122, 139);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(45, 23);
            this.btnKali.TabIndex = 8;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(173, 139);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(45, 23);
            this.btnBagi.TabIndex = 9;
            this.btnBagi.Text = ":";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 225);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.Angka2);
            this.Controls.Add(this.Angka1);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.Label Angka1;
        private System.Windows.Forms.Label Angka2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
    }
}

