using System;
using System.Collections.Generic;
using System.Text;

namespace Proje2
{
    public class Musteri
    {
        public List<Urun> Urunler;
       
        
        public string MusteriAd { get; set; }
        public int MusteriSifre { get; set; }
        public string adres { get; set; }
        public Musteri()
        {
            Urunler = new List<Urun>();
        }
        public void SepeteEkle(int fiyat, int agirlik, string urunAdi,int urunAdedi)
        {
            Urunler.Add(new Urun { Fiyat = fiyat, Agirlik = agirlik, UrunAdi = urunAdi, UrunAdedi=urunAdedi}) ;
        }
        
        public void ÖdemeYap()
        {

        }
        public void SepettenCıkar()
        {
            sepetim sepetim1 = new sepetim();
            Musterimenu.m.Urunler.Clear();
           
        }
        public List<Urun> UrunleriListele()
        {
            return Urunler;
        }

    }
}

