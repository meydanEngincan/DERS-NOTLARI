using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV_1
{
    class Ilan
    {
       

        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public string Baslik { get; set; }
        public bool SatilikMiKiralikMi { get; set; }
        public long Fiyat { get; set; }
        public Kullanici kullanici { get; set; }  // Classdan nesne ürettik.

        public Ilan()
        {

        }
        public Ilan(int ıD, DateTime tarih, string baslik, bool satilikMiKiralikMi, long fiyat, Kullanici kullanici)
        {
            ID = ıD;
            Tarih = tarih;
            Baslik = baslik;
            SatilikMiKiralikMi = satilikMiKiralikMi;
            Fiyat = fiyat;
            this.kullanici = kullanici;
        }

        public void IlanDuzenle(int ıd,DateTime tarih,string baslik, bool satilikmikiralikmi,long fiyat, Kullanici kullanici)
        {
            if (this.ID == ıd)
            {
                this.Tarih = tarih;
                this.Baslik = baslik;
                this.SatilikMiKiralikMi = satilikmikiralikmi;
                this.Fiyat = fiyat;
                this.kullanici = kullanici;
            }
            else
            {
                Console.WriteLine("Girdiğiniz ID'de bir ilan bulunmamaktadır.");
            }

        }

        //private bool SatilikMiKontrol(bool SatilikMiKiralikMi)
        //{
        //    bool satilikMi = SatilikMiKiralikMi;

        //    if (satilikMi==true)
        //    {
        //        //this.SatilikMiKiralikMi = SatilikMiKiralikMi;
        //        //Console.WriteLine($"{SatilikMiKiralikMi}: Satılık.");
        //        return true;
                
                
        //    }
        //    else
        //    {
        //        //Console.WriteLine($"{SatilikMiKiralikMi}: Kiralık.");
        //        return false;
        //    }

        //}

        public bool SatilikMi(bool kontrol)
        {
            bool satilik = kontrol;
            if (satilik==true)
            {
                this.SatilikMiKiralikMi = kontrol;
                Console.WriteLine("Satılık");
                return true;
            }
            else
            {
                Console.WriteLine($"{this.SatilikMiKiralikMi}= Kiralık");
                return false;
            }
        }
        public void IlanBilgiYaz()
        {

            Console.WriteLine($" ID: {ID} Tarih: {Tarih} Başlık: {Baslik} Durumu: {SatilikMi(SatilikMiKiralikMi)} Fiyatı: {Fiyat} İlan Sahibi {kullanici.AdSoyad}");
            //Console.WriteLine(this.ID);
            //Console.WriteLine(this.Tarih);
            //Console.WriteLine(this.Baslik);
            //Console.WriteLine(this.SatilikMiKiralikMi);
            //Console.WriteLine(this.Fiyat);
            //Console.WriteLine(this.kullanici);
        }

    }

    
}
