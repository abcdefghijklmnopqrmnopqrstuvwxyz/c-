using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Karkulka
    {
        private int _PocetDarku;
        private int _Pozice;

        public int PocetDarku
        {
            get
            {
                return _PocetDarku;
            }

            set
            {
                _PocetDarku = value;
            }
        }

        public int Pozice
        {
            get
            {
                return _Pozice;
            }

            set
            {
                _Pozice = value;
            }
        }

        public Karkulka()
        {
            Random random = new Random();
            PocetDarku = 2;
            Pozice = random.Next(16);
        }

    }
}