namespace cv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mapa map = new Mapa();
            Karkulka karkulka = new Karkulka();
            map.generacemapy(karkulka);

            while(karkulka.pocetDarku > 0)
            {
                Console.WriteLine(map.vypis(karkulka));
                karkulka.pohyb();
            }
            

        }
    }
}