using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovar_2ITB
{
    class Skladiste
    {
        static float chmel = 50000f;
        public static float Chmel { get { return chmel; } private set { chmel = value; } }
        static float slad = 50000f;
        public static float Slad { get { return slad; } private set { slad = value; } }
        static float voda = 50000f;
        public static float Voda { get { return voda; } private set { voda = value; } }
        static float kvasinky = 50000f;
        public static float Kvasinky { get { return kvasinky; } private set { kvasinky = value; } }

        public static bool ZjistiZasoby(float chmel, float slad, float voda, float kvasinky)
        {
            if (Chmel > chmel && Slad > slad && Voda > voda && Kvasinky > kvasinky)
            {
                return true;
            }
            else
            {
                //TODO dodělat výpis chybějících surovin
                return false;
            }
        }
    
    }
}
