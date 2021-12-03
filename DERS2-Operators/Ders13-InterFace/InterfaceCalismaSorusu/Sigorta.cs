using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace.InterfaceCalismaSorusu
{
    class Sigorta
    {
        static int sayac = 1;
        string _SigortaN;
        DateTime _SigortaBitisTarihi;

        public string SigortaN
        {
            get { return this._SigortaN; }
        }
        public DateTime BitisTarihi { get { return this._SigortaBitisTarihi; } }
        public Sigorta()
        {
            sayac += 1;
        }
        //private string SigortaNoUret()
        //{

        //}
        public void  SigortaGuncelle()
        {
            string sn = "";
            sn += DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + sayac.ToString();
        }
    }
}
