using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary");
            Dictionary<int, string> sehirPlakalari = new Dictionary<int, string>();
            sehirPlakalari.Add(01, "Adana");
            sehirPlakalari.Add(02, "Adıyaman");
            sehirPlakalari.Add(06, "Ankara");

            Console.WriteLine(sehirPlakalari.Count);
            foreach (var sehir in sehirPlakalari)
            {
                Console.WriteLine(sehir.Value +" "+ sehir.Key);
            }

          

        }
    }

   class MyDictionary<K, T>
    {

    }

    
}
