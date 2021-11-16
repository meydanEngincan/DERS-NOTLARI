using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders6_Metotlar_1
{
    class Program
    {
        //static void Metin(string yazi)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine(yazi);
        //    }
        //}

        //static int Kare(int s1)
        //{
        //    int sonuc= s1*s1;
        //    return sonuc;
        //}

        //SORU: Kendisine gönderilen fiyat %18 KDV ekleyip geri döndüren metot, tip:double
        //static double Kdv(double s1)
        //{
        //    double sonuc = 1.18 * s1;
        //    return sonuc;
        //}


        //SORUYA EKLEME Kendisine gönderilen fiyatlara ürüne göre gıda ise %8 eğitim %5, diğer %18 kdv ekleyip geri döndürsün.

        //static double KDV2(double kdvsizFiyat,string kategori)
        //{
        //    if (kategori.ToLower() == "gıda")
        //        return kdvsizFiyat * 1.08;
        //    else if (kategori.ToLower() == "eğitim")
        //        return kdvsizFiyat * 1.05;
        //    else
        //        return kdvsizFiyat * 1.18;
        //}

        // Sayı girişini otomatikleştiren metodu yazınız.

        //static int SayiGirin(int sayi)
        //{
        //    return sayi;
        //}

        // Aldığı sayının faktoriyeli döndüren metot hesaplayınız.

        static int Faktoriyel()
        {
            int faktoriyel = 1;
           
            return faktoriyel;
        }




        static void Main(string[] args)
        {
            // Aldığı sayının faktoriyeli döndüren metot hesaplayınız.

            int toplam = Faktoriyel();
            Console.Write("Faktoriyel Hesabı İstediğiniz Sayıyı Giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;

            for (int i = 1; i <= sayi2; i++)
            {
                sonuc *= i;
                Console.Write("Yeni Sayı Giriniz: ");
            }
            Console.WriteLine(sonuc);

            // Sayı girişini otomatikleştiren metodu yazınız.

            //for (; ; )
            //{
            //    Console.WriteLine("Bir Sayı Giriniz: ");
            //    int calistir = SayiGirin(sayi: Convert.ToInt32(Console.ReadLine()));
            //    Console.WriteLine(calistir);
            //}


            //SORU: Kendisine gönderilen fiyat %18 KDV ekleyip geri döndüren metot, tip:double

            //Console.Write("Fiyat Giriniz: ");
            //double sonuc2 = Kdv(s1:Convert.ToDouble(Console.ReadLine()));
            //Console.WriteLine("Kdvli Fiyat=> " + sonuc2);

            //SORUYA EKLEME Kendisine gönderilen fiyatlara ürüne göre gıda ise %8 eğitim %5, diğer %18 kdv ekleyip geri döndürsün.

            //Console.Write("Kategori Giriniz: ");
            //string kategori = Console.ReadLine();
            //Console.Write("Fiyat giriniz: ");
            //double kdvsizfiyat = Convert.ToDouble(Console.ReadLine());

            //double hesaplama = KDV2(kdvsizfiyat, kategori);
            //Console.WriteLine(hesaplama);


            //SORU:Kendisine gönderilen int tipinde ki sayının karesini geri döndüren metodu yaz ve kullan.
            //Console.Write("Karesini Alınmasını İstediğiniz bi sayı giriniz: ");
            //int sonuc2 = Kare(s1: Convert.ToInt32(Console.ReadLine())); // Direk metodu çağıramıyoruz metodu ilk önce değişkene atıyoruz.
            //Console.WriteLine(sonuc2);

            //string mesaj = "Merhabalar";
            //Metin(mesaj);

            //***************************** METOTLAR/(FONKSİYON) *********************

            //static = program boyunca ramde olsun mu olmasın mı main için zorunlu diğerleri için değil.
            // void= geri değer döndürüp döndürmeyi sağlar void geri değer döndürmez. (string,int gibi değer alabilir)

            // Nesne üzerinden metodu çağırma.
            //Program p = new Program
            //p.merhabaDunya();


            // Static metodu doğrudan çağırdık.
            //merhabaDunya();

            //int toplam = Topla(10, 20);
            //Console.WriteLine(toplam);
        }

        //static void merhabaDunya()
        //{
        //    //Console.WriteLine("Merhaba Dünya !!!");



        //    // static olmadığı için main de çağıramıyoruz 2 yolu var ya voidin başına static ekle ya da main de Program classından nesne üret.
        //}


        // Kendisine gönderilen 2 sayıyı toplayıp döndüren metot.

        //static int Topla(int s1, int s2) // kendisine int değerinde s1 ve s1 değişkenlerini alacağını söylüyor.
        //{
        //    //Console.WriteLine($"s1 = {s1}");
        //    //Console.WriteLine($"s2 = {s2}");
        //      int toplam = s1+s2;
        //    //return toplam; // int olarak tanımladığımız için geriye değer döndürmeyiliz return da bunu sağlar.
        //}
    }
}
