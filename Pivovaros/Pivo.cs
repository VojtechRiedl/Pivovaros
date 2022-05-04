using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
    internal class Pivo
    {
        protected int rychlostVyroby { get; set; }
        protected float chmel { get; set; }
        protected float voda { get; set; }
        protected float slad { get; set; }
        protected float kvasinky { get; set; }
        protected string nazev { get; set; }

        protected Random rnd = new Random();

        virtual public void Recept() {
            chmel = 200f;
            voda = 500f;
            slad = 150f;
            kvasinky = 180f;
        }
    
    }
}
