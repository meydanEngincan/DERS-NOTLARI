using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BelediyeSorusu
{
    abstract class Belediye
    {
        //public int harcUcreti = 3000;
        protected int _HarcUcreti;
        public Belediye()
        {
            this._HarcUcreti = 3000;
        }

        abstract public void BelediyeHarcOde();
        
    }


}
