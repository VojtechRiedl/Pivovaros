using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Clovek
    {
        private static string[] jmena = { "Břetislav","Nikola","Evžen","Pepa", "Tomáš", "Veronika", "Miroslav", "Michal", "Petra"};
        private Random rd = new Random();
        public string jmeno; //jméno
        int vek; //jeho věk
        int zustatek; //počet peněz
        int pocetPiv; //kolik vypil piv
        float naladaCislo; //Range 0-100 pro náladu
        bool nalada; //Dobrá - špatná

        public Clovek() {
            jmeno = jmena[rd.Next(jmena.Length)];
            vek = rd.Next(18,50);
            zustatek = rd.Next(200, 1500);
            pocetPiv = 0;
            naladaCislo = rd.Next(0, 100);
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
