using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BelediyeSorusu
{
    class LokantaYozgat:Belediye
    {
        public LokantaYozgat()
        {
            base._HarcUcreti = 1500;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Belediye harc ücreti Mersin için= {this._HarcUcreti}");
        }
    }
}
