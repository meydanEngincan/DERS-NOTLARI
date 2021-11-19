using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ORNEK
{
    class Ogrenci
    {
        public long ogrTCNo;
        public int ogrOkulNo;
        public string ogrAd;
        public string ogrSoyad;
        public Ogretmen ogretmen;

        public Ogrenci()
        {

        }
        public Ogrenci(long ogrTCNo, int ogrOkulNo, string ogrAd, string ogrSoyad,Ogretmen ogrOgretmen)
        {
            this.ogrTCNo = ogrTCNo;
            this.ogrOkulNo = ogrOkulNo;
            this.ogrAd = ogrAd;
            this.ogrSoyad = ogrSoyad;
            this.ogretmen = ogretmen;
        }

        public void OgrGetir()
        {
            Console.WriteLine($" Öğrenci TC : {ogrTCNo}, Öğrenci Numarası: {ogrOkulNo}, Öğrenci Adı: {ogrAd}, Öğrenci Soyad {ogrSoyad}, Öğrenci Öğretmeni: {ogretmen}");
        }

        public void SinifOgretmeniDegis(Ogretmen ogrOgretmen)
        {
            this.ogretmen = ogretmen;
        }

        public void BilgileriYaz()
        {
            Console.WriteLine(this.ogrTCNo);
            Console.WriteLine(this.ogrOkulNo);
            Console.WriteLine(this.ogrAd);
            Console.WriteLine(this.ogrSoyad);
            Console.WriteLine(this.ogretmen.ogretmenAd + " "+ this.ogretmen.ogretmenSoyad);
        }
        
    }
}
