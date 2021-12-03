﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BelediyeSorusu
{
    class LokantaMersin:Belediye
    {
        
        public LokantaMersin()
        {
            base._HarcUcreti = 3500;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Belediye harc ücreti Mersin için= {this._HarcUcreti}");   
        }
    }
}
