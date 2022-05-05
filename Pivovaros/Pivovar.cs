using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivovar
    {
        public int pocetPiva { get; set; }
        public static Dictionary<string, int> pivoDic = new Dictionary<string, int>()
        {
            {"10", 0},
            {"11", 0},
            {"12", 0}
        };
        //TODO dodělat počet lidí, pivka, pití

        public static void VyrobPivo(float chmel, float slad, float voda, float kvasinky, string nazev)
        {
            if (Skladiste.ZjistiZasoby(chmel, slad, voda, kvasinky))
            {
                PridejPivko(nazev);
                Console.WriteLine("odebralo se: " + kvasinky);
                Skladiste.odeberSuroviny(chmel, slad, voda, kvasinky);
            }
        }
        private static void PridejPivko(string nazev)
        {
            if (nazev == "Pivo 10°")
            {
                pivoDic["10"] += 1;
            }
            else if (nazev == "Pivo 11°")
            {
                pivoDic["11"] += 1;
            }
            else if (nazev == "Pivo 12°")
            {
                pivoDic["12"] += 1;
            }
        }
        static void odeberPivko(string nazev)
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
