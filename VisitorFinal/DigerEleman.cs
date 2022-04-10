using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorFinal
{
    public class DigerEleman : IKullanici
    {
        private string no;
        public DigerEleman(string hesapNo)
        {
            this.no = hesapNo;
        }
        public bool HesapOku(string hesapNo)
        {
            return true;
        }

        public bool KimlikAccept(IVisitor visitor)
        {
           return visitor.KimlikOkuyucuu(Yetki());
        }

       

        public string Yetki()
        {
            return "DigerEleman";
        }
    }
}
