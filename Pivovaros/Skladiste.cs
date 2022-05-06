using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
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
                CoChybi(chmel, slad, voda, kvasinky);
                return false;
            }
        }

        public static void OdeberSuroviny(float chmel, float slad, float voda, float kvasinky)
        {
            Chmel -= chmel;
            Slad -= slad;
            Voda -= voda;
            Kvasinky -= kvasinky;

            Console.WriteLine(Chmel.ToString() +" "+ Slad.ToString() + " " + Voda.ToString() + " " + Kvasinky.ToString());
        }

        private static void CoChybi(float chmel, float slad, float voda, float kvasinky)
        {
            List<string> coNemam = new List<string>();
            if (Chmel < chmel) coNemam.Add("Chmel");
            if (Slad < slad) coNemam.Add("Slad");
            if (Voda < voda) coNemam.Add("voda");
            if (Kvasinky < kvasinky) coNemam.Add("Kvasinky");

            if (coNemam.Count == 0)
            {
                Console.WriteLine("Mám vše");
            }
            else
            {
                String text = "Nemám:";
                foreach (string item in coNemam)
                {
                    text += " " + item;
                }
                Console.WriteLine(text);
            }
        } 
    
    }
}
