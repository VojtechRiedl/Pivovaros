using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
     class Pivo10 : Pivo
    {
        public new static int rychlostVyroby { get; private set; } = 5;
        private new static float slad { get; set; }
        private new static float voda { get; set; }
        private new static float chmel { get; set; }
        private new static float kvasinky { get; set; }

        private static string nazev { get; set; }

        public static void Recept()
        {
            chmel = 120f;
            voda = 750f;
            kvasinky = 200f;
            slad = 110f;
            nazev = "Pivo 10°";
            Pivovar.VyrobPivo(chmel, slad, voda, kvasinky, nazev);

        }




    }
}
