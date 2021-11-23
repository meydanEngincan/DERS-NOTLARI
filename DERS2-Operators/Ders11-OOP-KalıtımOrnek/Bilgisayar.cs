using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KalıtımOrnek
{
    public enum KasaTipi { Yatay, Dikey }
    class Bilgisayar:Ilan
    {
        string _Marka;
        public string Marka
        {
            get { return this._Marka; }
            set { this._Marka = value; }
        }
        string _Islemci;
        public string Islemci
        {
            get { return this._Islemci; }
            set { this._Islemci = value; }
        }

        string _Bellek;
        public string Bellek
        {
            get { return this._Bellek; }
            set { this._Bellek = value; }
        }

        public KasaTipi kasa
        {
            get { return this.kasa; }
            set { this.kasa = value; }
        }
        

        string _HDD;
        public string HDD
        {
            get { return this._HDD; }
            set { this._HDD = value; }
        }
        string _SSD;
        public string SSD
        {
            get { return this._SSD; }
            set { this._SSD = value; }
        }

        bool _EthernetVarMi;
        public bool EthernetVarMi
        {
            get { return this._EthernetVarMi; }
            set { this._EthernetVarMi = value; }
        }

        bool _WifiVarMi;
        public bool WifiVarMi
        {
            get { return this._WifiVarMi; }
            set { this._WifiVarMi = value; }
        }
    }
}
