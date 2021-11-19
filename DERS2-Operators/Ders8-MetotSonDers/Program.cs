    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_MetotSonDers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(4,5,6,1,345,567,34));
            //Console.WriteLine(Topla(0,4,1,1,55,33,34));
            //Console.WriteLine(PuanTopla("Engin",55,100));

            //int f4 = Faktoriyel(4);
            //Console.WriteLine(f4);

            // String metotları 
            //Concat=birleşim
            //Compare= farklı mı değil mi 1 veya 0 döndürür.
            //string birlesim = string.Concat("Network", "akademi", "203Sabah", 2021);
            //Console.WriteLine(birlesim);
            //string str1 = "KADIKÖY";
            //string str2 = "kadıköy";
            //Console.WriteLine(string.Compare(str1,str2));
            //Console.WriteLine(string.Compare(str1,1,str2,1,3,false)); // indexten itibaren son int kadar büyük küçük harf duyarlılığı ayarı.
            //string mtn = "BEŞİKTAŞ";
            //Console.WriteLine(mtn.IndexOf("ş")); // ilk ş dedeğerinin indexi
            //Console.WriteLine(mtn.LastIndexOf("ş")); // son ş değerinin indexi
            //Console.WriteLine(mtn.StartsWith("BEŞ")); // BEŞ ile başlıyor mu
            //Console.WriteLine(mtn.EndsWith("TAŞ")); // TAŞ ile bitiyor mu

            //  string yazi = " FENERBAHÇE ";
            // yazi= yazi.Trim(); // baştaki ve sondaki boşlukları siler
            //  yazi =yazi.Trim('B'); // metnin kenarında B karakteri varsa onu siler
            //  char[] dizi = { 'A', 'H', 'Ç', 'E' };

            //yazi=  yazi.Trim(dizi); // yazıdan dizide ki harfleri siler
            //  Console.WriteLine(yazi);

            //string str3 = "MERHABA DÜNYA";
            //Console.WriteLine(str3.PadRight(15,'E')); // sağdan 15 karaktere tamam E ile leftide sonuna ekler.

            //string cumle = "Merhaba arkadaşlar. Bugün sınav var.";
            //string[] kelimeler = cumle.Split(' '); // cümleyi belirtilen karaktersen bölerek diziye atar.
            //foreach (var kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}

            //string yeniCumle = String.Join(' ',kelimeler);
            //Console.WriteLine(yeniCumle);

            // Replace= 'K' yı 'C' ile değişdir
            // Remove(0,3) 0. indisten başla 3 eleman sil

            // Substring(8) = 8. indexten sonrasını al
            // Substring(0,7) 0. indisten sonra 7. indise kadar al

            // Contains"Dün" yazıda var mı ?

            // Soru1= string tipinde ki metnin harflerini char tipindeki diziye aktaran metodu yazınız.

            //string metin = "EN BÜYÜK BURSASPOR ";

            //char[] kelimeler = Convert.ToChar(metin.Split(' '));

            //SORU2= Girilen metinde ki kelime sayısını bulan metodu girin

            //TersYaz(metin);

            //int metinUzunluğu = metin.Length;
            //Console.WriteLine(metinUzunluğu);

            //SORU3: girilen metini tersten yazan programı metot kullanarak yazınız



         



            


        }

        //params terimi limitsiz parametre almayı sağlar ve onları bir dizi olarak tutar.
        //static int Topla(params int[] sayilar)
        //{
        //    int toplam = 0;
        //    foreach (int sayi in sayilar)
        //    {
        //        toplam += sayi;

        //    }
        //    return toplam;
        //}

        //params parametreleri normal parametreler ile birlikte kullanılırken param en son kullanılmalıdır.
        //static string PuanTopla(string isim, int yas, params int[] puanlar)
        //{
        //    int toplamPuan = 0;
        //    foreach (var puan in puanlar)
        //    {
        //        toplamPuan += puan;
        //    }
        //    return isim+" "+Convert.ToString(toplamPuan)+" "+Convert.ToString(yas);
        //}

        //Recursive: Kendini tekrar eden veya çağıran metotlar. *parametre olmak zorunda
        //5 !=5*4!=5*4*3!=5*4*3*2!=5*4*3*2*1
        //static int Faktoriyel(int sayi)
        //{
        //    if (sayi<=1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return sayi * Faktoriyel(sayi - 1);
        //    }
        //}

        // Math Metotlarıı

        //int mutlak7 = Math.Abs(-7); // mutlak deger alır
        //double cos45 = Math.Cos(45)
        //    Console.WriteLine(mutlak7);
        //    Console.WriteLine(cos45);
        //    Console.WriteLine(Math.Sin(45));
        //    Console.WriteLine(Math.Tan(45));
        //    Console.WriteLine(Math.Max(4, 5)); //max yazar
        //    Console.WriteLine(Math.Min(4, 5)); //min yazar
        //    Console.WriteLine(Math.Pow(2, 5)); //kare alır
        //    Console.WriteLine(Math.Sqrt(25)); //kare kök alır
        //    Console.WriteLine(Math.Log(100));
        //    Console.WriteLine(Math.Exp(4));
        //    Console.WriteLine(Math.Log10(5));

        //static int KelimeSay(string yazi)
        //{
        //    int toplamKelime = 0;
        //    string[] dizi = yazi.Split(' ');
        //    return dizi.Length - 1;
        //}

        //static void TersYaz(string yazi)
        //{
        //    for (int i = yazi.Length; i >=0; i--)
        //    {
        //        Console.Write(yazi[i]);
        //    }
        //}


        // ref kullanılırken parametrenin ilk değer ataması zorunludur.
        //static int DegerDegistir(ref int sayi)
        //{
        //    sayi = sayi * 10;
        //    return sayi;
        //}

        //// out kullanılırken parametrenin ilk değer ataması zorunlu değildir.
        //static int DegerDegistirOut(out int sayi)
        //{
        //    sayi = 20;
        //    return sayi + 100;
        //}





    }

    

    

    
}
