using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
     class Pivo10 : Pivo
    {

        public static int rychlostVyroby { get; private set; } = 5;

        public new static void Recept()
        {
            chmel = 120f;
            voda = 750f;
            kvasinky = 200f;
            slad = 110f;
            nazev = "Pivo 10°";
            Pivovar.VyrobPivo(chmel, slad, kvasinky, voda, nazev);

            Console.WriteLine("pivo10 vyrobeno! :)");

        }



        
    }
}
