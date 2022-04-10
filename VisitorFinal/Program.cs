using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitor visitor = new KimlikOkuyucu();
            IKullanici kullanici = new DigerEleman("1234");
            bool sonuc=kullanici.KimlikAccept(visitor);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
