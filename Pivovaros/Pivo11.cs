using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo11 : Pivo
    {
        public new static int rychlostVyroby { get; private set; } = 7;
        private new static float slad { get; set; }
        private new static float kvasinky { get; set; }
        private new static float chmel { get; set; }
        private static string nazev { get; set; }

        public static void Recept()
        {
            slad = 130f;
            chmel = 230f;
            nazev = "Pivo 11°";
            kvasinky = 300f;
            Pivovar.VyrobPivo(chmel, slad, voda, kvasinky, nazev);


        }
    }
}
