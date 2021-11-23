using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KalıtımOrnek
{
    class Kullanici
    {
        int _KullaniciID;
        public int KullaniciID
        {
            get { return this._KullaniciID; }
        }
        string _KullaniciAdSoyad;
        public string KullaniciAdSoyad
        {
            get { return this._KullaniciAdSoyad; }
            set { this._KullaniciAdSoyad = value; }
        }
        string _KullaniciTelefon
        {
            get { return this._KullaniciTelefon; }
            set { this._KullaniciTelefon = value; }
        }
    }
}
