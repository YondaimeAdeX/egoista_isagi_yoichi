using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egoista_isagi_yoichi
{
    class Dikdortgen
    {
        int en;
        int boy;

        public Dikdortgen(int en, int boy)
        {
            this.en = en;
            this.boy = boy;
        }

        public int CevreHesapla()
        {
            int cevre = 2 * + (en + boy);
            return cevre;
        }

        public int AlanHesapla() 
        {
            int alan = en * boy;
            return alan;
        }
    }
}
