using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Pivo
    {
        protected static float chmel { get; set; }
        protected static float voda { get; set; }
        protected static float slad { get; set; }
        protected static float kvasinky { get; set; }
        protected static string nazev { get; set; }

        protected Random rnd = new Random();

        public static void Recept() {
            chmel = 200f;
            voda = 500f;
            slad = 150f;
            kvasinky = 2000f;
        }
    
    }
}
