using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorFinal
{
    public class Yetkili : IKullanici
    {
        private string no;
        public Yetkili(string hesapNo)
        {
            this.no = hesapNo;
        }
        public bool HesapOku(string hesapNo)
        {
            return true;
        }

        public bool KimlikAccept(IVisitor visitor)
        {
          return  visitor.KimlikOkuyucuu(Yetki());
        }

        public string Yetki()
        {
            return "Yetkili";
        }
    }
}
