using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Abstract.AbstractOrnek
{
    class Ticari : Arac
    {
        private byte _TasimaKapasitesi;
        public byte TasimaKapasitesi
        {
            get { return this._TasimaKapasitesi; }
            set 
            { if (value > 0 && value <= 5) 
                 {
                    this._TasimaKapasitesi = value; 
                 }
            }
        }
        public double YillikVergi;
        public override void OTVHesapla()
        {
            if(this.MotorHacmi>0 && this.MotorHacmi <= 999)
            {
                Console.WriteLine($"Aracınızın ÖTV'li fiyatı: {this.Fiyat}");
            }
            if(this.MotorHacmi>=1000 && this.MotorHacmi <= 1599)
            {
                Console.WriteLine($"Aracınızın ÖTV'li fiyatı: {this.Fiyat+(this.Fiyat*(0.05))}");
            }
            if(this.MotorHacmi >=1600 && this.MotorHacmi <= 1999)
            {
                Console.WriteLine($"Aracınızın ÖTV'li fiyatı: {this.Fiyat+this.Fiyat*(0.1)}");
            }
            if(this.MotorHacmi >= 2000)
            {
                Console.WriteLine($"Aracınızın ÖTV'li fiyatı: {this.Fiyat+this.Fiyat*(0.15)}");
            }
            
        }

        public override void YillikVergiHesapla()
        {
            this.YillikVergi = 0;
            if ((this.UretimYili > 0 && this.UretimYili <= 4))
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += (2) * (this.Fiyat * (0.0))}");
            }
            if ((this.UretimYili > 4 && this.UretimYili <= 9))
            {
                Console.WriteLine($"Yıllık Vergi:{this.YillikVergi += (2) * (this.Fiyat * (0.02))}");
            }
            if (this.UretimYili > 9)
            {
                Console.WriteLine($"Yıllık Vergi:{this.YillikVergi += (2) * (this.Fiyat * (0.01))}");
            }
            //////////////////////////////////////////////////////////////////////////////77
            if (this.MotorHacmi > 0 && this.MotorHacmi < 999)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += (2) * (this.Fiyat * (0.0))}");
            }
            if (this.MotorHacmi >= 1000 && this.MotorHacmi <= 1599)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += (2) * (this.Fiyat * (0.02))}");
            }
            if (this.MotorHacmi >= 1600 && this.MotorHacmi <= 1999)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += (2) * (this.Fiyat * (0.05))}");
            }
            if (this.MotorHacmi >= 2000)
            {
                Console.WriteLine($"Yıllık Vergi: {this.YillikVergi += (2) *  (this.Fiyat * (0.1))}");
            }
        }
    }
}
