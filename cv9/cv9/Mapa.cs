using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Mapa
    {
        private int[,] _mapa;
        private const int _velikostMapy = 4;

        public int velikostMapy
        {
            get
            {
                return _velikostMapy;
            }
        }

        public int[,] mapa
        {
            get
            {
                return _mapa;
            }

            set
            { 
                _mapa = value;
            }
        }

        public Mapa()
        {
            this.mapa = new int[velikostMapy, velikostMapy];
        }

        public void generacemapy(Karkulka k)
        { 
            Random random = new();
            for (int i = 0; i < mapa.Length / velikostMapy; i++)
            {
                for (int j = 0; j < mapa.Length / velikostMapy; j++)
                { 
                    int x = random.Next(5);
                    mapa[i, j] = x;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                int x = random.Next(0) + i * 3;
                int y = random.Next(mapa.Length / velikostMapy);
                if (mapa[x, y] != 10 && mapa[x, y] != 20)
                {
                    mapa[x, y] = (i + 1) * 10;
                    if (i == 0)
                    {
                        k.pozice = y;
                    }
                    k.cil = x * velikostMapy + y;
                }
                else
                {
                    i--;
                }
            }
        }

        public string vypis(Karkulka k)
        {
            string r = "\n\n\n\n\n";
            for (int i = 0; i < mapa.Length / velikostMapy; i++)
            {
                for (int j = 0; j < mapa.Length / velikostMapy; j++)
                {
                    if (k.pozice.Equals(i * velikostMapy + j))
                    {
                        r += "[Karkulka]        ";
                        continue;
                    }
                    switch (mapa[i, j])
                    { 
                        case 0:
                            r += "Překážka          ";
                            break;
                        case 1:
                            r += "Vyhlídka          ";
                            break;
                        case 2:
                            r += "Bludný kořen      ";
                            break;
                        case 3:
                            r += "Květinová louka   ";
                            break;
                        case 4:
                            r += "Vlk               ";
                            break;
                        case 10:
                            r += "Domov Karkulky    ";
                            break;
                        case 20:
                            r += "Domov babičky     ";
                            break;
                    }
                }
                r += "\n\n";
            }
            return r;
        }

    }
}