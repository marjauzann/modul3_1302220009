using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302220009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int angka = 0;
        int sementara = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  ditambah dengan cara var sementara dimasukkan ke var angka lalu hapus isi sementara
            angka = angka + sementara;
            sementara = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // tambah angka 0, tambah 1 digit dengan kali 10
            sementara = sementara * 10;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ditambah dengan cara var sementara dimasukkan ke var angka lalu hapus isi sementara, output isi angka
            angka = angka + sementara;
            label1.Text = angka.ToString();
            sementara = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // tambah angka 1, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 1;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // tambah angka 2, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 2;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // tambah angka 3, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 3;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // tambah angka 4, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 4;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // tambah angka 5, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 5;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // tambah angka 6, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 6;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // tambah angka 7, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 7;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // tambah angka 8, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 8;
            // output ke layar
            label1.Text = sementara.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // tambah angka 9, tambah 1 digit dengan kali 10
            sementara = sementara * 10 + 9;
            // output ke layar
            label1.Text = sementara.ToString();
        }
    }
}