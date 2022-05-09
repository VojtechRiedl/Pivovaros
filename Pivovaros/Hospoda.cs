using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Hospoda
    {
        private static Random rd = new Random();
        public static List<Clovek> zakaznici = new List<Clovek>();
        public static Dictionary<string, int> pivoSklad = new Dictionary<string, int>()
        {
            {"10", 0},
            {"11", 0},
            {"12", 0}
        };



        public static void PrisliZakaznici()
        {
            int pocet = rd.Next(1,5);
            if (!JeObsazeno(pocet))
            {
                Console.WriteLine(pocet);
                for (int i = 0; i <= pocet - 1; i++)
                {
                    zakaznici.Add(new Clovek());
                }
            }
         
        }

        public static void OdejdouZakaznici()
        {
            if (JeNekdoVHospode())
            {
                for (int i = 0; i < zakaznici.Count; i++)
                {
                    if (zakaznici[i].CasOdejit())
                    {
                        zakaznici.RemoveAt(i);
                    }
                }
            }
        }

        private static bool JeObsazeno(int pocet)
        {
            return pocet + zakaznici.Count > 50;
        } 
        private static bool JeNekdoVHospode()
        {
            return zakaznici.Count > 0;
        }
        public static void CasPit()
        {
            if (JeNekdoVHospode())
            {
                zakaznici[rd.Next(zakaznici.Count)].pocetPiv++;
                int index = rd.Next(Hospoda.pivoSklad.Count);
                if (Hospoda.pivoSklad.Keys.ElementAt(index) == "10")
                {
                    Hospoda.pivoSklad["10"] -= 1;
                }else if(Hospoda.pivoSklad.Keys.ElementAt(index) == "11")
                {
                    Hospoda.pivoSklad["11"] -= 1;

                }
                else if (Hospoda.pivoSklad.Keys.ElementAt(index) == "12")
                {
                    Hospoda.pivoSklad["12"] -= 1;

                }

            }
        }

        public static bool PotrebujemePivco()
        {
            int celkemPivca = 0 ;
            foreach (var pivo in pivoSklad)
            {
                if(pivo.Value > 0)
                {
                    celkemPivca += pivo.Value;
                }
            }
            if (celkemPivca == 0) return true;
            return false;
        }

        public static void vypis()
        {
            foreach (Clovek zakaznik in zakaznici)
            {
                Console.WriteLine(zakaznik.jmeno);
                Console.WriteLine("Obsazenost je:" + zakaznici.Count);
            }
        }

    }
}
