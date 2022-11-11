namespace cv9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mapa mapa = new();
            Karkulka karkulka = new();

            mapa.generacemapy(karkulka);
            Console.WriteLine(mapa.vypis(karkulka));

            while (karkulka.pocetDarku > 0)
            {
                Console.Write("\nNahoru\nDolu\nDoprava\nDoleva\n\nPohyb: ");
                try
                {
                    karkulka.pohyb(Console.ReadLine(), mapa.mapa);
                }
                catch(Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    Console.WriteLine(mapa.vypis(karkulka));
                }
            }
            

        }
    }
}