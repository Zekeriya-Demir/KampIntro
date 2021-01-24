using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123456";
            musteri1.Adi = "Zekeriya";
            musteri1.Soyadi = "Demir";
            musteri1.TcNo = "12345678910";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "6789";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "2525245";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);            
            musteriManager.Ekle(musteri2);




        }
    }
}
