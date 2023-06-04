using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje2
{
    public partial class sepetim : Form
    {

        public static int toplam;
        public sepetim()
        {
            InitializeComponent();
        }
        
        private void ödemebutton_Click(object sender, EventArgs e)
        {
           
            int normalFiyat = 0;       
           foreach(Urun urun in sepetimlistbox.Items)
            {
                normalFiyat += urun.Fiyat;
            }
            int normalAgirlik = 0;
            foreach (Urun urun in sepetimlistbox.Items)
            {
                normalAgirlik += urun.Agirlik;
            }

            ödeme ödeme1 = new ödeme();
            ödeme1.label6.Text = normalFiyat.ToString();
            ödeme1.label2.Text = normalAgirlik.ToString();
            if (sepetimlistbox.DataSource == null)
            {
                MessageBox.Show("Lütfen Ürünleri Listeleyiniz");
            }
            else
            {
                this.Hide();
                ödeme1.Show();
            }
        }
       
        public void FiyatToplam()
        {
            
            
        }
        public void sepetim_Load(object sender, EventArgs e)
        {

           


        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            System.Console.WriteLine(Musterimenu.m.Urunler);
            sepetimlistbox.DataSource = Musterimenu.m.UrunleriListele();


        }

        private void listeyitemizlebutton_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.SepettenCıkar();
            sepetimlistbox.DataSource = null;


        }

        private void alısverisedevametbutton_Click(object sender, EventArgs e)
        {
            Musterimenu musterimenu = new Musterimenu();
            musterimenu.Show();
            this.Hide();
        }
       


    }
}
