using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BelediyeSorusu
{
    class LokantaTokat:Belediye
    {
        public LokantaTokat()
        {
            base._HarcUcreti = 2000;
        }
        public override void BelediyeHarcOde()
        {
            Console.WriteLine($"Belediye harc ücreti Mersin için= {this._HarcUcreti}");


            string[] degerler = new string[] {"engin","damla","numan" } ;

            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
