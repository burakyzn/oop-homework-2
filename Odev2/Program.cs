using System;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] futbolcular = { "Cahit Arf", "Wilhelm Rontgen", "Thomas Edison", "Michael Faraday",
                                    "Werner Heisenberg", "Aziz Sancar", "Ali Ku��u", "Albert Einstein",
                                    "Nikola Tesla", "Isaac Newton"};

            Mac dostlukMac� = new Mac(futbolcular);
            dostlukMac�.maciOynat();
        }
    }
}
