using System;
using System.Collections.Generic;
using System.Text;

namespace Proje2
{
    public class KrediKarti:Odeme
    {
        public int Numara { get; set; }
        public string Tip { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
     
        public override void Onayla() { }
        public override void OdemeYap()
        {
           
        }



    }
}
