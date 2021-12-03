﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace
{
    enum Kategori { Otomobil,Emlak,Beyaz_Eşya,Mobilya}
    interface ISablon2
    {
        string ID { get; set; }
        double Fiyat { get; set; }
        Kategori kategori { get; set; }

        double GetFiyat();

    }
}
