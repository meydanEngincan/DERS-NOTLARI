using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP_Bisiklet_Örneği
{
    class Bisiklet
    {
        private int BisikletID;
        private string Marka;
        private string Model;
        private int JantBoyutu;
        private int VitesSayisi;

        public string _Marka
        {
            get { return this.Marka; }
            set { this.Marka = value; }
        }

        public string _Model
        {
            get { return this.Marka; }
            set { this.Marka = value; }
        }
        public int _JantBoyutu
        {
            get { return this.JantBoyutu; }
            set { this.JantBoyutu = value; }
        }

        public int _VitesSayisi
        {
            get { return this.VitesSayisi; }
            set { this.VitesSayisi = value; }
        }
    }
}
