using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Daire : Sekil
    {
        public double yariCap;
        public double Pi ;
        public double Alan;
        public double Cevre;

        public Daire()
        {

        }

        public override void ALAN()
        {
            this.Alan = this.Pi * (this.yariCap * this.yariCap);
            Console.WriteLine($"Dairenin Alanı: {this.Alan}");
        }

        public override void CEVRE()
        {
            Console.WriteLine($"Dairenin Çevresi:{2*this.Pi*this.yariCap}.");
        }
    }






}
