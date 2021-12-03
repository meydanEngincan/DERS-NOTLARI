using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders12_OOP_Polimorfizm.BelediyeSorusu
{
    class BelediyeYonetimi
    {
        Belediye _belediye;
        public BelediyeYonetimi(Belediye belediye)
        {
            this._belediye = belediye;
        }
        public void Belediyeler()
        {
            Console.WriteLine("Belediyler çağrıldı Belediye Yönetiminden ");
            this._belediye.BelediyeHarcOde();
        }
    }
}
