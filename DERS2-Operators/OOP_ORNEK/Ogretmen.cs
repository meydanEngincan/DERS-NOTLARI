using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ORNEK
{
    public class Ogretmen
    {
        public int ogretmenID;
        public string ogretmenAd;
        public string ogretmenSoyad;
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
       // public List<Ogrenci> ogren;
        public Ogretmen()
        {
            this.ogrenciler = new List<Ogrenci>(); // Liste oluşturulur.
        }
        public void BilgiYaz()
        {
            Console.WriteLine(this.ogretmenAd);
            Console.WriteLine(this.ogretmenSoyad);
        }

        public void OgrenciListe()
        {
            Console.WriteLine($"{this.ogretmenAd} {this.ogretmenSoyad} öğretmenimizin öğrencileri");
            foreach (var item in this.ogrenciler)
            {
                Console.WriteLine(item.ogrAd + " "+ item.ogrSoyad); 
            }
            Console.WriteLine("***************************************");
        }
    }
}
