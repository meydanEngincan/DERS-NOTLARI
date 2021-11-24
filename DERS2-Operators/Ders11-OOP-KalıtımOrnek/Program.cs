using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KalıtımOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kulanici: ID, AdSoyad,Telefon
             * ILAN:IlanNo,Baslik,IlanTarihi,Kategori,Fiyat,Satici(kullanıcıSınıfından), Metotlar=BilgiYaz(),IndırımYap(yuzde20)
             * Bilgisayar:Ilan => Marka,Islemci,Bellek,HDD,SSD,EthernetVarMi,WifiVarMi
             * Dizustu:Bilgisayar => EkranBoyutu,Agirlik,BilgiYaz metodu yeniden tanımlanıcak
             * Masaustu:Bilgisayar => MonitorVarMi, KasaTipi BilgiTaz() metodu yeniden tanımlanacak.
             */

            Kullanici Shakir = new Kullanici();
            Shakir.KullaniciAdSoyad = "Şakir Demir";
            Shakir._KullaniciTelefon = "0500000000";
           // TEST AMAÇLI TANIMLANDI.
           Ilan ilan = new Ilan();
            //ilan._IlanID = 123123;
            ilan.Fiyat = 100;
            ilan.IlanBaslik = "Şok İndirimler.";
            //ilan.Il = DateTime.Now;
            ilan._Satici = Shakir;
            ilan.BilgiYaz();
            ilan.IndırımYap(50);
            //Console.WriteLine(ilan.);

            Dizustu dzb = new Dizustu();
            dzb._Satici = Shakir;
            dzb.kategori = Kategori.Laptop;
            //dzb._IlanID = 1;
            //dzb. = DateTime.Now;
            dzb.IlanBaslik = "Sağlam Disüstü Bilgisayar";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 7";
            dzb.Fiyat = 10000.0D;
            dzb.Marka = "lenovo";
            dzb.Bellek = "32GB";
            dzb.HDD = "0";
            dzb.SSD = "1024";
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.EkranBoyutu = "14'";

            dzb.BilgiYaz();
            dzb.IndırımYap(10);

            Masaustu mst = new Masaustu();

            mst._Satici = Shakir;
            mst.kategori = Kategori.Laptop;
           // mst.IlanN = 1;
           // mst.IlanTarihi = DateTime.Now;
            mst.IlanBaslik = "Sağlam Masaüstü Bilgisayar";
            mst.Islemci = "AMD Ryzen 7";
            mst.Fiyat = 10000.0D;
            mst.Marka = "lenovo";
            mst.Bellek = "32GB";
            mst.HDD = "0";
            mst.SSD = "1024";
            mst.EthernetVarMi = true;
            mst.WifiVarMi = true;
            mst.MonitorVarMi = false;
            mst.KasaTipi = KasaTipi.Dikey;

            mst.BilgiYaz();

        }
    }
}
