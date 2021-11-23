using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KalıtımOrnek
{
    class Dizustu:Bilgisayar
    {
        string _EkranBoyutu;
        public string EkranBoyutu
        {
            get { return this._EkranBoyutu; }
            set { this._EkranBoyutu = value; }
        }
         int _Agırlık;
        public int Agırlık
        {
            get { return this._Agırlık; }
            set { this._Agırlık = value; }
        }

        new public void BilgiYaz()
        {
            Console.WriteLine($"İlan No: {base._IlanID} İlan Başlık: {base._IlanBaslik} İlan Kategori: {base._Kategori} Fiyat:{base._Fiyat} Satıcı: {base._Satici}");
        }
    }
}
