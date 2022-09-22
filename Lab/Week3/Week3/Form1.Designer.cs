
namespace Week3
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
            this.btnPersegi = new System.Windows.Forms.Button();
            this.btnJajarGenjang = new System.Windows.Forms.Button();
            this.btnSegitiga = new System.Windows.Forms.Button();
            this.lblAngka1 = new System.Windows.Forms.Label();
            this.lblAngka2 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersegi
            // 
            this.btnPersegi.Location = new System.Drawing.Point(23, 23);
            this.btnPersegi.Name = "btnPersegi";
            this.btnPersegi.Size = new System.Drawing.Size(75, 59);
            this.btnPersegi.TabIndex = 0;
            this.btnPersegi.Text = "Persegi Panjang";
            this.btnPersegi.UseVisualStyleBackColor = true;
            this.btnPersegi.Click += new System.EventHandler(this.btnPersegi_Click);
            // 
            // btnJajarGenjang
            // 
            this.btnJajarGenjang.Location = new System.Drawing.Point(23, 128);
            this.btnJajarGenjang.Name = "btnJajarGenjang";
            this.btnJajarGenjang.Size = new System.Drawing.Size(75, 61);
            this.btnJajarGenjang.TabIndex = 1;
            this.btnJajarGenjang.Text = "Jajar Genjang";
            this.btnJajarGenjang.UseVisualStyleBackColor = true;
            this.btnJajarGenjang.Click += new System.EventHandler(this.btnJajarGenjang_Click);
            // 
            // btnSegitiga
            // 
            this.btnSegitiga.Location = new System.Drawing.Point(23, 229);
            this.btnSegitiga.Name = "btnSegitiga";
            this.btnSegitiga.Size = new System.Drawing.Size(75, 23);
            this.btnSegitiga.TabIndex = 2;
            this.btnSegitiga.Text = "Segitiga";
            this.btnSegitiga.UseVisualStyleBackColor = true;
            this.btnSegitiga.Click += new System.EventHandler(this.btnSegitiga_Click);
            // 
            // lblAngka1
            // 
            this.lblAngka1.AutoSize = true;
            this.lblAngka1.Location = new System.Drawing.Point(189, 23);
            this.lblAngka1.Name = "lblAngka1";
            this.lblAngka1.Size = new System.Drawing.Size(50, 15);
            this.lblAngka1.TabIndex = 3;
            this.lblAngka1.Text = "Angka 1";
            // 
            // lblAngka2
            // 
            this.lblAngka2.AutoSize = true;
            this.lblAngka2.Location = new System.Drawing.Point(189, 79);
            this.lblAngka2.Name = "lblAngka2";
            this.lblAngka2.Size = new System.Drawing.Size(50, 15);
            this.lblAngka2.TabIndex = 4;
            this.lblAngka2.Text = "Angka 2";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(189, 245);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(33, 15);
            this.lblHasil.TabIndex = 5;
            this.lblHasil.Text = "Hasil";
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(265, 23);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(131, 23);
            this.txtAngka1.TabIndex = 6;
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(265, 70);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(131, 23);
            this.txtAngka2.TabIndex = 7;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(265, 245);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(131, 23);
            this.txtHasil.TabIndex = 8;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(189, 147);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 9;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(321, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 298);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.lblAngka2);
            this.Controls.Add(this.lblAngka1);
            this.Controls.Add(this.btnSegitiga);
            this.Controls.Add(this.btnJajarGenjang);
            this.Controls.Add(this.btnPersegi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersegi;
        private System.Windows.Forms.Button btnJajarGenjang;
        private System.Windows.Forms.Button btnSegitiga;
        private System.Windows.Forms.Label lblAngka1;
        private System.Windows.Forms.Label lblAngka2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnCancel;
    }
}

