using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici kullanici2 = new Kullanici();
            Ilan ilan = new Ilan();
            
            kullanici2.ID = 1;
            kullanici2.AdSoyad = "Engin Can Meydan";
            kullanici2.Adress = "Mecidiyeköy";
            kullanici2.Telefon = "05524725616";
            kullanici2.BilgiYaz();
            Console.WriteLine("************************************");

            kullanici2.KullaniciDuzenle(1, "Engincan Meydan", "Mecidiyeköy", "5524725616");
            kullanici2.BilgiYaz();

            Console.WriteLine("*****************************************");

            ilan.ID = 1000;
            ilan.Tarih = DateTime.Now;
            ilan.Baslik = "Satılık Ev";
            ilan.SatilikMiKiralikMi = ilan.SatilikMiKiralikMi;
            ilan.Fiyat = 500000;

            ilan.kullanici = kullanici2;
            ilan.IlanBilgiYaz();
            Console.WriteLine("****************************");

           // ilan.SatilikMi(ilan.SatilikMi(ilan.SatilikMiKiralikMi));
            //ilan.IlanBilgiYaz();







        }
    }
}
