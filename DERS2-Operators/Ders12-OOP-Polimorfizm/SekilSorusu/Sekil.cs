using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Sekil
    {
        private string _SekilAd;
        public string SekilAd
        {
            get { return this._SekilAd; }
            set { this.SekilAd = value; }
        }
        public double _Alan;
        public double _Cevre;

        public Sekil()
        {
            this._Alan = 0;
            this._Cevre = 0;
        }

        virtual public void ALAN()
        {

        }
        virtual public void CEVRE()
        {

        }

    }
}
