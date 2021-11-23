using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders11_OOP_KALITIM
{
    class AnaClass
    {
        public int _ID;
        DateTime _IlanTarihi;
        public DateTime IlanTarihi
        {
            get { return this._IlanTarihi; }
            set { this._IlanTarihi = value; }
        }
    }
}
