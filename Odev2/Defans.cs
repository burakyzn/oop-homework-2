using System;

namespace Odev2
{
    class Defans : Futbolcu
    {
        public int PozisyonAlma { get; set; }
        public int Kafa { get; set; }
        public int Sicrama { get; set; }

        public Defans(string AdSoyad, int FormaNo):base(AdSoyad,FormaNo)
        {
            Random rastgele = new Random();

            PozisyonAlma = rastgele.Next(49, 90);
            Kafa = rastgele.Next(49, 90);
            Sicrama = rastgele.Next(49, 90);
        }

        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;

            if (PasSkor > 60)
                return true;

            return false;
        }

        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;

            if (GolSkor > 70)
                return true;

            return false;
        }
    }
}
