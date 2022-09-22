
namespace Week13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormula = new System.Windows.Forms.Button();
            this.btnParameter = new System.Windows.Forms.Button();
            this.perempuan = new System.Windows.Forms.RadioButton();
            this.laki = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tglAkhir = new System.Windows.Forms.DateTimePicker();
            this.tglAwal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM PENCARIAN DATA ULANG TAHUN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFormula);
            this.groupBox1.Controls.Add(this.btnParameter);
            this.groupBox1.Controls.Add(this.perempuan);
            this.groupBox1.Controls.Add(this.laki);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tglAkhir);
            this.groupBox1.Controls.Add(this.tglAwal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnFormula
            // 
            this.btnFormula.Location = new System.Drawing.Point(34, 219);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(296, 23);
            this.btnFormula.TabIndex = 8;
            this.btnFormula.Text = "Lakukan Pencarian Dengan Formula";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.btnFormula_Click);
            // 
            // btnParameter
            // 
            this.btnParameter.Location = new System.Drawing.Point(34, 190);
            this.btnParameter.Name = "btnParameter";
            this.btnParameter.Size = new System.Drawing.Size(296, 23);
            this.btnParameter.TabIndex = 7;
            this.btnParameter.Text = "Lakukan Pencarian Dengan Parameter";
            this.btnParameter.UseVisualStyleBackColor = true;
            this.btnParameter.Click += new System.EventHandler(this.btnParameter_Click);
            // 
            // perempuan
            // 
            this.perempuan.AutoSize = true;
            this.perempuan.Location = new System.Drawing.Point(49, 157);
            this.perempuan.Name = "perempuan";
            this.perempuan.Size = new System.Drawing.Size(79, 17);
            this.perempuan.TabIndex = 6;
            this.perempuan.TabStop = true;
            this.perempuan.Text = "Perempuan";
            this.perempuan.UseVisualStyleBackColor = true;
            this.perempuan.CheckedChanged += new System.EventHandler(this.perempuan_CheckedChanged);
            // 
            // laki
            // 
            this.laki.AutoSize = true;
            this.laki.Location = new System.Drawing.Point(49, 133);
            this.laki.Name = "laki";
            this.laki.Size = new System.Drawing.Size(68, 17);
            this.laki.TabIndex = 5;
            this.laki.TabStop = true;
            this.laki.Text = "Laki-Laki";
            this.laki.UseVisualStyleBackColor = true;
            this.laki.CheckedChanged += new System.EventHandler(this.laki_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cari Berdasarkan Jenis Kelamin";
            // 
            // tglAkhir
            // 
            this.tglAkhir.Location = new System.Drawing.Point(130, 64);
            this.tglAkhir.Name = "tglAkhir";
            this.tglAkhir.Size = new System.Drawing.Size(200, 20);
            this.tglAkhir.TabIndex = 3;
            this.tglAkhir.ValueChanged += new System.EventHandler(this.tglAkhir_ValueChanged);
            // 
            // tglAwal
            // 
            this.tglAwal.Location = new System.Drawing.Point(130, 26);
            this.tglAwal.Name = "tglAwal";
            this.tglAwal.Size = new System.Drawing.Size(200, 20);
            this.tglAwal.TabIndex = 2;
            this.tglAwal.ValueChanged += new System.EventHandler(this.tglAwal_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tanggal Akhir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tanggal Awal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tglAkhir;
        private System.Windows.Forms.DateTimePicker tglAwal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFormula;
        private System.Windows.Forms.Button btnParameter;
        private System.Windows.Forms.RadioButton perempuan;
        private System.Windows.Forms.RadioButton laki;
        private System.Windows.Forms.Label label4;
    }
}

