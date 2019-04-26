using System;
using System.Collections.Generic;

namespace Odev2
{
    class Mac
    {
        List<Futbolcu> takim = new List<Futbolcu>();
        bool macKazanildimi;
        public Mac(string[] futbolcular)
        {
            takim.Add(new Kaleci(futbolcular[0], 1));
            takim.Add(new Defans(futbolcular[1], 2));
            takim.Add(new Defans(futbolcular[2], 3));
            takim.Add(new Defans(futbolcular[3], 4));
            takim.Add(new Defans(futbolcular[4], 5));
            takim.Add(new OrtaSaha(futbolcular[5], 6));
            takim.Add(new OrtaSaha(futbolcular[6], 7));
            takim.Add(new OrtaSaha(futbolcular[7], 8));
            takim.Add(new Forvet(futbolcular[8], 9));
            takim.Add(new Forvet(futbolcular[9], 10));
            macKazanildimi = false;
        }

        public void maciOynat()
        {
            int formaNo = 0;
            int pasAtanFormaNo;
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

            macSonucuYazdir();
        }

        private void macSonucuYazdir()
        {
            if (macKazanildimi)
                Console.WriteLine("Maç kazanildi. TEBRIKLER !!!");
            else
                Console.WriteLine("Maç Kaybedildi.");
        }
    }
}
