using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP2_Encapsulation
{
    class User                           //// KAPSÜLLEME NCAPSÜLASYON ///////
    {
        // ERİŞİM BELİRTEÇLERİ //
        // PUBLİC = her yerden ulaşılabilir.
        // PRİVATE = sadece sınıf içinden erişelebilir
        //PROTECTED= sınıf içerisinden ve kalıtım yolu ile mriras alan alt sınıflardan erişilebilir.

        //private int ID;
        //private string AdSoyad; // AÇIK YÖNTEM İLE KAPSULLEME YAPTIK:
        //private string Adres;   // KISA YÖNTEM İLE KAPSULLEME YAPTIK.
        //private string Telefon;
        //internal int DogumYili;

        //// her prop için aynı metot tanımlanır.
        //public void setAdSoyad(string adsoyad)
        //{
        //    if(!(String.IsNullOrEmpty(adsoyad)) && !(String.IsNullOrWhiteSpace(adsoyad)))
        //    {
        //        this.AdSoyad = adsoyad;
        //    }  
        //    else
        //    {
        //        Console.WriteLine("Boşluklardan oluşan ya da tamamen boş değer atayamazsın");
        //    }
        //}
        //public string getAdSoyad()
        //{
        //    return this.AdSoyad;
        //}

        //private string _Telefon;
        

       
    }
}
