using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Karkulka : Udalost
    {
        private int _pocetDarku, _pozice, _cil;

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

        public void pohyb(string input, int[,] mapa)
        {
            Exception ex = new Exception("Vybraný tah vede mimo mapu, pohyb nebyl proveden!");
            int x = 0;
            int velikostMapy = (int) Math.Sqrt(mapa.Length);
            for (int i = 0; i < velikostMapy * velikostMapy; i++)
            {
                if (pozice >= i * velikostMapy && pozice <= velikostMapy * velikostMapy)
                {
                    x++;
                }
            }

            switch (input)
            {
                case "Nahoru":
                    if (pozice - 4 >= 0)
                    {
                        pozice -= 4;
                    }
                    else 
                    {
                        throw ex;
                    }
                    break;

                case "Dolu":
                    if (pozice + 4 < velikostMapy * velikostMapy)
                    {
                        pozice += 4;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;

                case "Doprava":
                    if (pozice + 1 < x * velikostMapy)
                    {
                        pozice += 1;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;

                case "Doleva":
                    if (pozice - 1 >= x * velikostMapy - velikostMapy)
                    {
                        pozice -= 1;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;
            }
        }

    }
}