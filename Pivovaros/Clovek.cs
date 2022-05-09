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
        public string jmeno { get; set; }//jméno
        private int vek { get; set; } //jeho věk
        public int zustatek { get; private set; }//počet peněz
        public int pocetPiv { get; set; } //kolik vypil piv
        private float naladaCislo { get; set; } //Range 0-100 pro náladu
        private int maxPiv { get; set; }
        private bool nalada { get; set; } //Dobrá - špatná

        public Clovek() {
            jmeno = jmena[rd.Next(jmena.Length)];
            vek = rd.Next(18,50);
            zustatek = rd.Next(200, 1500);
            pocetPiv = 0;
            maxPiv = rd.Next(5, 15);
            naladaCislo = rd.Next(0, 100);
            if (naladaCislo < 50)
            {
                nalada = false;
            }
            else {
                nalada = true;
            }

        }

        public bool CasOdejit()
        {
            if (maxPiv <= pocetPiv || !nalada) return true;

            return false;
        }
    }
}
