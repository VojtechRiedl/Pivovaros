using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pivovaros
{
    internal class Cas
    {
        private static Random rd = new Random();
        private static int DalsiZakaznici = rd.Next(1,11);
        private static int ZakazniciPapa = rd.Next(10,20);

        private static int counter = 0;


        public static void HerniCas()
        {
            counter++;
            JeCasVyrabet();
            OdeselPrisel();
            Piticko();
            DodavkaPiti();



            //Console.WriteLine(counter);

        }


        private static void JeCasVyrabet()
        {
            if ((counter % (Pivo10.rychlostVyroby * 10)) == 0)
            {
                Pivo10.Recept();
            }
            if ((counter % (Pivo11.rychlostVyroby * 10)) == 0)
            {
                Pivo11.Recept();
            }
            if ((counter % (Pivo12.rychlostVyroby * 10)) == 0)
            {
                Pivo12.Recept();
            }
        }

        private static void OdeselPrisel()
        {
            if (counter % (DalsiZakaznici * 10) == 0)
            {
                Hospoda.PrisliZakaznici();
                DalsiZakaznici = rd.Next(1, 11);
            }
            if (counter % (ZakazniciPapa * 10) == 0)
            {
                ZakazniciPapa = rd.Next(10, 20);
                Hospoda.OdejdouZakaznici();
            }
        }

        private static void Piticko()
        {
            if (counter % (rd.Next(1, 11)) == 0) Hospoda.CasPit();

        }

        private static void DodavkaPiti()
        {
            if (Hospoda.PotrebujemePivco())
            {
                Dodavatel.Dodavka();
                Console.WriteLine("hos: " + Hospoda.pivoSklad["10"]);
                Console.WriteLine("piv: " + Pivovar.pivoDic["10"]);
            }
        }
    }
}
