
namespace LatihanSelection2
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
            this.listHasil = new System.Windows.Forms.ListBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listHasil
            // 
            this.listHasil.FormattingEnabled = true;
            this.listHasil.ItemHeight = 15;
            this.listHasil.Location = new System.Drawing.Point(22, 73);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(191, 169);
            this.listHasil.TabIndex = 0;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(22, 25);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 1;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(113, 25);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(100, 23);
            this.txtNilai.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 269);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.listHasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.TextBox txtNilai;
    }
}

