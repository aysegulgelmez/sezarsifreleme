using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sezarödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
           //sayi = Convert.ToInt32(Console.ReadLine());
            string veri = "";
            veri = metin.Text;
            char[] karakter = veri.ToCharArray();
                foreach(char eleman in karakter)
            {
                sifree.Text += Convert.ToChar(eleman + sayi ).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Int32.Parse(textBox1.Text);
            string sifre = "";
            sifre = sifree.Text;
            char[] karakter = sifre.ToCharArray();
            foreach (char eleman in karakter)
            {
                metin.Text += Convert.ToChar(eleman - sayi).ToString();
            }
        }

       
    }
}
