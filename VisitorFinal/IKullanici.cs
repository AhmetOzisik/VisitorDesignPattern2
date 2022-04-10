using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorFinal
{
    public interface IKullanici
    {
        string Yetki();
        bool HesapOku(string hesapNo);
        bool KimlikAccept(IVisitor visitor);
    }
}
