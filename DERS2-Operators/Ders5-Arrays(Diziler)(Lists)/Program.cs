using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Ders5_Arrays_Diziler__Lists_
{
    class Program
    {
        static void Main(string[] args)
        {
            // tip[] diziİsmi= new tip[boyut];

            //string[] isimler = new string[10] = 10 elemanlı bir string dizisi tanımladık


            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////indis numaraları dizilerde 0'dan başlar birer birer artar.
            //Console.WriteLine($"Rakamlar dizisinin ilk elemanı {rakamlar[0]}");
            //Console.WriteLine($"Rakamlar dizisinin 6. elemanı {rakamlar[5]}");

            //rakamlar[0] = 100;
            ////rakamlar.SetValue(100, 0); rakamlar dizinin 0. indeksini bu şekilde değiştirebiliriz ilk veri yeni değer 2. veri indeks numarası
            //Console.WriteLine(rakamlar[0]);

            //string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };

            //Console.WriteLine(sehirler);
            //for (int i = 0; i < sehirler.Length; i++)
            //{
            //    Console.WriteLine(sehirler[i]);
            //}
            // sehirler dizisinin hepsini getirir.


            //foreach (var sehir in sehirler) // sehirler dizisinde ki her bir veri için şunu yap.
            //{
            //    Console.WriteLine(sehir);
            //}
            //yukarıda ki işlemin aysını daha az kodla yapar.

            //ÖRNEK: kullanıcıdan alınan 10 adet isim bilgsini string bir diziye kaydedip daha sonra dizi elemanlarını ekrana yazdırın.


            //string[] isimler = new string[10];         
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.Write("İsim Giriniz : ");

            //    isimler[i] = Console.ReadLine();
            //}

            //foreach (var isim in isimler)
            //{
            //    Console.WriteLine(isim);
            //}

            // int[] puanlar = { 5, 20, 30, 40, 50, 60, 70,10 };
            //int indis10 = Array.IndexOf(puanlar, 10); // puanlar dizisinde ki 10 un indis numarasını bulur. // bir virgül daha koyarsak  kaçıncı indisden başlayacağını bildirirdik.

            //   object[] karisikDizi = new object[10]; // karışık dizi atamamızı sağlar.


            //örnek= 0-100 arasında rastgele 10 sayı üretip bir diziye atın ve son olarak diziyi ekrana yazdırın

            //int[] sayilar = new int[10];
            //Random rastGele = new Random(); // for dışında yap yoksa hata verir. rastgele sayı üretir

            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    sayilar[i] = rastGele.Next(0, 100); // ürettiğimiz sayıları sayılar dizisine ekler 0-100 arasında sayı üretir biz belirledik
            //}
            //Array.Sort(sayilar); // küçükten büyüye sıralar.
            //foreach (var sayi in sayilar) // foreach siz yazarsan hata verir.
            //{
            //    Console.WriteLine(sayi);
            //}

            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            //int indis100 = Array.IndexOf(puanlar, 10, 0);
            //int indis101 = Array.IndexOf(puanlar, 10, 1);
            //int indis102 = Array.IndexOf(puanlar, 10, 5);

            //Console.WriteLine(indis100);

            //int adet10 = puanlar.Count(sayi => sayi == 10); // her bir elemanı sayi değişkenine al. Koşul olarak sayi 10a eşitse.
            //Console.WriteLine($"dizide {adet10} tane 10 değeri var");


            //dizideki 10 değerlerinin index numaralarını ekrana yazdırın.For döngüsü ile
            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30 };
            //int startIndex = 0;
            //int adet10 = puanlar.Count(sayi => sayi == 10);  // kaç tane 10 değeri var ?

            //for (int i = 0 ; i < adet10; i++) //küçüktür adet 10 yazdığımız için sadece olanları yazıyor
            //{
            //    startIndex = Array.IndexOf(puanlar, 10, startIndex); // adet10 ların (linq da bulduğu sayılar) onların kaçıncı indexde olduğunu buluyor.
            //    Console.WriteLine($"10 değeri {startIndex}. indexte var.");
            //    startIndex += 1;
            //}


            /// DİZİDEN DİZİYE KOPYALAMA
            //int[] dizi1 = { 11, 23, 435, 456, 34, 67, 34, 56 };

            //int[] dizi2 = new int[10];

            //Array.Copy(dizi1, dizi2,dizi1.Length); // dizi1 i dizi 2 yi kopyalar dizi1 in uzunluğu kadar

            //Array.Copy(dizi1, 3, dizi2, 0, 5); // dizi1in 3. indisinden başla dizi 2nin 0. indisinden baslayarak ilk 5 elemanını doldur.


            // ****** ÇOK BOYUTLU DİZİLER *********

            //int[,] matris = new int[5, 5]; // 5*5 lik matris tanımlamıs olduk ilk parantezde ki virgül 2. boyutu simgeler
            //matris[0, 0] = 10;
            //Console.WriteLine(matris);
            //for (int i = 0; i < 5; i++) // satırlatı temsil eder
            //{
            //    for (int j = 0; j < 5; j++) // stünları temsil eder
            //    {
            //        Console.Write(matris[i,j]+" ");
            //    }
            //    Console.WriteLine();
            //}

            //Soru   2 0 0 0 2
            //       1 0 0 0 1
            //       2 0 0 0 2
            //       1 0 0 0 1
            //       2 0 0 0 2 ekrana yazdır

            //Analiz= satır indexi tek ise 0. ve 4. kolonlar 1 olur
            // Analiz 2 = satır indexti çift ise 0. ve 4. kolonlar 2 olur
            //int[,] matris = new int[5, 5];

            //for (int satir = 0; satir < 5; satir++)
            //{
            //    for (int stün = 0; stün < 5; stün++)
            //    {
            //        if (satir % 2 == 0 &&(stün==0||stün==4 ))
            //        {
            //            matris[satir, stün] = 2;
            //        }
            //        else if (satir %2==1 && (stün==0 || stün == 4))
            //        {
            //            matris[satir, stün] = 1;
            //        }
            //    }
            //}


            //for (int satır = 0; satır < 5; satır++)
            //{
            //    for (int stün = 0; stün < 5; stün++)
            //    {
            //        Console.Write(matris[satır, stün]+" ");
            //    }
            //    Console.WriteLine();
            //}



            // !!!!!!!!!!!!!!!!!!!! EVDE YAP!!!!!!!!!!!!!!!!

            // örn=// Soru   1 0 0 0 1
            //               0 1 0 1 0
            //               0 0 1 0 0
            //               0 1 0 1 0
            //               1 0 0 0 1 ekrana yazdır


            //analiz satır ve stün sayıları eşit olan yere 1 koy
            //satir ve stün index toplamı 4 ise 1 koy


            //örn= 2x4'luk bir dizi tanımlayın, bu dizinin her bir elemanı için klavyeden sayı alıp atayın

            //int[,] dizi = new int[2, 4];
            //// değer atadık.

            //for (int satir = 0; satir < 2; satir++)
            //{

            //    for (int stün = 0; stün < 4; stün++)
            //    {

            //        dizi[satir, stün] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //// yazdırdık.
            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int stün = 0; stün < 4; stün++)
            //    {
            //        Console.Write(dizi[satir, stün] + " ");
            //    }
            //    Console.WriteLine();
            //}


            // ********** Bu soruya Bak !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //örn= 2x4'luk bir dizi tanımlayın, her satırın son değeri hariç klavyeden al son değer öncekilerin toplamı olsun

            //int[,] dizi = new int[2, 4];

            //int sonKolon = 0;
            //for (int satir = 0; satir < 2; satir++)
            //{

            //    for (int stün = 0; stün < 3; stün++)
            //    {
            //        if (stün != 4)
            //        {
            //            int sayi = Convert.ToInt32(Console.ReadLine());
            //            dizi[satir, stün] = sayi;
            //            sonKolon += sayi;
            //        }
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        sonKolon += dizi[i, j];
            //    }
            //    dizi[i, 3] = sonKolon;
            //    sonKolon = 0;
            //}
            //for (int satir = 0; satir < 2; satir++)
            //{
            //    for (int stün = 0; stün < 4; stün++)
            //    {
            //        Console.Write(dizi[satir, stün] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //int[,] matris = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if ((i == j || i + j == 4))
            //        {
            //            matris[i, j] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(matris[i, j]+" ");                       
            //    }
            //    Console.WriteLine();
            //}


            // 3 BOYUTLU DİZİ

            Random rnd = new Random();
            int[,,] dizi3B = new int[2, 3, 3];

            for (int z = 0; z < 2; z++) // 3x3lük diziler
            {
                for (int i = 0; i < 3; i++) // satırlar 
                {
                    for (int j = 0; j < 3; j++) // Stünlar
                    {
                        dizi3B[z, i, j] = rnd.Next(1000);
                    }
                }
            }

            for (int z = 0; z < 2; z++) // 3x3lük diziler
            {
                for (int i = 0; i < 3; i++) // satırlar 
                {
                    for (int j = 0; j < 3; j++) // Stünlar
                    {
                        Console.Write(dizi3B[z, i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("****************");
                Console.WriteLine("****************");
            }
        }
    }
}
