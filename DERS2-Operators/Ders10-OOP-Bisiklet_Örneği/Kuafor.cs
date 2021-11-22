using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders10_OOP_Bisiklet_Örneği
{
    enum Hizmetler
    {
        Saç_Traşı,
        Sakal,
        Saç_yıkama,
        Cilt_Bakımı
    }

    class Kuafor
    {
        // enum: Hizmetler = Saç Traşı,Sakal,Saç yıkama,Cilt Bakımı
        // Saç traşı:20,Sakal Traşı 15, Saç yıkama:10,Cilt bakım
        // ID,Ad,SacTıraşÜcreti,Sakal Traş Ücreti,SacYıkamaÜcreti,CiltBakımÜcreti
        //ToplamTutar

        // metotlar: SacTrasiYap(),SakalTrasiYap(),SacYika(),CiltBakimiYap(),BilgiYaz();
        
        Kullanici kullan = new Kullanici();
    
       
       
       
       

        float _toplamFiyat;
        public float toplamFiyat
        {
            get { return this.toplamFiyat; }
            set
            {
                if (this._toplamFiyat != 0.0)
                {
                    Console.WriteLine("Toplam Fiyat 0 tlden başlamalıdır.");
                }
                else
                {
                    this._toplamFiyat = value;
                }
            }
        }
        
        string AD;
        float sacTrasiUcret;
        float sakalTrasiUcret;
        float sacYikamaUcret;
        float ciltBakimUcret;

        List<Hizmetler> alinanHizmetler = new List<Hizmetler>();
        public Kuafor()
        {
            this._toplamFiyat = 0;
            this.sacTrasiUcret = 20.0f;
            this.sakalTrasiUcret = 15.0f;
            this.sacYikamaUcret = 10.0f;
            this.ciltBakimUcret = 30.0f;
        }
         
        public void SacTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_yıkama);
            this._toplamFiyat += sacTrasiUcret;
        }
        public void SaciYika()
        {
            alinanHizmetler.Add(Hizmetler.Saç_yıkama);
            this._toplamFiyat += sacYikamaUcret;
        }
        public void SakalTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Sakal);
            this._toplamFiyat += sakalTrasiUcret;
        }
        public void CiltBakimiYap()
        {
            
            alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            this._toplamFiyat += ciltBakimUcret;
        }
        public void BilgiYaz()
        {
            Console.WriteLine($"Sayın {this.kullan._Adsoyad} Aldığınız hizmetlerin sonucunda ödeyeceğiniz tutar => {this._toplamFiyat} Tl'dir.");
        }
    }
}
