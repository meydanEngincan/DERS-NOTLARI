using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KALITIM
{
    class AltClass : AnaClass
    {
        private string _AdSoyad;

        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }
        }

        public void AltClassBilgiYaz()
        {
            Console.WriteLine($"Ad Soyad: {this._AdSoyad}");
        }

    }
}
