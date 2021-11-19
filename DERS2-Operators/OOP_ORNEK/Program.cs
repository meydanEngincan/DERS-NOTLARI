using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ORNEK
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            Ogretmen ogrt = new Ogretmen();
            ogr.ogrTCNo = 1234567890;
            ogr.ogrOkulNo = 123;
            ogr.ogrAd = "Engincan";
            ogr.ogrSoyad = "Meydan";
            
            ogr.OgrGetir();

            ogr.SinifOgretmeniDegis(ogrt);
            ogr.OgrGetir();



            
        }
    }
}
