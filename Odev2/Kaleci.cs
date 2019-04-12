
namespace Odev2
{
    class Kaleci:Futbolcu
    {
        public Kaleci(string AdSoyad, int FormaNo) : base(AdSoyad, FormaNo){}

        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklik * 0.1 + DogalForm * 0.1 +
                         Sans * 0.2;
    
            if (PasSkor > 60)
                return true;

            return false;
        }

        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 +
                    Hiz * 0.1 + Sans * 0.2;

            if (GolSkor > 70)
                return true;

            return false;
        }
    }
}
