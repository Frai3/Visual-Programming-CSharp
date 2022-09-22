
namespace Week14
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
            this.btnDatabase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTxt = new System.Windows.Forms.Button();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(36, 25);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(169, 23);
            this.btnDatabase.TabIndex = 0;
            this.btnDatabase.Text = "Get Data from Database";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 189);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnTxt
            // 
            this.btnTxt.Location = new System.Drawing.Point(36, 260);
            this.btnTxt.Name = "btnTxt";
            this.btnTxt.Size = new System.Drawing.Size(141, 23);
            this.btnTxt.TabIndex = 2;
            this.btnTxt.Text = "Generate to txt file";
            this.btnTxt.UseVisualStyleBackColor = true;
            this.btnTxt.Click += new System.EventHandler(this.btnTxt_Click);
            // 
            // btnCR
            // 
            this.btnCR.Location = new System.Drawing.Point(183, 260);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(145, 23);
            this.btnCR.TabIndex = 3;
            this.btnCR.Text = "Calling crystal report";
            this.btnCR.UseVisualStyleBackColor = true;
            this.btnCR.Click += new System.EventHandler(this.btnCR_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(144, 302);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 4;
            this.btnForm2.Text = "Form 2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 347);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnCR);
            this.Controls.Add(this.btnTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDatabase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTxt;
        private System.Windows.Forms.Button btnCR;
        private System.Windows.Forms.Button btnForm2;
    }
}

