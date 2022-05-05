using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo11 : Pivo
    {
        public static int rychlostVyroby { get; private set; } = 7;

        public new static void Recept()
        {
            slad = 130f;
            chmel = 230f;
            nazev = "Pivo 11°";
            Pivovar.VyrobPivo(chmel, slad, kvasinky, voda, nazev);

            Console.WriteLine("pivo11 vyrobeno! :)");


        }
    }
}
