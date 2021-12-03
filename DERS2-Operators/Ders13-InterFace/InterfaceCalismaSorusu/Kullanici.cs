using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace.InterfaceCalismaSorusu
{
    class Kullanici
    {
        private string _AdSoyad;
        string _Eposta;
        string _Telefon;
        public string AdSoyad
        {
            get { return this._AdSoyad; }
            set { this._AdSoyad = value; }
        }
        public string Eposta
        {
            get { return this._Eposta; }
            set { this._Eposta = value; }
        }
        public string Telefon
        {
            get { return this._Telefon; }
            set { this._Telefon = value; }
        }

        public List<string> GetKullanici()
        {
            List<string> bilgiler = new List<string>();
            bilgiler.Add(this._AdSoyad);
            bilgiler.Add(this._Eposta);
            bilgiler.Add(this._Telefon);
            return bilgiler;
           // Console.WriteLine($"Ad Soyad: {this._AdSoyad}\nEposta: {this._Eposta}\nTelefon: {this._Telefon}");
        }
    }
}
