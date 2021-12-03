using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Dortgen:Sekil
    {
        public int _En;
        public int _Boy;
        //public double Alan;
        //public double Cevre;

        public Dortgen()
        {

        }

        //public override void ALAN()
        //{
        //    this.Alan = (this._En * this._Boy);
        //    Console.WriteLine($"Dortgenin alanı: {this._Alan}");
        //}

        public override void ALAN()
        {
           
            Console.WriteLine($"Dortgenin Alanı: {this._En*this._Boy}");
        }

        public override void CEVRE()
        {
            //this.Cevre = (this._En + this._Boy) * 2;
            Console.WriteLine($"Dortgenin Çevresi: {(this._En + this._Boy)* 2}");
        }

        
    }
}
