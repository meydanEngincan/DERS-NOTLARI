using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace.InterfaceCalismaSorusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassTest nesne = new ClassTest();
            //nesne.Marka = "Honda";
            //nesne.Model = "Civic";
            //nesne.Fiyat = 200000;

            /*
              Kullanici= adSoyad,Eposta,Telefon, GetKullanici() => Bilgileri döndürsün. Liste ile döndürün  
              Sigorta=SigartoN,BitisTarihi
              Araba=enum YakitTipi,enum=VitesTipi, enum kasaTipi, float MotorHacmi,SigortaNesnesi(MetotileOluştur).
             * 
             * 
              IVasita:Marka,Model
              IIlan: IlanN,IlanTarihi,Satici(kullanici)
             */


            //Kullanici k = new Kullanici();
            //k.AdSoyad = "Engin Can MEYDAN";
            //k.Eposta = "meydanengincan@gmail.com";
            //k.Telefon = "5524725616";
            //foreach (var bilgi in k.GetKullanici())
            //{
            //    Console.WriteLine(bilgi);
            //}
            Araba a = new Araba();
            a.Marka = "Mercedes";
            a.Model = "SLK500";
            
        }
    }
}
