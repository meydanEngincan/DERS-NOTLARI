using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //örn=Klavyeden çık değeri alınana kadar alınan negatif ve pozitif sayıları ayrı ayrı toplayıp program sonunda ekrana yazdıran programı yazınız. (34 ve -34) değerleri gelirse işleme alınmadan sıradaki sayıyı istesin)

            int sayi = 0;            int pozitifToplam = 0;
            int negatifToplam = 0;
            string metin = Console.ReadLine();

            if (metin.ToLower() != "çık")
            {
                for (; ; )
                {
                    Console.Write("Sayi Giriniz");
                    string giris = Console.ReadLine();
                }
            }
        }
    }
}
