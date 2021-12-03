using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace.InterfaceCalismaSorusu
{
    enum YakitTipi { Dizel,Benzin,LPG,Elektrik,Hibrit}
    enum VitesTipi { Otomatik,Yarı_Otomatik,manuel}
    enum KasaTipi { Sedan,Station,Hatchback}
    class Araba:IVasita,IIlan
    {
        short _MotorHacmi;
        Sigorta sgrt;
        public short MotorHacmi
        {
            get { return this._MotorHacmi; }
            set { this._MotorHacmi = value; }
        }
        
        public long IlanN { get; set; }
        public DateTime IlanTarihi { get;set; }
        public string Marka { get ; set ; }
        public string Model { get ; set ; }
       
        public Kullanici Satici { get ; set; }
        public Sigorta Sigorta { get; set; }
        public Araba() // yapıcı metotu calıstığında otomatik olsun
        {
            this.IlanTarihi = DateTime.Now;
        }
        
        public void SigortaYap()
        {
            this.Sigorta = new Sigorta();
        }

        YakitTipi yakittipi;
        VitesTipi vitestipi;
        KasaTipi kasatipi;

    }
}
