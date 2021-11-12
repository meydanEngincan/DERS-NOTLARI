using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //////DÖNGÜLER(Loop)/////
            //tekrar eden yapılar. Sayaç yapısı kullanılır.

            //int prim = 3500;
            //while (prim < 7200)
            //{
            //    Console.WriteLine("Emekliliğe daha var Çalış babam çalış :)");
            //    prim += 360;
            //}
            //Console.WriteLine("Tebrikler emekli oldun :)");


            //1-10 arasında ki sayılar

            //byte sayi = 1;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}

            //örnek= 1 den klavyeden girilen sayıya kadar olan sayıları ekrana yazdıran prog yaz.

            //Console.Write("Sayi Giriniz: ");
            //int s1 = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //while (i <= s1)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //örnek = klavyeden girilen değer "CIK" olmadığı sürece ekrana yazılanları ekrana yazdıran program

            //    Console.Write("Kelimeyi giriniz: ");
            //    string metin = Console.ReadLine();

            //    while (metin.ToLower() != "çık") // ToLower yazılan her kelimeyi küçültür.
            //    {
            //        Console.WriteLine(metin);
            //        Console.Write("Kelimeyi giriniz: ");
            //        metin = Console.ReadLine();
            //    }
            //    Console.WriteLine("Program Sonlandı.");

            //klavyeden girilen deger "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdır.

            //Console.Write("Değer Giriniz :");
            //int s = Convert.ToInt32(Console.ReadLine());
            //string deger = "12312412";
            //var deger2 = int.TryParse(deger, out _); // _ koyduğumuz için değişken tanımlamaya gerek kalmıyor kolaylık sağlıyor.
            //int toplam = 0;
            //int i = 0;

            //while (deger.ToLower() != "bitir")
            //{
            //    if (deger2 == true)
            //    {
            //        i = Convert.ToInt32(deger);
            //        toplam += i;
            //    }
            //    Console.Write($"Sayı Giriniz: ");
            //    deger = Console.ReadLine();
            //    deger2 = int.TryParse(deger, out _);                
            //}
            //Console.WriteLine("Toplam= "+ toplam);


            //SORU : klavyeden girilen ifade "bitir" değil ise girilen sayıların karesini toplayıp ekrana yazdıran prog yazınız
            //koşul= girilen sayı 5 ve 5in katı ise programdan çıkacak.

            //Console.Write("Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string metin = Console.ReadLine();
            //int toplam = 0;

            //while(metin != "bitir" && sayi % 5 !=0)
            //{               
            //  toplam += (sayi * sayi);
            //  Console.WriteLine("Sayı Giriniz");               

            //}
            //Console.WriteLine(toplam);

            //soru=1-100 arasında ki sayıların tek mi çift mi olduğunu ekrana yazan programı yaz

            //Console.Write("Sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int i = 0;

            //while (i < 100)
            //{
            //    i++;
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i + " Çift Sayıdır");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i+ " Tek Sayıdır");
            //    }
            //}

            //SORU= klavyeden girilen sayı kadar olan sayıları ekrana yazdıran programı yazınız
            //koşullar : 5in katlarında bom yazsın ve 19un katına gelince programdan çıksın.


            //int sayi = Convert.ToInt32(Console.ReadLine());          

            //while (sayi % 5 !=0 && sayi % 19 !=0)
            //{
            //    Console.Write("Sayı Giriniz: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(sayi);                
            //}
            //Console.WriteLine("Hatalı Sayı girdiniz");


            //int sayi;
            //while (true) // sonsuz döngü başlatır
            //{
            //    Console.Write("Sayı: ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if(sayi % 5 == 0)
            //    {
            //        Console.WriteLine("BOM");
            //    }
            //    else if (sayi % 19 == 0)
            //    {
            //        Console.WriteLine("19un katı girildiği için program kapanır.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sayı : {sayi}");
            //    }
            //}


            //Break ve Continue kavramı, Soru= 1-10 arasındaki sayıları ekrana yazdıran prog. yaz. 7 ye geldiğinde birşey yazdırmasın,9a geldiğinde programdan çıksın

            int i = 1;
            while (i <= 10)
            {
                if (i == 7)
                {
                   i++;
                    continue; // bu aşamada döngü başına atlar.
                }
                else if (i == 9)
                    break; // döngüyü sonlandırır.
                Console.WriteLine(i);
                i++;
            }





        }
    }
}
