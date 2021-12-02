using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TugasDelegateEvent
{
    
    public partial class Hasil : Form
    {
        
      

        public Hasil()
        {
            
            InitializeComponent();
        }
        private void Tulis(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', '*', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            Output.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}" );
        }
        private void Menghitung(object sender, EventArgs e)
        {
            Calculator hitung = new Calculator();
            hitung.penghubung += Tulis;
            hitung.ShowDialog();
        }

        private void OutputHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
