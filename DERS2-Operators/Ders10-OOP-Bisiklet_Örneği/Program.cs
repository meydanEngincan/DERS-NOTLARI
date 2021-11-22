using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders10_OOP_Bisiklet_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            /* BİSİKLET KİRALAMA YAZILIMI
             * Bisiklet (class)=ID,Marka,Model,JantBoyutu,VitesSayisi
             * Kullanici=ID,AdSoyad,Telefon
             * Kiralama= ID,BisikletID,KullaniciID,Sure,Ucret,BaslamaZamana,BitisZamana.DakikaUcret
             * METOTLAR= KiralamaBaslat() => BaşlamaZamanini tut.
             * KiralamaBitir(); => BitisZamanini tut.
             * UcretHesapla() => bitis ve başlangıc arasında ki farkı tutup ücreti hesaplayıp döndürecek(double)
             * BirimUcret: dakikası 25 kuruş. 
             Metotlar: 
            KiralamaBaslat() => BaşlamaZamanini tut. 

            KiralamaBitir() => BitisZamanini tut.
            
            UcretHesapla() => Bitis ve başlangıç arasındaki farkı tutup ücreti hesaplayıp döndürecek.(double)

            BilgiYaz() => Şu zamanda başladınız bu zamanda bitirdiniz.
            Toplam ... dakika kullandınız. Ödemen,z gereken ücret ... liradır.*/

            Kullanici kullan = new Kullanici();
            Bisiklet bsklt = new Bisiklet();
            Kiralama kira = new Kiralama();
            Kuafor kuafor = new Kuafor();

            //kullan._Adsoyad = "Engin Can MEYDAN";
            //kullan._Telefon = "0552 472 56 16";
            //bsklt._Marka = "Bianchi";

            //kira._KullaniciID= kullan;
            //kira._BisikletID = bsklt;

            //kira.KiralamaBaslat();
            //Thread.Sleep(10000);
            //kira.KiralamaBitir();
            //kira.BilgiYaz();
            kullan._Adsoyad = "Engin Can Meydan";
            kuafor.SacTrasiYap();
            kuafor.SaciYika();
            kuafor.CiltBakimiYap();
            kuafor.BilgiYaz();








        }
    }
}
