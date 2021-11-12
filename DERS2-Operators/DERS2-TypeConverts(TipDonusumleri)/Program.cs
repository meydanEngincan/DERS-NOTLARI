using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DERS2_TypeConverts_TipDonusumleri_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Tür Dönüşümü küçük tür büyük türe otomatik dönüştürülür.
            //byte byteSayi = 58;
            //int intSayi = byteSayi;

            //short shortSayi = 34;
            //long longSayi = shortSayi;

            //float floatSayi = 29.45f;
            //double doubleSayi = floatSayi;
            //Console.WriteLine("Sorunsuz Çalışır");

            // Bilinçli Tür Dönüşümü
            //int intSayi = 254;
            //byte byteSayi = (byte)intSayi; // parantez içinde hedef tip belirtilir.
            ////byte byteSayi =Convert.ToByte(intSayi); //2 şekilde dönüştürebilir.
            //Console.WriteLine("Sorunsuz Çalışır");
            ////int sayi 255den büyük olursa 32 bitlik değerin sadece son 8 biti alınacağından veri kaybı olur.
            //double doublesayi = 45.78D;
            //float floatSayi = (float)doublesayi;


            // Convert sınıfı metotları ile tür dönüşümü///

            //double dSayi = 678.456d;
            //string sSayi = Convert.ToString(dSayi);
            //Console.WriteLine($"sSayi tipi { sSayi.GetType()}");

            //string postaKodu = "34460";
            //int postakoduint = Convert.ToInt32(postaKodu);
            //Console.WriteLine($"Posta kodu tipi : {postakoduint.GetType()}");

            // klavyeden girilen 2 sayıyı toplayan programı yaz

            //Console.Write("Bir Tam Sayı Giriniz : ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Bir Tam Sayı Giriniz : ");
            //int s2 = Convert.ToInt32(Console.ReadLine());
            //int toplam = s1 + s2;
            //Console.WriteLine("Sayıların toplamı=" + " " + toplam);
            //Console.ReadKey();

            //Soru Klavyeden Fahrenayt olarak girilen sıcaklık bilgisini Santigrat cinsinden aşağada ki fortmatta yazdıran program yapınız
            // "32Fahrenayt = 0 Santigrat derece"

            //Console.Write("Fahrenayt Cinsinden Dereceyi Giriniz: ");
            //double fahrenayt = Convert.ToDouble(Console.ReadLine());
            //fahrenayt = Math.Round(fahrenayt, 2);
            //double santigrad = (fahrenayt - 32) / 1.8;
            //santigrad = Math.Round(santigrad, 2);
            //Console.WriteLine(fahrenayt + " Fahrenayt => " + santigrad + " Derecedir");
        }
    }
}
