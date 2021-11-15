using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Ders5_List
{
    class Program
    {
        static void Main(string[] args)
        {

            // dizilerden farklı olarak kapasitesi sınırlı değildir veri ekledikçe genişler.

            // Tanımlama
            //List<int> ilkListem = new List<int>(); // Boş liste oluştu
            //List<string> sehirler = new List<string>()
            //{ "İstanbul","izmir","manisa","van"};
            //List<int> araListe = new List<int> { 1000, 2000, 3000 };

            //// Veri Ekleme
            //ilkListem.Add(1990); // listeye değer atadık
            //ilkListem.Add(12312); // add komutu listenin sonuna ekle
            //ilkListem.Add(41231);
            //ilkListem.Add(5555);

            //ilkListem.Insert(0, 1988); // Insert komutu listenin başına ekler
            //ilkListem.InsertRange(2, araListe);




            // Veriye ulaşma
            //Console.WriteLine(ilkListem[0]);
            //Console.WriteLine(sehirler[3]);

            //foreach (var item in ilkListem)
            //{
            //    Console.WriteLine(item);
            //}

            // Temizleme - ListAdı.Clear();
            // listede ki toplam eleman sayısını bulma ListAdı.Count
            // Listede var mı listeAdı.Contains
            // Listeden silme ListAdı.Remove("parametre")

            //örn 1-10 arasında rastgele 5'er sayı üretip o listeleri ve aralarında ki farkları başka bir listeye atarak yazdıran program.

            // HOcanın çözümü
            //List<int> liste1 = new List<int>();
            //List<int> liste2 = new List<int>();
            //List<int> listeFark = new List<int>();
            //Random rnd = new Random();

            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    liste1.Add(sayi);
            //    Console.Write(sayi + " ");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    int sayi = rnd.Next(1, 10);
            //    liste2.Add(sayi);
            //    Console.Write(sayi + " ");
            //}

            //foreach (var eleman in liste1)
            //{
            //    if (liste2.Contains(eleman) == false)
            //    {
            //        listeFark.Add(eleman);
            //    }

            //}
            //foreach (var eleman in liste2)
            //{
            //    if (liste1.Contains(eleman) == false)
            //    {
            //        listeFark.Add(eleman);
            //    }
            //    for (int i = 0; i < listeFark.Count; i++)
            //    {
            //        Console.WriteLine(listeFark[i] + " ");
            //    }


            //// Benim çözümüm
            //Random rnd = new Random();
            //int sayi = rnd.Next(1, 10); **************************      HATA 1
            //List<int> liste1 = new List<int>();
            //List<int> liste2 = new List<int>();
            //List<int> liste3 = new List<int>();
            //for (int i = 0; i < 5; i++)
            //{
            //    liste1.Add(sayi);
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    liste2.Add(sayi);
            //}

            //bool list1Check = liste2.Contains(Convert.ToInt32(liste1));
            //if (list1Check == false)
            //{
            //    liste3.Add(sayi);
            //}

            //foreach (var item in liste1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**********");
            //foreach (var item in liste2)
            //{
            //    Console.WriteLine(liste2);
            //}
            //Console.WriteLine("**********");
            //foreach (var item in liste3)
            //{
            //    Console.WriteLine(liste3);
            //}


            // soru= 1-100 arasında 15 sayı üretip bir listeye atın, kullanıcıdan tahmin alıp listede olup olmadığına bakın, listede var iste index numarasını ekrana yazdırın

            List<int> liste1 = new List<int>();
            Random rnd = new Random();
            int indisNo;

            for (int i = 0; i < 15; i++)
            {
               int sayi = rnd.Next(1, 100);
                liste1.Add(sayi);
            }
            Console.WriteLine("Bir 1 ile 100 arasında bir sayı giriniz: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            foreach (var item in liste1)
            {
                if (liste1.Contains(item) == true)
                {
                  indisNo = liste1.IndexOf(item);
                    Console.WriteLine(indisNo);
                }
                
            }
            






            //soru2= 0-127 arasında 1 sayı üretip bir listeye atın kullanıcıdan bir karakter alın


        }
    }
}
