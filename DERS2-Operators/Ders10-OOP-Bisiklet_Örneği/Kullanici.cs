using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP_Bisiklet_Örneği
{
    class Kullanici
    {
        private int KullaniciID;
        private string AdSoyad;
        private string Telefon;
        public Kuafor kuafor;
       
        public string _Adsoyad
        {
            get { return this.AdSoyad; }
            set
            {
                if ((!(String.IsNullOrEmpty(value)) && !(String.IsNullOrWhiteSpace(value))))
                {
                    this.AdSoyad = value;
                }
                else
                {
                    Console.WriteLine("Boşluklardan oluşan veya tamamen boş değer atayamazsınız.!!!");
                }
            }
        }

        public string _Telefon
        {
            get { return this.Telefon; }
            set { this.Telefon = value; }
        }
    }
}
