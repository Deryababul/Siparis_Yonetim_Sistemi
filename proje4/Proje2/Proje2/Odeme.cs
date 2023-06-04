using System;
using System.Collections.Generic;
using System.Text;

namespace Proje2
{
    public abstract class Odeme
    {
        public int Miktar { get; set; }
        public abstract void OdemeYap();
      
        public virtual void Onayla() { }
    }
}
