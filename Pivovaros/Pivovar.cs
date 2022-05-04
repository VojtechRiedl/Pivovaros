using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
    internal class Pivovar
    {
        public int pocetPiva { get; set; }
        static Dictionary<string, int> pivoDic = new Dictionary<string, int>()
        {
            {"10", 0},
            {"11", 0},
            {"12", 0}
        };
        //TODO dodělat počet lidí, pivka, pití

        public static void VyrobPivo(float chmel, float slad, float kvasinky, float voda, int rychlostVyroby, string nazev)
        {
            if (Skladiste.ZjistiZasoby(chmel, slad, kvasinky, voda) == true)
            {
                PridejPivko(nazev);
            }
        }
        static void PridejPivko(string nazev)
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
    }
}

        //TODO odebirani pivka atd
