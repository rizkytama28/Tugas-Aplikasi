using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasTiga1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "NIM   : 20.11.3610";
            label2.Text = "Nama  : Rizkytama David Mulia Graha";
            label3.Text = "Kelas : 20-S1IF-05";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "NIM   : ";
            label2.Text = "Nama  : ";
            label3.Text = "Kelas : ";
        }
    }
}
