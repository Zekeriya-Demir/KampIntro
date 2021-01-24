using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKredi = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            
            BasvuruManager basvuruManager = new BasvuruManager();
            // basvuruManager.BasvuruYap(ihtiyacKredi);
            // Tekil gönderdik
            // basvuruManager.BasvuruYap(new KonutKrediManager(), new FileLoggerService()); // Alternatif instance oluşturma

            // Liste Halinde gönderelim. Alternatif listeleme ile.
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> {new DatabaseLoggerService(), new FileLoggerService() });


            // Tüm kredi hesaplamalarını liste halide görelim.
            List<IKrediManager> krediManagers = new List<IKrediManager> {ihtiyacKredi, tasitKrediManager, new KonutKrediManager() };
            basvuruManager.KrediOnbilgilendirmesiYap(krediManagers);
            
        }
    }
}
