using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders1_DataTipleri_DataTypes_
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte sayi = 45; //bytenin başında S olduğu için - li değer alabilir.
            //sayi = 45;

            //byte bSayiMaks = byte.MaxValue;
            //byte bSayiMin = byte.MinValue; //byte'n alacağı max ve min değerleri gösterir.
            //Console.WriteLine($"byte tiğinin alacağı en büyük değer:{bSayiMaks}");
            //Console.WriteLine($"byte tipinin alacağı en küçük değer:{bSayiMin}");

            //char harf = 'A';
            //Console.WriteLine($"Harf değişkeninin tipi:{harf.GetType()}"); // harf değişkeninin tipini söyler.

            ////var s1 = 55;  sistem otomatik int yapar.
            ////var s2 = 34.23;  sistem otomatik double yapar.
            ////var isim = "Engin";  sistem otomatik string yapar. Var değişkeninin özelliği.

            Console.Write("Ad Soyad Giriniz: ");
            string adSoyad = Console.ReadLine();
            Console.Write("Mail Adresini Giriniz: ");
            string mail = Console.ReadLine();
            Console.Write("Parola Giriniz: ");
            string sifre = Console.ReadLine();

           //Console.WriteLine("Ad Soyad :" + adSoyad + "\n" + "Mail " + mail + "\n" + "Şifre " + sifre);
            Console.WriteLine($"Ad Soyad : {adSoyad} \nMail : {mail} \nŞifre : {sifre}");
        }
    }
}
