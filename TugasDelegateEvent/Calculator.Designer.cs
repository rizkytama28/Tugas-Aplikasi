
namespace TugasDelegateEvent
{
    partial class Calculator
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
            this.OperasiPilihan = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.ProsesNilai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // OperasiPilihan
            // 
            this.OperasiPilihan.FormattingEnabled = true;
            this.OperasiPilihan.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.OperasiPilihan.Location = new System.Drawing.Point(65, 29);
            this.OperasiPilihan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OperasiPilihan.Name = "OperasiPilihan";
            this.OperasiPilihan.Size = new System.Drawing.Size(92, 21);
            this.OperasiPilihan.TabIndex = 3;
            this.OperasiPilihan.SelectedIndexChanged += new System.EventHandler(this.OperasiPilihan_SelectedIndexChanged);
            // 
            // NilaiA
            // 
            this.NilaiA.AccessibleName = "NilaiA";
            this.NilaiA.Location = new System.Drawing.Point(65, 55);
            this.NilaiA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(92, 20);
            this.NilaiA.TabIndex = 4;
            this.NilaiA.TextChanged += new System.EventHandler(this.NilaiA_TextChanged);
            // 
            // NilaiB
            // 
            this.NilaiB.AccessibleName = "NilaiB";
            this.NilaiB.Location = new System.Drawing.Point(65, 78);
            this.NilaiB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(92, 20);
            this.NilaiB.TabIndex = 5;
            this.NilaiB.TextChanged += new System.EventHandler(this.NilaiB_TextChanged);
            // 
            // ProsesNilai
            // 
            this.ProsesNilai.AccessibleName = "ProsesNilai";
            this.ProsesNilai.Location = new System.Drawing.Point(100, 111);
            this.ProsesNilai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProsesNilai.Name = "ProsesNilai";
            this.ProsesNilai.Size = new System.Drawing.Size(56, 19);
            this.ProsesNilai.TabIndex = 6;
            this.ProsesNilai.Text = "Proses";
            this.ProsesNilai.UseVisualStyleBackColor = true;
            this.ProsesNilai.Click += new System.EventHandler(this.Click_Proses);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 142);
            this.Controls.Add(this.ProsesNilai);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.OperasiPilihan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OperasiPilihan;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Button ProsesNilai;
    }
}