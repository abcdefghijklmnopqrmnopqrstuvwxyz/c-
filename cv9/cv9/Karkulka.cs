using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Karkulka : Udalost
    {
        private int _pocetDarku;
        private int _pozice;
        private int _cil;

        public int pocetDarku
        {
            get
            {
                return _pocetDarku;
            }

            set
            {
                _pocetDarku = value;
            }
        }

        public int pozice
        {
            get
            {
                return _pozice;
            }

            set
            {
                _pozice = value;
            }
        }

        public int cil
        {
            get
            {
                return _cil;
            }

            set
            {
                _cil = value;
            }
        }

        public Karkulka()
        {
            this.pocetDarku = 2;
        }

        public void pohyb()
        {
            Console.Write("\nNahoru\nDolu\nPravo\nLevo\n\nPohyb: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Nahoru":
                    
                    break;

                case "Dolu":

                    break;

                case "Pravo":

                    break;

                case "Levo":

                    break;
            }
        }

    }
}