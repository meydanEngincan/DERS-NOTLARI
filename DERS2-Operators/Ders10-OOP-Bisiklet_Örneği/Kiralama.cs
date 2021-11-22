using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ders10_OOP_Bisiklet_Örneği
{
    class Kiralama
    {
        private int KiralamID;
        private Bisiklet BisikletID;
        private Kullanici KullaniciID;
        private float Sure;
        private DateTime BaslamaZamani;
        private DateTime BitisZamani;
        private float SaniyeUcret;
        private float Ucret;

        public Kiralama()
        {
            this.SaniyeUcret = 0.25f;
        }

        public Bisiklet _BisikletID
        {
            get { return this.BisikletID; }
            set { this.BisikletID = value; }
        }
        public Kullanici _KullaniciID
        {
            get { return this.KullaniciID; }
            set { this.KullaniciID = value; }
        }
        public float _Sure
        {
            get { return this.Sure; }
            set { this.Sure = value; }
        }
        public DateTime _BaslamaZamani
        {
            get { return this.BaslamaZamani; }
            set { this.BaslamaZamani = value; }
        }
        public DateTime _BitisZamani
        {
            get { return this.BitisZamani; }
            set { this.BitisZamani = value; }
        }
        public float _SaniyeUcret
        {
            get { return this.SaniyeUcret; }
            set { this.SaniyeUcret = value; }
        }
        public float _Ucret
        {
            get { return this.Ucret; }
            set { this.Ucret = value; }
        }

        public void KiralamaBaslat()
        {
            this.BaslamaZamani = DateTime.Now;
            KiralamaBitir();       
        }
        public void KiralamaBitir()
        {
            this.BitisZamani = DateTime.Now; 
        }
        public void UcretHesapla()
        {
            TimeSpan zamanFarki = this.BitisZamani - this.BaslamaZamani;
            int farkSaniye = zamanFarki.Seconds; // zaman farkının sadece saniyesini aldık
            Console.WriteLine("Fark" + farkSaniye);
            this.Sure = farkSaniye;
            this.Ucret = this.Sure * this.SaniyeUcret;
            this.BilgiYaz();

        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Sayın {this.KullaniciID._Adsoyad};\nBaşlama zamanı : {this.BaslamaZamani}\nBitiş zamanı : {this.BitisZamani}\nToplam süre : {this.Sure}\nToplam ödemeniz gerek tutar : {this.Ucret} ₺ dir.");

            Console.WriteLine($" Sayın {this.KullaniciID._Adsoyad} 123");
        }
    }
}
