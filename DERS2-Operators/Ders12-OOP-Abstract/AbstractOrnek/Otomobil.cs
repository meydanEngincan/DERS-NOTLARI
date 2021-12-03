using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Abstract.AbstractOrnek
{
    enum Renk { kirmizi,siyah,beyaz,gri}
    class Otomobil : Arac
    {
        public byte KapiSayisi;
        public Renk renk;
        public double YillikVergi;
        public override void OTVHesapla()
        {
           if (this.MotorHacmi >0 && this.MotorHacmi < 1000)
            {
                Console.WriteLine($" Motor Hacmi 0-999 Arasındaysa OTV'li Fiyat: {this.Fiyat = this.Fiyat+ (this.Fiyat * (0.05))}" ); 
            }
           else if (this.MotorHacmi >=1000 && this.MotorHacmi < 1600)
            {
                Console.WriteLine($" Motor Hacmi 1000-1600 Arasındaysa OTV'li Fiyat: {this.Fiyat = this.Fiyat + (this.Fiyat * (0.1))}");
            }
           else if (this.MotorHacmi >= 1699 && this.MotorHacmi < 1999)
            {
                Console.WriteLine($"Motor Hacmi 1600-1999 Arasındaysa OTV'li Fiyat: {this.Fiyat = this.Fiyat + (this.Fiyat * (0.15))}");
            }
           else if (this.MotorHacmi >= 2000)
            {
                Console.WriteLine($"Motor hacmi 2000 den yüksek aracların OTV'li Fiyatı{this.Fiyat=this.Fiyat+(this.Fiyat*(0.2))}");
            }
        }

        public override void YillikVergiHesapla()
        {
            this.YillikVergi = 0;
           if((this.UretimYili>0 && this.UretimYili <= 4))
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi+=this.Fiyat*(0.05)}");

            }
           if((this.UretimYili > 4 && this.UretimYili <= 9))
            {
                Console.WriteLine($"Yıllık Vergi:{this.YillikVergi+=this.Fiyat*(0.04)}");
            }
            if (this.UretimYili > 9 )
            {
                Console.WriteLine($"Yıllık Vergi:{this.YillikVergi += this.Fiyat * (0.03)}");
            }

            if(this.MotorHacmi>0 && this.MotorHacmi < 999)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += this.Fiyat * (0.02)}");
            }
            if (this.MotorHacmi >= 1000 && this.MotorHacmi <=1599)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += this.Fiyat * (0.05)}");
            }
            if (this.MotorHacmi >=1600 && this.MotorHacmi <= 1999)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += this.Fiyat * (0.08)}");
            }
            if (this.MotorHacmi >=2000)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += this.Fiyat * (0.1)}");
            }
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Motor Hacmi:{base.MotorHacmi}\nVites Sayısı:{5}\nFiyat:{base.Fiyat}\nUretim Yılı{base.UretimYili}\nKapı Sayısı:{5}\nRenk:{Renk.kirmizi}");
        }
    }
}
