using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
    internal class Clovek
    {
        Random rnd = new Random();
        string jmeno; //jméno
        int vek; //jeho věk
        int zustatek; //počet peněz
        int pocetPiv; //kolik vypil piv
        float naladaCislo; //Range 0-100 pro náladu
        bool nalada; //Dobrá - špatná

        public Clovek(string jmeno, int vek) {
            this.jmeno = jmeno;
            this.vek = vek;
            zustatek = rnd.Next(200, 1500);
            pocetPiv = 0;
            naladaCislo = rnd.Next(0, 100);
            if (naladaCislo <  50)
            {
                nalada = false;
            }
            else {
                nalada = true;
            }
        }
    }
}
