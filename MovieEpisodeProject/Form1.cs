using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieEpisodeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void yazdir()
        {
            label1.Text = "Merhaba";
            label2.Text = "Selam";
            label3.Text = "Hi";
        }
        int carp()
        {
            int sayi1 = 10;
            int sayi2 = 25;
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            yazdir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text=carp().ToString();
        }
        int hesapla(int s1, int s2, int s3) {
            int sonuc = s1 * s2 * s3;
            return sonuc;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text=hesapla(4,5,6).ToString();
        }
    }
}
