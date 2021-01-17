using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre Altunbilek";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Kotlin";
            kurs3.Egitmen = "Atıl Samancıoğlu";
            kurs3.IzlenmeOrani = 90;


            Kurs[] kurslar = new Kurs[] 
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(" Kurs Adı: "+kurs.KursAdi);
                Console.WriteLine(" Eğitmeni: " + kurs.Egitmen);
                Console.WriteLine(" İzlenme Oranı: " + kurs.IzlenmeOrani);
                Console.WriteLine("----------------------------------");

            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
