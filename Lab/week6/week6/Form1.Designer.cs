
namespace week6
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSUM = new System.Windows.Forms.TextBox();
            this.txtAVG = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Lot For Element Array";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(211, 44);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 23);
            this.txtInput.TabIndex = 1;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(71, 105);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(293, 23);
            this.btnProses.TabIndex = 2;
            this.btnProses.Text = "Process";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(25, 144);
            this.txtArray.Multiline = true;
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(386, 186);
            this.txtArray.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result SUM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result Average";
            // 
            // txtSUM
            // 
            this.txtSUM.Location = new System.Drawing.Point(211, 347);
            this.txtSUM.Name = "txtSUM";
            this.txtSUM.Size = new System.Drawing.Size(145, 23);
            this.txtSUM.TabIndex = 6;
            // 
            // txtAVG
            // 
            this.txtAVG.Location = new System.Drawing.Point(211, 380);
            this.txtAVG.Name = "txtAVG";
            this.txtAVG.Size = new System.Drawing.Size(145, 23);
            this.txtAVG.TabIndex = 7;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(25, 423);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(386, 186);
            this.txtHasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 643);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtAVG);
            this.Controls.Add(this.txtSUM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSUM;
        private System.Windows.Forms.TextBox txtAVG;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

