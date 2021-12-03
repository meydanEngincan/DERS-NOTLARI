using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders13_InterFace
{
    // Bir sınıf Bir den fazla Interface i miras alabilir.
    class ClassTest : ISablon,ISablon2
    {
        public string Marka { get; set; }
        public string Model { get ; set ; }
        public string ID { get; set; }
        public double Fiyat { get; set; }
        public Kategori kategori { get ; set; }

        public void BilgiYaz()
        {
            Console.WriteLine($"Marka : {this.Marka}");
            Console.WriteLine($"Model : {this.Model}");
        }

        public double GetFiyat()
        {
            return this.Fiyat;
        }
    }
}
