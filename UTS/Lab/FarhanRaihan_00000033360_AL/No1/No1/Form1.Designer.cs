
namespace No1
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSubs = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKet = new System.Windows.Forms.Label();
            this.btnHasil = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banyak Angka";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(157, 25);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(181, 23);
            this.txtLength.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(36, 70);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 47);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSubs
            // 
            this.btnSubs.Location = new System.Drawing.Point(126, 69);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(75, 48);
            this.btnSubs.TabIndex = 3;
            this.btnSubs.Text = "-";
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(217, 70);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 47);
            this.btnDiv.TabIndex = 4;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kalkulator";
            // 
            // lblKet
            // 
            this.lblKet.AutoSize = true;
            this.lblKet.Location = new System.Drawing.Point(107, 148);
            this.lblKet.Name = "lblKet";
            this.lblKet.Size = new System.Drawing.Size(32, 15);
            this.lblKet.TabIndex = 6;
            this.lblKet.Text = "_____";
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(173, 144);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(75, 23);
            this.btnHasil.TabIndex = 7;
            this.btnHasil.Text = "Hasil";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(263, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(36, 191);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(302, 226);
            this.txtShow.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.lblKet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKet;
        private System.Windows.Forms.Button btnHasil;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label3;
    }
}

