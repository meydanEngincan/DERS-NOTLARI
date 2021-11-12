using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders4_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //for DÖNGÜSÜ////////7
            // for ( başlangıç değeri,limiti,artış biçimi)
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //};

            // klavyeden girilen sayıya kadar olan sayıları yazan program
            //Console.Write("Bir Sayı Giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for ( ; ; )
            //{
            //    Console.WriteLine("Sonsuz Döngü");
            //}

            // klavyeden girilen 2 sayı arasında ki sayıları azalan şekilde yazınız

            Console.Write("Bir Sayı giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir Sayı daha giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
            {
                for (int i = s1; i == s2; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = s2; i == s1; i++)
                {
                    Console.WriteLine(i);
                }
            }

            int kucuk;
            int buyuk;
            Console.Write("Sayı 1= ");
            int kgs1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayı 2= ");
            int kgs2 = Convert.ToInt32(Console.ReadLine());

            if (kgs1 > kgs2)
            {
                buyuk = kgs1;
                kucuk = kgs2;
            }
            else
            {
                buyuk = kgs2;
                kucuk = kgs1;
            }
            for (int i = buyuk; i > kucuk; i--)
            {

            }

            //Soru Marketteki her ürünün fiyatının tek tek girilip her biri için %18 kdv li fiyatını ekrana yazdıran program
            //tüm ürünlerin toplan fiyatını kdv dahil olarak ekrana yazdıran program.5 ürün

            for (int i = 0; i < 5; i++)

            {
                Console.Write("Ürün İsmi Girin: ");
                string ü1 = Console.ReadLine();
                Console.Write("Ürün Fiyat Girini: ");
                int ü1f = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ürün : {ü1} Kdvli Fiyat {ü1f+(ü1f*(0.18))}");
            }






            //string ü1, ü2, ü3, ü4, ü5;
            //Console.Write("Ürün İsmi Girin: ");
            //ü1 = Console.ReadLine();
            //Console.Write("Ürün İsmi Girin: ");
            //ü2 = Console.ReadLine();
            //Console.Write("Ürün İsmi Girin: ");
            //ü3 = Console.ReadLine();
            //Console.Write("Ürün İsmi Girin: ");
            //ü4 = Console.ReadLine();
            //Console.Write("Ürün İsmi Girin: ");
            //ü5 = Console.ReadLine();
            //int ü1f, ü2f, ü3f, ü4f, ü5f;
            //Console.Write("Ürün Fiyat Girini: ");
            //ü1f = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ürün Fiyat Girini: ");
            //ü2f = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ürün Fiyat Girini: ");
            //ü3f = Convert.ToInt32(Console.ReadLine());







        }
    }
}
