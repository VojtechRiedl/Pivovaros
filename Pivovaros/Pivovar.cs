using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivovar
    {
        public static int pocetPiva { get; set; }
        public static Dictionary<string, int> pivoDic = new Dictionary<string, int>()
        {
            {"10", 0},
            {"11", 0},
            {"12", 0}
        };
        //TODO dodělat počet lidí, pivka, pití

        public static void VyrobPivo(float chmel, float slad, float voda, float kvasinky, string nazev)
        {
            if (Skladiste.ZjistiZasoby(chmel, slad, voda, kvasinky) == true)
            {
                PridejPivko(nazev);
                Skladiste.OdeberSuroviny(chmel, slad, voda, kvasinky);
            }
        }
        private static void PridejPivko(string nazev)
        {
            if (nazev == "Pivo 10°")
            {
                pivoDic["10"] += 1;
                pocetPiva++;
                Console.WriteLine("pivo10 vyrobeno! :)");

            }
            else if (nazev == "Pivo 11°")
            {
                pivoDic["11"] += 1;
                pocetPiva++;
                Console.WriteLine("pivo11 vyrobeno! :)");

            }
            else if (nazev == "Pivo 12°")
            {
                pivoDic["12"] += 1;
                pocetPiva++;
                Console.WriteLine("pivo12 vyrobeno! :)");

            }
        }
        public static bool MameDostatekPivca()
        {
            if (pocetPiva != 0 && pocetPiva >= 5) return true;

            return false;
        }
        public static bool MameDostatekPivca(string jmeno)
        {
            if (pivoDic[jmeno] >= 1) return true;

            return false;
        }
        static void OdeberPivko(string nazev)
        {
            if (nazev == "Pivo 10°")
            {
                pivoDic["10"] -= 1;
            }
            else if (nazev == "Pivo 11°")
            {
                pivoDic["11"] -= 1;
            }
            else if (nazev == "Pivo 12°")
            {
                pivoDic["12"] -= 1;
            }
        }
        
    }
}

        //TODO odebirani pivka atd
