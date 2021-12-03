using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Abstract.AbstractOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil otm = new Otomobil();
            Ticari tcr = new Ticari();

            otm.Fiyat = 100000;
            otm.MotorHacmi = 1750;
            otm.renk = Renk.kirmizi;
            otm.KapiSayisi = 4;
            tcr.TasimaKapasitesi = 200;
            otm.UretimYili = 2019;
            otm.
            otm.BilgiYaz();
            //otm.GetFiyat();
            //otm.OTVHesapla();

            YillikVergiHesapla(otm);
            OTVHesapla(otm);
            YillikVergiHesapla(tcr);
            OTVHesapla(tcr);
        }

        static void YillikVergiHesapla(Arac arac)
        {
            arac.YillikVergiHesapla();
        }
        static void OTVHesapla(Arac arac)
        {
            arac.OTVHesapla();
        }
    }
}
