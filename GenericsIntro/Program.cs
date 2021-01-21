using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictionary<int, string> sehirPlakalari = new MyDictionary<int, string>();
            sehirPlakalari.Add(01, "Adana");
            sehirPlakalari.Add(06, "Ankara");
            sehirPlakalari.Add(02, "Adıyaman");
            sehirPlakalari.Add(60, "Tokat");

            foreach (var sehir in sehirPlakalari.Values)
            {
                Console.WriteLine(sehir);
            }
        }
    }
}
