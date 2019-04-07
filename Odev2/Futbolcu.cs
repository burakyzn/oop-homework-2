using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    abstract class Futbolcu
    {
        public string AdSoyad { get; set; }
        public int FormaNo { get; set; }
        public int Hiz { get; set; }
        public int Dayaniklik { get; set; }
        public int Pas { get; set; }
        public int Sut { get; set; }
        public int Yetenek { get; set; }
        public int Kararlilik { get; set; }
        public int DogalForm { get; set; }
        public int Sans { get; set; }

        public Futbolcu(string AdSoyad, int FormaNo)
        {
            this.AdSoyad = AdSoyad;
            this.FormaNo = FormaNo;

            Random rastgele = new Random();

            Hiz = rastgele.Next(49, 100);
            Dayaniklik = rastgele.Next(49, 100);
            Pas = rastgele.Next(49, 100);
            Sut = rastgele.Next(49, 100);
            Yetenek = rastgele.Next(49, 100);
            Kararlilik = rastgele.Next(49, 100);
            DogalForm = rastgele.Next(49, 100);
            Sans = rastgele.Next(49, 100);
        }

        public abstract bool PasVer();
        public abstract bool GolVurusu();
           
    }
}
