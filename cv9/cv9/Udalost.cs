using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv9
{
    internal abstract class Udalost : Mapa
    {
        private int obnovenoDarku = 0;
        private bool vlkAktivni = false;

        public bool prekazka()
        {
            Random random = new();
            string spatne = "\nNa otázku jsi odpověděl špatně, naštěstí tě zachránil kolemjdoucí myslivec s dřevorubcem.\nNa oplátku jsi jim ale musel dát jeden ze svých dárků, musíš tedy jít na louku a natrhat babičce hříbky!";
            string spravne = "\nNa otázku jsi odpověděl správně, nyní můžeš pokračovat!";

            switch (_ = random.Next(3))
            {
                case 0:
                    Console.Write("\nProgramátorská konstrukce try-catch-(finally) se v C# používá na:\n1) Ukončení cyklu\n2) Odchycení vyjímky\n3) V C# nic takového neexistuje\n4) Zavolání konstruktoru\n\nOdpověď: ");
                    if (Int32.Parse(Console.ReadLine()).Equals(2))
                    {
                        Console.WriteLine(spravne);
                        return true;
                    }
                    Console.WriteLine(spatne);
                    return false;
                    break;
                case 1:
                    Console.Write("\nKterá vlastnost může být použita k nalezení délky řetězce?\n1) getLenght()\n2) lenght\n3) Lenght\n4) lenght()\n\nOdpověď: ");
                    if (Int32.Parse(Console.ReadLine()).Equals(3))
                    {
                        Console.WriteLine(spravne);
                        return true;
                    }
                    Console.WriteLine(spatne);
                    return false;
                    break;
                default:
                    Console.Write("\nJak můžeme volat metodu v C#?\n1) MyMethod();\n2) MyMethod;\n3) (MyMethod);\n4) MyMethod[];\n\nOdpověď: ");
                    if (Int32.Parse(Console.ReadLine()).Equals(1))
                    {
                        Console.WriteLine(spravne);
                        return true;
                    }
                    Console.WriteLine(spatne);
                    return false;
            }
        }

        public string vyhlidka()
        {
            return "\nVyhlídka - pohled do krajiny:\nCelá krajina září, paprsky slunce dopadají na zelené louky.\nČistá, nedotčená a všemi barvami hrající příroda, právě tak se mi představuje v celé své kráse.\nV této krajině vnímáte každý pohyb a nepřehlédnete ani toho mravenečka, který nehlučně našlapuje na stéblech trávy.\nNení nad krásu stromů, kterými je vysázena, není nad četnost zvířat, kterými je obdařena a snad nebude dne, kdy těmito dary nikdy víc nebude oplývat.\nTakto vypadá krajina, jenž je vidět z vyhlídky.";
        }

        public int bludnyKoren(int[,] mapa)
        {
            Console.WriteLine("Šlápl jsi na políčko bludný kořen, který tě přesunul na nějaké náhodné políčko na mapě.");

            Random random = new();
            int x = random.Next((int) Math.Sqrt(mapa.Length));
            int y = random.Next((int) Math.Sqrt(mapa.Length));

            while (10 == mapa[x, y] || 20 == mapa[x, y])
            {
                x = random.Next((int) Math.Sqrt(mapa.Length));
                y = random.Next((int) Math.Sqrt(mapa.Length));
            }

            return x * velikostMapy + y;
        }

        public int kvetinovaLouka(int pocetDarku)
        {
            Console.Write("\nNa louce můžeš nahradit jeden ze svých dárků.\nk babičce musíš donést oba dva dárky, pokud jsi jeden po cestě ztratil, můžeš ho zde nahradit.\nAle pozor.. pokud jsi po cestě potkal vlka, moc se zdržíš a vlk sežere babičku!\n\nPřeješ si tedy nasbírat pro babičku hříbky a nahradit tak jeden dárek?\n1) Ano\n2) Ne\n\nOdpověď: ");
            if(Int32.Parse(Console.ReadLine()) == 1)
            {
                if (pocetDarku != 2 && obnovenoDarku <= 1)
                {
                    if (vlkAktivni)
                    {
                        Console.WriteLine("\nPříliš jsi se zdrřel na louce a vlk dorazil k babičce dříve než ty a sežral ji!");
                        Environment.Exit(0);
                    }
                    obnovenoDarku++;
                    return 1;
                }
                else
                {
                    Console.WriteLine("\nMáš již plný počet dárku, žádný tedy nebyl nahrazen!");
                }
            }
            return 0;
        }

        public void vlk()
        {
            vlkAktivni = true;
            Console.WriteLine("Přišel jsi na políčko s vlkem, moc se nesdržuj na květinové louce.\nJinak vlk přijde k babičce první s sežere ji!");
        }

        public void babicka(int pocetDarku)
        {
            if (pocetDarku == 2)
                Console.WriteLine("Dárky byly úspěšně doručeny babičce, gratuluji k výhře!");
            else
                Console.WriteLine("Bohužel nemáš dostatečný počet dárků, hodně štěstí v příští hře!");
            Environment.Exit(0);
        }

    }
}