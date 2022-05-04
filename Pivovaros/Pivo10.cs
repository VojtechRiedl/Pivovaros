using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
     class Pivo10 : Pivo, IPivo
    {
        public override void Recept()
        {
            chmel = 120f;
            voda = 750f;
            kvasinky = 200f;
            slad = 110f;
            nazev = "Pivo 10°";
            Pivovar.VyrobPivo(chmel, slad, kvasinky, voda, RychlostVyrobyPiva(5), nazev);
        }

        public int RychlostVyrobyPiva(int sec)
        {
            rychlostVyroby = rnd.Next(2, sec);
            return rychlostVyroby;
        }

        
    }
}
