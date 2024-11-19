using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egoista_isagi_yoichi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int en = int.Parse(textBox1.Text);
            int boy = int.Parse(textBox2.Text);
            Dikdortgen dikdortgen = new Dikdortgen(en, boy);
            int alani = dikdortgen.AlanHesapla();
            label3.Text = alani.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int en = int.Parse(textBox1.Text);
            int boy = int.Parse(textBox2.Text);
            Dikdortgen dikdortgen = new Dikdortgen(en, boy);
            int cevre = dikdortgen.CevreHesapla();
            label3.Text = cevre.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox3.Text);
            double sayi2 = double.Parse(textBox4.Text);
            İslemler islem = new İslemler(sayi1, sayi2);
            double topla = islem.Topla();
            label4.Text = topla.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox3.Text);
            double sayi2 = double.Parse(textBox4.Text);
            İslemler islem = new İslemler(sayi1, sayi2);
            double cıkar = islem.Cıkar();
            label4.Text = cıkar.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox3.Text);
            double sayi2 = double.Parse(textBox4.Text);
            İslemler islem = new İslemler(sayi1, sayi2);
            double carp = islem.Carp();
            label4.Text = carp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(textBox3.Text);
            double sayi2 = double.Parse(textBox4.Text);
            İslemler islem = new İslemler(sayi1, sayi2);
            double bolme = islem.Bolme();
            label4.Text = bolme.ToString();
        }
    }
}
