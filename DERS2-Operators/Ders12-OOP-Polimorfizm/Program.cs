namespace Ders12_OOP_Polimorfizm.SekilSorusu
{
    class Program
    {
        static void Main(string[] args)
        {

            // POLİMORFİZM
            // Tek bir metot çağırarak farklı işlemler yapabilmemizi sağlar yani bir metodu çağırarak o metotun farklı metotları çağırabilmesini sağlar. Bu olaya LATE BINDING denir new kelimesinden farklı olarak üst sınıftaki metodu tamamen silmez. üst sınıf meto


            /* Lokanta Yazılımı
             * BelediyeHarcOde() isminde metot var
             * Genelde harc ücreti 6 aylık 3000 TL iken aşağıdaki illerde farklılık göstermekte.
             * tokat=2000
             * yozgat = 1500
             * mersin=3500
             * bu iller için polimorfizm yapısını kullanarak farklı metot tanımlayınız.
             * BelediyeHarcOde()
             * {cw ("Harc Ödemesi:3000 Tl'dir.")};*/

            //Belediye bldy = new Belediye();
            //LokantaMersin lkMersin = new LokantaMersin();
            //LokantaTokat lkTokat = new LokantaTokat();
            //LokantaYozgat lkYozgat = new LokantaYozgat();




            //bldy.BelediyeHarcOde();
            //lkMersin.BelediyeHarcOde();
            //lkTokat.BelediyeHarcOde();
            //lkYozgat.BelediyeHarcOde();

            //BelediyeYonetimi belediyeYonetimi = new BelediyeYonetimi(new LokantaMersin());
            //BelediyeYonetimi belediyeYonetimi = new BelediyeYonetimi(new LokantaTokat());
            //BelediyeYonetimi belediyeYonetimi = new BelediyeYonetimi(new LokantaYozgat());
            //belediyeYonetimi.Belediyeler();





            /* Üst Sınıf = Şekil AlanHesapla(),CevreHesapla()
             * Ucgen: yukseklik,taban,kenar1,kenar2
             * Dortgen: en, boy
             * Daire: yariCap, pi=3.14*/

            Dortgen drt = new Dortgen();
            drt._En = 10;
            drt._Boy = 6;

            drt.ALAN();
            drt.CEVRE();

            Daire daire = new Daire();
            daire.yariCap = 5;
            daire.Pi = 3.14;
            daire.ALAN();
            daire.CEVRE();
            

        }
    }
}
