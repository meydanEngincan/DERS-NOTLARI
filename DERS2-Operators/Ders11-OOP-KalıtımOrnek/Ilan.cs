using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KalıtımOrnek
{
    public enum Kategori { Laptop, Masaüstü, TemizlikUrunleri }
    class Ilan
    {
        public int _IlanID
        {
            get { return this._IlanID; }
        }

        string _IlanBaslik;

        public string IlanBaslik
        {
            get { return this._IlanBaslik; }
            set { this._IlanBaslik = value; }
        }

        Kategori _Kategori;
        public Kategori kategori
        {
            get { return this._Kategori; }
            set { this._Kategori = value; }
        }
        double _Fiyat;
        public double Fiyat
        {
            get { return this._Fiyat; }
            set { this._Fiyat = value; }
        }

        public Kullanici _Satici
        {
            get { return this._Satici; }
            set { this._Satici = value; }
        }
        //int _Adet;
        //public int Adet
        //{
        //    get { return this._Adet; }
        //    set { this._Adet = value; }
        //}

        public void BilgiYaz()
        {
            Console.WriteLine($"İlan No: {this._IlanID} İlan Başlık: {this._IlanBaslik} İlan Kategori: {this._Kategori} Fiyat:{this._Fiyat} Satıcı: {this._Satici}");
        }

        public void IndırımYap(byte indirimOrani)
        {
            this._Fiyat = this._Fiyat - (this._Fiyat * (indirimOrani / 100));
        }






    }
}
