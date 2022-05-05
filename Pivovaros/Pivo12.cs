using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo12 : Pivo
    {

        public static int rychlostVyroby { get; private set; } = 10;
        public new static void Recept()
        {
            slad = 130f;
            chmel = 300f;
            voda = 100f;
            nazev = "Pivo 12°";
            Pivovar.VyrobPivo(chmel, slad, kvasinky, voda, nazev);

            Console.WriteLine("pivo12 vyrobeno! :)");

        }
    }
}
