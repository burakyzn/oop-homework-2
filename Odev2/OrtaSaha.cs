using System;

namespace Odev2
{
    class OrtaSaha : Futbolcu
    {
        public int UzunTop { get; set; }
        public int IlkDokunus { get; set; }
        public int Uretkenlik { get; set; }
        public int TopSurme { get; set; }
        public int OzelYetenek { get; set; }

        public OrtaSaha(string AdSoyad, int FormaNo):base(AdSoyad,FormaNo)
        {
            Random rastgele = new Random();

            UzunTop = rastgele.Next(59, 100);
            IlkDokunus = rastgele.Next(59, 100);
            Uretkenlik = rastgele.Next(59, 100);
            TopSurme = rastgele.Next(59, 100);
            OzelYetenek = rastgele.Next(59, 100);
            
        }

        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;

            if (PasSkor > 60)
                return true;
            
            return false;
        }

        public override bool GolVurusu()
        {

            double GolSkor = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;

            if (GolSkor > 70)
                return true;
            
            return false;
        }
    }
}
