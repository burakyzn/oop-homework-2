using System;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Futbolcu> takim = new List<Futbolcu>();

            takim.Add(new Kaleci("Cahit Arf", 1));
            takim.Add(new Defans("Wilhelm Rontgen", 2));
            takim.Add(new Defans("Thomas Edison", 3));
            takim.Add(new Defans("Michael Faraday", 4));
            takim.Add(new Defans("Werner Heisenberg", 5));
            takim.Add(new OrtaSaha("Aziz Sancar", 6));
            takim.Add(new OrtaSaha("Ali Kuþçu", 7));
            takim.Add(new OrtaSaha("Albert Einstein", 8));
            takim.Add(new Forvet("Nikola Tesla", 9));
            takim.Add(new Forvet("Isaac Newton", 10));

            int formaNo = 0;
            int pasAtanFormaNo;
            bool macKazanildimi = false;
            Random rastgeleFormaNo = new Random();
            for (int i = 0; i < 3; i++)
            {
                pasAtanFormaNo = formaNo;

                do
                    formaNo = rastgeleFormaNo.Next(0, 10);
                while (pasAtanFormaNo == formaNo);

                if (i == 2)
                {
                    if (takim[formaNo].GolVurusu())
                    {
                        Console.WriteLine("GOOOOOLLLL GOOOOOLLL " + takim[formaNo].AdSoyad + "\'dan muhtesem bir gol!");
                        macKazanildimi = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(takim[formaNo].AdSoyad + "\'in gol denemesi basarisiz top kaleyi bulmadi.");
                        break;
                    }
                }

                if (takim[formaNo].PasVer())
                    Console.WriteLine(takim[formaNo].AdSoyad + "\'in pas denemesi basarili.");
                else
                {
                    Console.WriteLine(takim[formaNo].AdSoyad + "\'in pas denemesi basarisiz top karsi takima gecti.");
                    break;
                }

            }

            if (macKazanildimi)
                Console.WriteLine("Maç 1-0 skor ile kazanildi.");
            else
                Console.WriteLine("Maç Kaybedildi.");

        }
    }
}
