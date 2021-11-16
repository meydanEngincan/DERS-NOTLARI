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

        //static int Faktoriyel()
        //{
            
        //}

        //SORU parametro olarak aldığı sayının asal olup olmadığını döndüren metod. asal ise true değil ise false çözün


        // SORU:0-100 arası  Rastgele ürettiği 10 sayıyı int tipinde  dizi olarak döndüren metodu tanımlayınız.

        //static int[] Random10()
        //{
        //    int[] sayiDizisi = new int[10]; // boş dizi tanımladık.
        //    Random r = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        sayiDizisi[i] = r.Next(0, 100); // üretilen sayıları diziye doldurur
        //    }
        //    return sayiDizisi;
        //}

        //SORU: Kendisine parametre olarak gönderilen dizinin elemanlarını ekrana yazdıran metodu tanımla.

        //static void diziYaz(int[] dizi)
        //{
        //    foreach (var eleman in dizi)
        //    {
        //        Console.Write(eleman+" ");
        //    }
        //    Console.WriteLine();
        //}

        //SORU: kendisine gönderilen dizideki tek sayıları yine dizi ile döndüren metodu yazınız.



        static void Main(string[] args)
        {
            //SORU: kendisine gönderilen dizideki tek sayıları yine dizi ile döndüren metodu yazınız.



            //SORU: Kendisine parametre olarak gönderilen dizinin elemanlarını ekrana yazdıran metodu tanımla.
            //int[] sayilar = { 10, 3, 5, 2, 55 };
            //diziYaz(sayilar);

            //int[] rastgele10 = Random10();
            //foreach (var item in rastgele10)
            //{
            //    Console.WriteLine(item);
            //}
            // Aldığı sayının faktoriyeli döndüren metot hesaplayınız.

            //int toplam = Faktoriyel();
            //Console.Write("Faktoriyel Hesabı İstediğiniz Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 1; i <= sayi2; i++)
            //{
            //    sonuc *= i;
            //    Console.Write("Yeni Sayı Giriniz: ");
            //}
            //Console.WriteLine(sonuc);

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

            //Soru Parametre olarak aldığı 2 adet sayıdan büyük olan sayıyı döndüreni metot olarak yazın




            //int büyük = BuyukDondur(10,15);
            //Console.WriteLine(büyük);

            //List<int> sayilarım = new List<int>() { 2, 3, 4, 5 };
            //List<int> karelerim = listeKare(sayilarım);

            //int boyut = sayilarım.Count();

            //foreach (var item in KullaniciSayi())
            //{
            //    Console.Write(item+ " ");
            //}

            // (enküçük,enbüyük,sayıadedi)=> en küçük ile en büyük sayı arasında ki fark adedince rastgele sayı üretsin bir listeye atıp döndürsün

            //List<int> sayiListesi= tahminOyunu(5, 25, 7); // 5 ile 25 arasında 7 sayı üretir.
            //foreach (var item in sayiListesi)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> kelimelerim = new List<string>() { "araba", "hızla", "yanımdan", "geçti" };
            Kelimeler(kelimelerim);

            foreach (var item in kelimelerim)
            {
                Console.Write(item+", ");
            }
            //Console.WriteLine(kelimelerim);
            

        }

        //static void merhabaDunya()
        //{
        //    //Console.WriteLine("Merhaba Dünya !!!");



        //    // static olmadığı için main de çağıramıyoruz 2 yolu var ya voidin başına static ekle ya da main de Program classından nesne üret.

        // Kendisine gönderilen 2 sayıyı toplayıp döndüren metot.

        //static int Topla(int s1, int s2) // kendisine int değerinde s1 ve s1 değişkenlerini alacağını söylüyor.
        //{
        //    //Console.WriteLine($"s1 = {s1}");
        //    //Console.WriteLine($"s2 = {s2}");
        //      int toplam = s1+s2;
        //    //return toplam; // int olarak tanımladığımız için geriye değer döndürmeyiliz return da bunu sağlar.
        //}

        //Soru Parametre olarak aldığı 2 adet sayıdan büyük olan sayıyı döndüreni metot olarak yazın

        //metodu oluşturduk.
        //static int BuyukDondur(int s1, int s2)
        //{

        //    if (s1 > s2)
        //    {
        //        return s1;
        //    }
        //    else if (s1 < s2)
        //    {
        //        return s2;
        //    }
        //    else
        //    {
        //        return s1;
        //    }   

        //}

        //Soru Parametre olarak aldığı 3 adet sayıdan en büyük olanı döndüren metodu yazınız

        // List tipinde aldığı 10 adet sayının karelerini list tipinde döndüren metodu yazınız(2 tane list olacak)

        //static List<int> listeKare(List<int> sayilar)
        //{
        //    List<int> kareler = new List<int>();
        //    int boyut = sayilar.Count();
        //    for (int i = 0; i < boyut; i++)
        //    {
        //        kareler.Add( sayilar[i] * sayilar[i]);
        //    }
        //    return kareler;
        //}

        // Liste sorusu: Kullanıcıdan 10 sayı alıp liste ile döndüren metodu yazınız.

        //static List<int> KullaniciSayi() // ilk etap döndürcemiz parantez içi alacağımız ne döndürüyosak o tipte değişkene ihtiyacım var
        // {
        //     List<int> sayilar = new List<int>();
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Console.Write($"{i}. sayı= ");
        //         int sayi = Convert.ToInt32(Console.ReadLine());
        //         sayilar.Add(sayi);
        //     }
        //     return sayilar;
        // }       

        // (enküçük,enbüyük,sayıadedi)=> en küçük ile en büyük sayı arasında ki fark adedince rastgele sayı üretsin bir listeye atıp döndürsün

        //static List<int> tahminOyunu(int enKucuk, int enBuyuk, int sayiAdedi)
        //{
        //    Random rnd = new Random();
        //    List<int> sayilar = new List<int>();

        //    for (int i = 0; i < sayiAdedi; i++)
        //    {
        //        int sayi = rnd.Next(enKucuk, enBuyuk);
        //        sayilar.Add(sayi);
        //    }
        //    return sayilar;
        //}

        // Kendisine liste olarak gönderilen stringleri tek bir string olarak birleştirip döndüren metot yazınız.
        // List<string>=> Metotda parametre olarak gönder
        // String olarak al

        static string Kelimeler(List<string> liste)
        {
            string tekKelime="";
            int boyut = liste.Count();
            foreach (var item in liste)
            {
                tekKelime += item + " ";
            }
            return tekKelime;
        }


        
    }
}
