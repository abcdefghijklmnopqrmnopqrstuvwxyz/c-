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

        public Mapa()
        {
            this.map = new int[4, 4];
        }

        public void generacemapy()
        { 
            Random random = new Random();
            for (int i = 0; i < map.Length / 4; i++)
            {
                for (int j = 0; j < map.Length / 4; j++)
                { 
                    int x = random.Next(5);
                    map[i, j] = x;
                }
            }
            map[0, 0] = 10;
            map[3, 3] = 20;
        }

        public string vypis()
        {
            string r = "";
            for (int i = 0; i < map.Length / 4; i++)
            {
                for (int j = 0; j < map.Length / 4; j++)
                {
                    r += map[i, j] + "   ";
                }
                r += "\n\n";
            }
            return r;
        }

        public void pohyb()
        {
            vypis();
            Console.WriteLine("\nNahoru\nDolu\nPravo\nLevo\n\nPohyb:");
            string x = Console.ReadLine();

            switch(x)
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