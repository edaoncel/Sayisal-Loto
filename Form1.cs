using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayısal_loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[6];
            Random r = new Random();
            int indeks = 0;
            while (indeks < sayilar.Length) 
            {
                sayilar[indeks] = r.Next(1, 50);
                indeks++;
            }
            while(indeks<sayilar.Length)
            {
                int sayi = r.Next(1, 50);
                if (Array.IndexOf(sayilar, sayi) == -1)
                {
                    sayilar[indeks] = sayi;
                    indeks++;
                }
            }
            lblsayi1.Text = sayilar[0].ToString();
            lblsayi2.Text = sayilar[1].ToString();
            lblsayi3.Text = sayilar[2].ToString();
            lblsayi4.Text = sayilar[3].ToString();
            lblsayi5.Text = sayilar[4].ToString();
            lblsayi6.Text = sayilar[5].ToString();


        }
    }
}
