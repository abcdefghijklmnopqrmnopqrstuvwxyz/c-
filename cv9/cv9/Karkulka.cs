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

        public void pohyb(int input, int[,] mapa)
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
                case 8:
                    if (pozice - 4 >= 0)
                    {
                        pozice -= 4;
                    }
                    else 
                    {
                        throw ex;
                    }
                    break;

                case 5:
                    if (pozice + 4 < velikostMapy * velikostMapy)
                    {
                        pozice += 4;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;

                case 6:
                    if (pozice + 1 < x * velikostMapy)
                    {
                        pozice += 1;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;

                case 4:
                    if (pozice - 1 >= x * velikostMapy - velikostMapy)
                    {
                        pozice -= 1;
                    }
                    else
                    {
                        throw ex;
                    }
                    break;
                default:
                    throw ex;
            }

            switch (mapa[(int)pozice / velikostMapy, (int)pozice % velikostMapy]) 
            {
                case 0:
                    if (!prekazka())
                        pocetDarku--;
                    break;
                case 1:
                    Console.WriteLine(vyhlidka());
                    break;
                case 2:
                    pozice = bludnyKoren(mapa);
                    break;
                case 3:
                    pocetDarku += kvetinovaLouka(pocetDarku);
                    break;
                case 4:
                    vlk();
                    break;
                case 20:
                    babicka(pocetDarku);
                    break;
                default:
                    Console.WriteLine("Nyní jsi u sebe, dones dárečky do babiččina domečku.");
                    break;
            }
        }

    }
}