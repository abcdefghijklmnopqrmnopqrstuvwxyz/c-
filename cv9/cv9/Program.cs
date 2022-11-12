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
                Console.Write("\nPočet dárků: " + karkulka.pocetDarku + "/2\n8) Nahoru\n5) Dolu\n6) Doprava\n4) Doleva\n\nPohyb: ");
                try
                {
                    karkulka.pohyb(Int32.Parse(Console.ReadLine()), mapa.mapa);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zadán neplatný formát, pohyb nebyl proveden!");
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                finally
                {
                    Console.WriteLine(mapa.vypis(karkulka));
                }
            }
            //Velikost mapy je základně nastavena na 4, lze ale flexibilně měnit pomocí "private const int _velikostMapy;" ve třídě Mapa
        }
    }
}