using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = " Karpuz";
            urun2.Fiyati = 20;
            urun2.Aciklama = " Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = " Armut";
            urun3.Fiyati = 5;
            urun3.Aciklama = " Ankara armutu";

            Urun[] urunler = new Urun[]
            {
                urun1,urun2
            };

            foreach ( Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");

            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun2);
        }
    }
}
