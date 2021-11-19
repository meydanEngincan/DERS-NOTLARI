using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders9_OOP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba arb = new Araba();
            //arb.Marka = "BMW";
            //arb.Model = "x5";
            //arb.BilgiYaz();

            //Araba arb2 = new Araba();
            //arb2.Marka = "MERCEDES";
            //arb2.Model = "A180";
            //arb2.BilgiYaz();

            //Araba arb3 = new Araba(123,"VOLVO","S40");
            //arb3.BilgiYaz();

            Ogrenci ogr = new Ogrenci(123456789,123,"Engin","Meydan","Mehmet DEMİR");
            //ogr.okulNo = 123;
            //ogr.tcKimlikNo = 123456789;
            //ogr.ad = "Engin Can";
            //ogr.soyad = "Meydan";
            //ogr.sinifOgretmeni = "Mehmet DEMİR";
            ogr.OgrenciBilgi();
            ogr.SinifOgretmeniDegistir("sdasada");
            ogr.OgrenciBilgi();

        }
    }

    class Araba
    {
        // Sınıfın özellikleri: property, Fiels
        int ID;
        public string Marka;
        public String Model;

        // SINIF METOTLARI

        public void BilgiYaz()
        {
            Console.WriteLine(this.Marka); // this anahtar kelimesi nesneyi(sınıfı) temsil eder.
            Console.WriteLine(this.Model);
        }

        // YAPICI METOTLAR: CONSTRUCTOR
        // **** METOT ADI İLE CONSTRUCTER METOT ADI AYNI OLMAK ZORUNDA!!!

        public Araba()
        {
            Console.WriteLine("Yapıcı Metot Çalıştı");
        }

        public Araba(int id, string marka,string model)
        {
            this.ID = id;
            this.Marka = marka;
            this.Model = model;
        }

        // YIKICI METOTLAR

        ~Araba()
        {
            
            Console.WriteLine("Yıkıcı Metot Çalıştı");
        }
    }

    // ÖRNEK öğrenci sınıfının aşağıdaki özellik ve metotları ile tanımlayınız.
    //PROP=tcKimlikNo,okulNo,ad,soyad,SinifOgretmeni
    // Methods= SinifOgretmeniDegistir(string ogrtmn)
    //Methods= Bilgiyaz(), öğrencinin tüm bilgilerini ekrana yazdırsın
    // Parametreli yapıcı metot ekleyin.

    class Ogrenci
    {
        public long tcKimlikNo;
        public int okulNo;
        public string ad;
        public string soyad;
        public string sinifOgretmeni;

        public void SinifOgretmeniDegistir(string ogretmn)
        {
            
            this.sinifOgretmeni = ogretmn;
        }

        public void OgrenciBilgi()
        {
            Console.WriteLine($"Öğrenci TC : {tcKimlikNo}, Öğrenci No : {okulNo}, Öğrenci Ad Soyad :{ad} {soyad}, Sınıf Öğretmeni : {sinifOgretmeni}");
            //Console.WriteLine(this.tcKimlikNo);
            //Console.WriteLine(this.okulNo);
            //Console.WriteLine(this.ad);
            //Console.WriteLine(this.soyad);
            //Console.WriteLine(this.sinifOgretmeni);
        }
        public Ogrenci(long tcKimlikNo, int okulNo, string ad, string soyad, string sinifOgretmeni)
        {
            this.tcKimlikNo = tcKimlikNo;
            this.okulNo = okulNo;
            this.ad = ad;
            this.soyad = soyad;
            this.sinifOgretmeni = sinifOgretmeni;
        }
    }


}
