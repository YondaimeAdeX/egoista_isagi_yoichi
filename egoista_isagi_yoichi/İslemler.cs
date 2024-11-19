using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egoista_isagi_yoichi
{
    class İslemler
    {
        double sayi1;
        double sayi2;

        public İslemler(double sayi1, double sayi2)
        {
            this.sayi1 = sayi1;
            this.sayi2 = sayi2;
        }

        public double Topla() 
        {
            double topla = sayi1 + sayi2;
            return topla;
        }

        public double Cıkar()
        {
            double cıkar = sayi1 - sayi2;
            return cıkar;
        }

        public double Carp()
        {
            double carp = sayi1 * sayi2;
            return carp;
        }

        public double Bolme()
        {
            double bolme = sayi1 / sayi2;
            return bolme;
        }
    }
}
