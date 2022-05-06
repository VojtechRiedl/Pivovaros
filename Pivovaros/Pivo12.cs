using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo12 : Pivo
    {
        public new static int rychlostVyroby { get; private set; } = 10;
        private new static float slad { get;  set; }
        private new static float voda { get;  set; } 
        private new static float chmel { get;  set; }
        private static string nazev { get; set; }


        public static void Recept()
        {
            slad = 130f;
            chmel = 300f;
            voda = 100f;
            nazev = "Pivo 12°";

            Pivovar.VyrobPivo(chmel, slad, voda, kvasinky, nazev);


        }


    }
}
