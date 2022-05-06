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

        private static int obsazenost = 0;


        public static void PrisliZakaznici()
        {
            int pocet = rd.Next(1,5);
            if (!jeObsazeno(pocet))
            {
                for (int i = 0; i <= pocet - 1; i++)
                {
                    zakaznici.Add(new Clovek());
                }
            }
         
        }

        private static bool jeObsazeno(int pocet)
        {
            return pocet + obsazenost > 50;
        } 



        public static void vypis()
        {
            foreach (Clovek item in zakaznici)
            {
                Console.WriteLine(item.jmeno);
            }
        }
    }
}
