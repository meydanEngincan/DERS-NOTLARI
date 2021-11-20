using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ORNEK
{
    public class Derslik
    {
        public int derslikNo;
        public int ogrenciKapasite;
        public string derslikAd;
        public int derslikKat;
        public Ogretmen ogretmen;

        private bool OgretmenAtamaKontrol(Ogretmen ogretmen)  // parametre olarak öğrenci sınıfından nesne ile çalışır// öğretmen ataması kontrol sınıf-kapasite uygun mu
        {
            int ogrenciSayisi = ogretmen.ogretmenAd.Count();
            if (ogrenciSayisi <= this.ogrenciKapasite)
            {
                return true;
            }
            else
                return false;

        }


        public bool OgretmenAtama(Ogretmen ogretmen)
        {
            bool kontrol = this.OgretmenAtamaKontrol(ogretmen);

            if (kontrol == true)
            {
                this.ogretmen = ogretmen;
                Console.WriteLine($"{ogretmen} ataması başarıyla yapıldı.");
                return true;
            }
            else
            {
                Console.WriteLine("Malesef sınıf kapasitesi uygun değil.");
                return false;
            }
        }

        public void BilgiGetir()
        {
            Console.WriteLine(this.derslikAd);
            Console.WriteLine(this.derslikNo);
            Console.WriteLine(this.derslikKat);
            Console.WriteLine(this.ogrenciKapasite);
            Console.WriteLine(this.ogretmen.ogretmenAd + " " + this.ogretmen.ogretmenSoyad);
            Console.WriteLine();
        }

    }
}
