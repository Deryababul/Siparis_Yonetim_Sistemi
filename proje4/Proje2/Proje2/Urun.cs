using System;
using System.Collections.Generic;
using System.Text;

namespace Proje2
{
    public class Urun
    {

        public int UrunAdedi { get; set; }


        public int Fiyat { get; set; }

        public int Agirlik { get; set; }
        public string UrunAdi { get; set; }
      
        public override string ToString()
        {
            return this.UrunAdi + "\t\t" + this.Fiyat + "\t\t" + this.Agirlik + "\t\t" + this.UrunAdedi;
        }

        public void MiktarIcınFiyatAl()
        {

        }
        public void AgirlikAl()
        {

        }


       

       
          
}
}
