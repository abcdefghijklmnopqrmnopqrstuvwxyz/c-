using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal class Mapa
    {
        private int[,] map;
        private const int velikostMapy = 4;

        public Mapa()
        {
            this.map = new int[velikostMapy, velikostMapy];
        }

        public void generacemapy(Karkulka k)
        { 
            Random random = new Random();
            for (int i = 0; i < map.Length / velikostMapy; i++)
            {
                for (int j = 0; j < map.Length / velikostMapy; j++)
                { 
                    int x = random.Next(5);
                    map[i, j] = x;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                int x = random.Next(0) + i * 3;
                int y = random.Next(map.Length / velikostMapy);
                if (map[x, y] != 10 && map[x, y] != 20)
                {
                    map[x, y] = (i + 1) * 10;
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
            string r = "\n";
            for (int i = 0; i < map.Length / velikostMapy; i++)
            {
                for (int j = 0; j < map.Length / velikostMapy; j++)
                {
                    if (k.pozice.Equals(i * velikostMapy + j))
                    {
                        r += "[Karkulka]        ";
                        continue;
                    }
                    switch (map[i, j])
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
                r += "\n\n\n";
            }
            return r;
        }

    }
}