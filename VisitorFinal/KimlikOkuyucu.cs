using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorFinal
{
    public class KimlikOkuyucu : IVisitor
    {
       
        public bool KimlikOkuyucuu(string yetki)
        {
            if (yetki == "Yetkili")
            {
                return true;
            }
            else if(yetki=="DigerEleman")
            {
                return false;
            }
            return false;
        }
    }
}
