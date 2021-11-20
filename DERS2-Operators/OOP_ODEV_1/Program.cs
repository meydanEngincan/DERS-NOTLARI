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
            Kullanici kullanici = new Kullanici();
            
            kullanici.ID = 1;
            kullanici.AdSoyad = "Engin Can Meydan";
            kullanici.Adress = "Mecidiyeköy";
            kullanici.Telefon = "05524725616";
            kullanici.BilgiYaz();
            Console.WriteLine("************************************");

            kullanici.KullaniciDuzenle(1, "Engincan Meydan", "Mecidiyeköy", "5524725616");
            kullanici.BilgiYaz();
        }
    }
}
