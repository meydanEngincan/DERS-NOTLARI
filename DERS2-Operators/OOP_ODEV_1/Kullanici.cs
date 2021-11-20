using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV_1
{
    class Kullanici
    {
       

        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }

        //public Kullanici( int ID,string AdSoyad, string Adress, string Telefon)
        //{
        //    this.ID = ID;
        //    this.AdSoyad = AdSoyad;
        //    this.Adress = Adress;
        //    this.Telefon = Telefon;
        //}

        public void KullaniciDuzenle(int ıd,string adsoyad,string adress,string telefon)
        {
            if (this.ID == ıd)
            {
                this.AdSoyad = adsoyad;
                this.Adress = adress;
                this.Telefon = telefon;
            }
            else
            {
                Console.WriteLine("Hatalı ID girdiniz.");
            }
        }

        public void BilgiYaz()
        {
            Console.WriteLine(this.ID);
            Console.WriteLine(this.AdSoyad);
            Console.WriteLine(this.Adress);
            Console.WriteLine(this.Telefon);

        }


    }
}
