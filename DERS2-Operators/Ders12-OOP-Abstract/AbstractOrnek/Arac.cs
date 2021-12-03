using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Abstract.AbstractOrnek
{
    abstract class Arac
    {
        /*        		Arac: ID,MotorHacmi,VitesSayisi,Fiyat,OTVFiyat,UretimYili
    : Metotlar: IndirimYap(indirimOrani), GetFiyat()
    : Abs     : OTVHesapla(),YillikVergiHesapla() 

Otomobil: KapiSayisi,Renk(enum)
	OTVHesapla(): :  => 0-999 CC  : %5
		         => 1000-1599 : %10
		         => 1600-1999 : %15
		         => 2000-üzeri: %20

YıllıkVergiHesapla()
	  UretimYili => 0-4 yaş: %5
			5-9 yaş: %4
			10- yaş: %3
	  MotorHacmi =>  => 0-999 CC  : %2
		         => 1000-1599 : %5
		         => 1600-1999 : %8
		         => 2000-üzeri: %10

Ticari: TasimaKapasitesi
	OTVHesapla():    => 0-999 CC  : %0
		         => 1000-1599 : %5
		         => 1600-1999 : %10
		         => 2000-üzeri: %15

YıllıkVergiHesapla()
	  UretimYili => 0-4 yaş: %3
			5-9 yaş: %2
			10- yaş: %1
	  MotorHacmi =>  => 0-999 CC  : %0
		         => 1000-1599 : %2
		         => 1600-1999 : %5
		         => 2000-üzeri: %10

// Ticari araçlarda 6 ayda bir,binek araçlarda 2 yılda bir vergi alınır.
// Tüm hesaplamalar Fiyat özelliği üzerinden olacak.
        */



        public int ID;
        public int MotorHacmi;
        public int VitesSayisi;
        public double Fiyat;
        public int UretimYili;

        public void IndırımYap(double indirimOrani)
        {
            indirimOrani = this.Fiyat * (0.05);
            double indirimliFiyat;
            Console.WriteLine($"İndirim Oranı: {indirimOrani}");
            indirimliFiyat = this.Fiyat - indirimOrani;

            GetFiyat();
        }
        public void GetFiyat()
        {
            Console.WriteLine($"Güncel Fiyat: {this.Fiyat}");
        }

        abstract public void OTVHesapla();

        abstract public void YillikVergiHesapla();


    }
}
